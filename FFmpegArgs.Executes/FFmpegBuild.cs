using System;
using System.Diagnostics;
using System.IO;

namespace FFmpegArgs.Executes
{
    public class FFmpegBuild
    {
        public event Action<EncodingProgress> OnEncodingProgress;
        public event Action<string> OnOutputDataReceived;
        public int ExitCode { get; internal set; } = 0;
        public FFmpegBuildConfig Config { get; }
        internal FFmpegBuild(FFmpegBuildConfig config)
        {
            Config = config;
        }

        public string Arguments { get; private set; }

        internal void ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (OnEncodingProgress != null)
            {
                EncodingProgress progress = EncodingProgress.FromProgressString(e.Data);
                if (progress != null) OnEncodingProgress?.Invoke(progress);
            }
        }

        internal void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OnOutputDataReceived?.Invoke(e?.Data);
        }

        public static FFmpegBuild FromArgument(FFmpegArg ffmpegArg, Action<FFmpegBuildConfig> config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegBuildConfig buildConfig = new FFmpegBuildConfig();
            config.Invoke(buildConfig);
            return FromArgument(ffmpegArg, buildConfig);
        }
        public static FFmpegBuild FromArgument(FFmpegArg ffmpegArg, FFmpegBuildConfig config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegBuild fFmpegBuild = new FFmpegBuild(config);
            string args = ffmpegArg.GetFullCommandline();
            if (config.IsForceUseScript || args.Length > config.ArgumentsMaxLength)
            {
                File.WriteAllText(Path.Combine(config.WorkingDirectory, config.FilterScriptName), ffmpegArg.FilterGraph.GetFiltersArgs(true));
                fFmpegBuild.Arguments = ffmpegArg.GetFullCommandlineWithFilterScript(config.FilterScriptName);
            }
            else fFmpegBuild.Arguments = args;
            return fFmpegBuild;
        }

        public static FFmpegBuild FromArgument(string commands, FFmpegBuildConfig config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));
            return new FFmpegBuild(config)
            {
                Arguments = commands
            };
        }
        public static FFmpegBuild FromArgument(string commands, Action<FFmpegBuildConfig> config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegBuildConfig buildConfig = new FFmpegBuildConfig();
            config.Invoke(buildConfig);
            return FromArgument(commands, buildConfig);
        }
    }
}
