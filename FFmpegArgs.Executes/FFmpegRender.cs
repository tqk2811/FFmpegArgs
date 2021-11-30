using System;
using System.Diagnostics;
using System.IO;

namespace FFmpegArgs.Executes
{
    public class FFmpegRender
    {
        public event Action<RenderProgress> OnEncodingProgress;
        public event Action<string> OnOutputDataReceived;
        public int ExitCode { get; internal set; } = 0;
        public FFmpegRenderConfig Config { get; }
        internal FFmpegRender(FFmpegRenderConfig config)
        {
            Config = config;
        }

        public string Arguments { get; private set; }

        internal void ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (OnEncodingProgress != null)
            {
                RenderProgress progress = RenderProgress.FromProgressString(e.Data);
                if (progress != null) OnEncodingProgress?.Invoke(progress);
            }
        }

        internal void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OnOutputDataReceived?.Invoke(e?.Data);
        }

        public static FFmpegRender FromArgument(FFmpegArg ffmpegArg, Action<FFmpegRenderConfig> config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegRenderConfig buildConfig = new FFmpegRenderConfig();
            config.Invoke(buildConfig);
            return FromArgument(ffmpegArg, buildConfig);
        }
        public static FFmpegRender FromArgument(FFmpegArg ffmpegArg, FFmpegRenderConfig config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegRender fFmpegBuild = new FFmpegRender(config);
            string args = ffmpegArg.GetFullCommandline();
            if (config.IsForceUseScript || args.Length > config.ArgumentsMaxLength)
            {
                File.WriteAllText(Path.Combine(config.WorkingDirectory, config.FilterScriptName), ffmpegArg.FilterGraph.GetFiltersArgs(true));
                fFmpegBuild.Arguments = ffmpegArg.GetFullCommandlineWithFilterScript(config.FilterScriptName);
            }
            else fFmpegBuild.Arguments = args;
            return fFmpegBuild;
        }

        public static FFmpegRender FromArgument(string commands, FFmpegRenderConfig config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));
            return new FFmpegRender(config)
            {
                Arguments = commands
            };
        }
        public static FFmpegRender FromArgument(string commands, Action<FFmpegRenderConfig> config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegRenderConfig buildConfig = new FFmpegRenderConfig();
            config.Invoke(buildConfig);
            return FromArgument(commands, buildConfig);
        }
    }
}
