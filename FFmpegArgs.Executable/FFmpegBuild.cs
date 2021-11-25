using System;
using System.Diagnostics;
using System.IO;

namespace FFmpegArgs.Executable
{
    public class FFmpegBuild
    {
        public event Action<EncodingProgress> OnEncodingProgress;
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

        }

        public static FFmpegBuild FromFilterGraph(FilterGraph filterGraph, Action<FFmpegBuildConfig> config)
        {
            if (filterGraph == null) throw new ArgumentNullException(nameof(filterGraph));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegBuildConfig buildConfig = new FFmpegBuildConfig();
            config.Invoke(buildConfig);
            return FromFilterGraph(filterGraph, buildConfig);
        }
        public static FFmpegBuild FromFilterGraph(FilterGraph filterGraph, FFmpegBuildConfig config)
        {
            if (filterGraph == null) throw new ArgumentNullException(nameof(filterGraph));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegBuild fFmpegBuild = new FFmpegBuild(config);
            string args = filterGraph.GetFullCommandline();
            if (config.IsForceUseScript || args.Length > config.ArgumentsMaxLength)
            {
                File.WriteAllText(Path.Combine(config.WorkingDirectory, config.FilterScriptName), filterGraph.GetFiltersArgs(true));
                fFmpegBuild.Arguments = filterGraph.GetFullCommandlineWithFilterScript(config.FilterScriptName);
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
