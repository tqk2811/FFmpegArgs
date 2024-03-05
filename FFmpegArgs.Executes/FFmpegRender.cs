namespace FFmpegArgs.Executes
{
    /// <summary>
    /// 
    /// </summary>
    public class FFmpegRender
    {
        /// <summary>
        /// 
        /// </summary>
        public event Action<RenderProgress> OnEncodingProgress;

        /// <summary>
        /// 
        /// </summary>
        public FFmpegRenderConfig Config { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Arguments { get; private set; }




        private Stream StdIn { get; set; }
        private Stream StdOut { get; set; }
        private bool _isFromFFmpegArgs = false;

        private FFmpegRender(FFmpegRenderConfig config)
        {
            Config = config;
        }


        private Process BuildProcess(FFmpegRenderResult renderResult)
        {
            ProcessStartInfo info = new ProcessStartInfo(this.Config.FFmpegBinaryPath, this.Arguments)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = this.StdOut != null,
                RedirectStandardInput = this.StdIn != null,
                RedirectStandardError = true,
                WorkingDirectory = this.Config.WorkingDirectory
            };
            renderResult.Arguments = this.Arguments;
            Process process = new Process();
            process.ErrorDataReceived += (s, e) =>
            {
                RenderProgress progress = RenderProgress.FromProgressString(e?.Data);
                if (progress is not null)
                {
                    OnEncodingProgress?.Invoke(progress);
                }
                else
                {
                    renderResult._ErrorDatas.Add(e?.Data ?? string.Empty);
                }
            };
            process.StartInfo = info;
            return process;
        }



        #region SetPipe
        /// <summary>
        /// Set pipe input
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public FFmpegRender WithStdInStream(Stream stream)
        {
            if (this.StdIn != null)
                throw new InvalidOperationException("StdIn Stream was setted");

            if (this._isFromFFmpegArgs)
                throw new InvalidOperationException($"Not allow set pipe to {nameof(FFmpegRender)} build from {nameof(IFFmpegArg)}");

            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            if (!stream.CanRead)
                throw new InvalidOperationException("input stream.CanRead is required");

            this.StdIn = stream;

            return this;
        }


        /// <summary>
        /// Set pipe output
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public FFmpegRender WithStdOutStream(Stream stream)
        {
            if (this.StdOut != null)
                throw new InvalidOperationException("StdOut Stream was setted");

            if (this._isFromFFmpegArgs)
                throw new InvalidOperationException($"Not allow set pipe to {nameof(FFmpegRender)} build from {nameof(IFFmpegArg)}");

            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            if (!stream.CanWrite)
                throw new InvalidOperationException("input stream.CanWrite is required");

            this.StdOut = stream;

            return this;
        }
        #endregion



        #region Execute

        /// <summary>
        /// 
        /// </summary>
        /// <param name="onEncodingProgress"></param>
        /// <param name="token">Trigger kill process</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public FFmpegRenderResult Execute(Action<RenderProgress> onEncodingProgress, CancellationToken token = default)
        {
            this.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            return this.Execute(token);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">Trigger kill process</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public FFmpegRenderResult Execute(CancellationToken token = default)
        {
            FFmpegRenderResult renderResult = new FFmpegRenderResult();
            using Process process = this.BuildProcess(renderResult);
            if (!process.Start())
            {
                throw new InvalidOperationException("Failed to obtain the handle when starting a process. " +
                    "This could mean that the target executable doesn't exist or that execute permission is missing.");
            }
            using var register = token.Register(() => { try { process.Kill(); } catch { } });
            process.BeginErrorReadLine();
            if (this.StdIn != null)
            {
                this.StdIn.CopyTo(process.StandardInput.BaseStream);
                process.StandardInput.BaseStream.Close();
            }
            if (this.StdOut != null) process.StandardOutput.BaseStream.CopyTo(this.StdOut);
            process.WaitForExit();
            renderResult.ExitCode = process.ExitCode;
            return renderResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="onEncodingProgress"></param>
        /// <param name="token">Trigger kill process</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public Task<FFmpegRenderResult> ExecuteAsync(Action<RenderProgress> onEncodingProgress, CancellationToken token = default)
        {
            this.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            return this.ExecuteAsync(token);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">Trigger kill process</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<FFmpegRenderResult> ExecuteAsync(CancellationToken token = default)
        {
            FFmpegRenderResult renderResult = new FFmpegRenderResult();
            using Process process = this.BuildProcess(renderResult);

#if !NET5_0_OR_GREATER
            //https://github.com/Tyrrrz/CliWrap/blob/8ff36a648d57b22497a7cb6feae14ef28bbb2be8/CliWrap/Utils/ProcessEx.cs#L41
            var tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);
#endif
            if (!process.Start())
            {
                throw new InvalidOperationException("Failed to obtain the handle when starting a process. " +
                    "This could mean that the target executable doesn't exist or that execute permission is missing.");
            }
            using var register = token.Register(() => { try { process.Kill(); } catch { } });
            process.BeginErrorReadLine();
            if (this.StdIn != null)
            {
                await this.StdIn.CopyToAsync(process.StandardInput.BaseStream, 81920, token);
                process.StandardInput.BaseStream.Close();
            }
            if (this.StdOut != null) await process.StandardOutput.BaseStream.CopyToAsync(this.StdOut, 81920, token);
#if NET5_0_OR_GREATER
            await process.WaitForExitAsync();
#else
            await tcs.Task.ConfigureAwait(false);
#endif
            renderResult.ExitCode = process.ExitCode;
            return renderResult;
        }

        #endregion



        #region Build

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArguments(IFFmpegArg ffmpegArg, Action<FFmpegRenderConfig> config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));
            FFmpegRenderConfig buildConfig = new FFmpegRenderConfig();
            config.Invoke(buildConfig);
            return FromArguments(ffmpegArg, buildConfig);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArguments(IFFmpegArg ffmpegArg, FFmpegRenderConfig config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));
            FFmpegRender ffmpegBuild = new FFmpegRender(config);
            ffmpegBuild._isFromFFmpegArgs = true;
            ffmpegBuild.StdIn = ffmpegArg.Inputs.FirstOrDefault(x => x.PipeStream != null)?.PipeStream;
            ffmpegBuild.StdOut = ffmpegArg.Outputs.FirstOrDefault(x => x.PipeStream != null)?.PipeStream;
            string args = ffmpegArg.GetFullCommandline(config.IsUseFilterChain);
            if (config.IsForceUseScript || (config.ArgumentsMaxLength > 0 && args.Length > config.ArgumentsMaxLength))
            {
                string scripts = ffmpegArg.FilterGraph.GetFiltersArgs(true, true);
                if (string.IsNullOrWhiteSpace(scripts)) throw new ProcessArgumentOutOfRangeException($"{nameof(IFFmpegArg)} argument too long");
                File.WriteAllText(Path.Combine(config.WorkingDirectory, config.FilterScriptName), scripts);
                ffmpegBuild.Arguments = ffmpegArg.GetFullCommandlineWithFilterScript(config.FilterScriptName);
                if (config.ArgumentsMaxLength > 0 &&  ffmpegBuild.Arguments.Length > config.ArgumentsMaxLength) 
                    throw new ProcessArgumentOutOfRangeException($"{nameof(IFFmpegArg)} argument too long");
            }
            else ffmpegBuild.Arguments = args;
            return ffmpegBuild;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArguments(string commands, FFmpegRenderConfig config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));
            if (commands.Length > config.ArgumentsMaxLength) throw new ProcessArgumentOutOfRangeException($"{nameof(commands)} too long");
            return new FFmpegRender(config)
            {
                Arguments = commands
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArguments(string commands, Action<FFmpegRenderConfig> config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));
            FFmpegRenderConfig buildConfig = new FFmpegRenderConfig();
            config.Invoke(buildConfig);
            return FromArguments(commands, buildConfig);
        }

        #endregion
    }
}
