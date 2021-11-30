using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace FFmpegArgs.Executes
{
    public static class FFmpegRenderExtension
    {
        public static FFmpegRender Build(this FFmpegArg ffmpegArg, FFmpegRenderConfig config) => FFmpegRender.FromArgument(ffmpegArg, config);
        public static FFmpegRender Build(this FFmpegArg ffmpegArg, Action<FFmpegRenderConfig> config) => FFmpegRender.FromArgument(ffmpegArg, config);



        public static FFmpegRender Execute(
            this FFmpegRender build, 
            Action<RenderProgress> onEncodingProgress, 
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            return build.Execute(onEncodingProgress, token);
        }

        public static FFmpegRender Execute(
            this FFmpegRender build,
            Action<RenderProgress> onEncodingProgress,
            Action<string> onOutputDataReceived, 
            CancellationToken token = default)
        {
            build.OnEncodingProgress += onEncodingProgress ?? throw new ArgumentNullException(nameof(onEncodingProgress));
            build.OnOutputDataReceived += onOutputDataReceived ?? throw new ArgumentNullException(nameof(onOutputDataReceived));
            return build.Execute(onEncodingProgress, token);
        }

        public static FFmpegRender Execute(this FFmpegRender build, CancellationToken token = default)
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



        public static Task<FFmpegRender> ExecuteAsync(
            this FFmpegRender build,
            Action<RenderProgress> onEncodingProgress,
            Action<string> onOutputDataReceived,
            CancellationToken token = default)
           => Task.Run(() => build.Execute(onEncodingProgress, onOutputDataReceived, token));
        public static Task<FFmpegRender> ExecuteAsync(
            this FFmpegRender build, 
            Action<RenderProgress> onEncodingProgress, 
            CancellationToken token = default)
           => Task.Run(() => build.Execute(onEncodingProgress, token));
        public static Task<FFmpegRender> ExecuteAsync(
            this FFmpegRender build, 
            CancellationToken token = default)
            => Task.Run(() => build.Execute(token));

    }
}
