namespace FFmpegArgs.Executes
{
    /// <summary>
    /// 
    /// </summary>
    public static class FFmpegRenderExtension
    {
        /// <summary>
        /// Render with default <see cref="FFmpegRenderConfig"/> (ffmpeg from PATH and WorkingDirectory is Current)
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static FFmpegRender Render(this IFFmpegArg ffmpegArg) => FFmpegRender.FromArguments(ffmpegArg, new FFmpegRenderConfig());
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static FFmpegRender Render(this IFFmpegArg ffmpegArg, FFmpegRenderConfig config) => FFmpegRender.FromArguments(ffmpegArg, config);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static FFmpegRender Render(this IFFmpegArg ffmpegArg, Action<FFmpegRenderConfig> config) => FFmpegRender.FromArguments(ffmpegArg, config);

        private static Process BuildProcess(this FFmpegRender build, FFmpegRenderResult renderResult)
        {
            ProcessStartInfo info = new ProcessStartInfo(build.Config.FFmpegBinaryPath, build.Arguments)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = build.Config.WorkingDirectory
            };
            renderResult.Arguments = build.Arguments;
            Process process = new Process();
            process.ErrorDataReceived += build.ErrorDataReceived;
            process.ErrorDataReceived += (o, d) => renderResult._ErrorDatas.Add(d?.Data ?? string.Empty);
            process.OutputDataReceived += build.OutputDataReceived;
            process.OutputDataReceived += (o, d) => renderResult._OutputDatas.Add(d?.Data ?? string.Empty);
            process.StartInfo = info;
            return process;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="build"></param>
        /// <param name="onEncodingProgress"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static FFmpegRenderResult Execute(
            this FFmpegRender build,
            Action<RenderProgress> onEncodingProgress,
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            return build.Execute(token);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="build"></param>
        /// <param name="onEncodingProgress"></param>
        /// <param name="onOutputDataReceived"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static FFmpegRenderResult Execute(
            this FFmpegRender build,
            Action<RenderProgress> onEncodingProgress,
            Action<string> onOutputDataReceived,
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            build.OnOutputDataReceived += onOutputDataReceived ?? throw new ArgumentNullException(nameof(onOutputDataReceived));
            return build.Execute(token);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="build"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static FFmpegRenderResult Execute(this FFmpegRender build, CancellationToken token = default)
        {
            if (build == null) throw new ArgumentNullException(nameof(build));
            FFmpegRenderResult renderResult = new FFmpegRenderResult();
            using Process process = build.BuildProcess(renderResult);
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            using var register = token.Register(() => process.Kill());
            process.WaitForExit();
            renderResult.ExitCode = process.ExitCode;
            return renderResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="build"></param>
        /// <param name="onEncodingProgress"></param>
        /// <param name="onOutputDataReceived"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Task<FFmpegRenderResult> ExecuteAsync(
            this FFmpegRender build,
            Action<RenderProgress> onEncodingProgress,
            Action<string> onOutputDataReceived,
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            build.OnOutputDataReceived += onOutputDataReceived ?? throw new ArgumentNullException(nameof(onOutputDataReceived));
            return build.ExecuteAsync(token);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="build"></param>
        /// <param name="onEncodingProgress"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Task<FFmpegRenderResult> ExecuteAsync(
            this FFmpegRender build,
            Action<RenderProgress> onEncodingProgress,
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            return build.ExecuteAsync(token);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="build"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static async Task<FFmpegRenderResult> ExecuteAsync(
            this FFmpegRender build,
            CancellationToken token = default)
        {
            if (build == null) throw new ArgumentNullException(nameof(build));
            FFmpegRenderResult renderResult = new FFmpegRenderResult();
            using Process process = build.BuildProcess(renderResult);
#if NET5_0_OR_GREATER
#else
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
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            using var register = token.Register(() => process.Kill());
#if NET5_0_OR_GREATER
            await process.WaitForExitAsync();
#else
            await tcs.Task.ConfigureAwait(false);
#endif
            renderResult.ExitCode = process.ExitCode;
            return renderResult;
        }
    }
}
