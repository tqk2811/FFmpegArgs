using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace FFmpegArgs.Executable
{
    public static class FFmpegBuildExtension
    {
        public static FFmpegBuild Build(this FilterGraph filterGraph, FFmpegBuildConfig config) => FFmpegBuild.FromFilterGraph(filterGraph, config);
        public static FFmpegBuild Build(this FilterGraph filterGraph, Action<FFmpegBuildConfig> config) => FFmpegBuild.FromFilterGraph(filterGraph, config);

        public static bool Execute(this FFmpegBuild build, Action<EncodingProgress> onEncodingProgress, CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            return build.Execute(onEncodingProgress, token);
        }

        public static bool Execute(this FFmpegBuild build, CancellationToken token = default)
        {
            if (build == null) throw new ArgumentNullException(nameof(build));
            ProcessStartInfo info = new ProcessStartInfo(build.Config.FFmpegBinaryPath, build.Arguments)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = build.Config.WorkingDirectory
            };
            using Process process = new Process();
            process.ErrorDataReceived += build.ErrorDataReceived;
            process.OutputDataReceived += build.OutputDataReceived;
            process.StartInfo = info;
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            using var register = token.Register(() => process.Kill());
            process.WaitForExit();
            return process.ExitCode == 0;
        }

        public static Task<bool> ExecuteAsync(this FFmpegBuild build, Action<EncodingProgress> onEncodingProgress, CancellationToken token = default)
           => Task.Run(() => build.Execute(onEncodingProgress, token));
        public static Task<bool> ExecuteAsync(this FFmpegBuild build, CancellationToken token = default) 
            => Task.Run(() => build.Execute(token));

    }
}
