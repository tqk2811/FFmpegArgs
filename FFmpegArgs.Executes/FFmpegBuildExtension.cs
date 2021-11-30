using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace FFmpegArgs.Executes
{
    public static class FFmpegBuildExtension
    {
        public static FFmpegBuild Build(this FFmpegArg ffmpegArg, FFmpegBuildConfig config) => FFmpegBuild.FromArgument(ffmpegArg, config);
        public static FFmpegBuild Build(this FFmpegArg ffmpegArg, Action<FFmpegBuildConfig> config) => FFmpegBuild.FromArgument(ffmpegArg, config);



        public static FFmpegBuild Execute(
            this FFmpegBuild build, 
            Action<EncodingProgress> onEncodingProgress, 
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            return build.Execute(onEncodingProgress, token);
        }

        public static FFmpegBuild Execute(
            this FFmpegBuild build,
            Action<EncodingProgress> onEncodingProgress,
            Action<string> onOutputDataReceived, 
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            build.OnOutputDataReceived += onOutputDataReceived ?? throw new ArgumentNullException(nameof(onOutputDataReceived));
            return build.Execute(onEncodingProgress, token);
        }

        public static FFmpegBuild Execute(this FFmpegBuild build, CancellationToken token = default)
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
            build.ExitCode = process.ExitCode;
            return build;
        }



        public static Task<FFmpegBuild> ExecuteAsync(
            this FFmpegBuild build,
            Action<EncodingProgress> onEncodingProgress,
            Action<string> onOutputDataReceived,
            CancellationToken token = default)
           => Task.Run(() => build.Execute(onEncodingProgress, onOutputDataReceived, token));
        public static Task<FFmpegBuild> ExecuteAsync(
            this FFmpegBuild build, 
            Action<EncodingProgress> onEncodingProgress, 
            CancellationToken token = default)
           => Task.Run(() => build.Execute(onEncodingProgress, token));
        public static Task<FFmpegBuild> ExecuteAsync(
            this FFmpegBuild build, 
            CancellationToken token = default)
            => Task.Run(() => build.Execute(token));

    }
}
