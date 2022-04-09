namespace FFmpegArgs.Executes
{
    /// <summary>
    /// 
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Render with default <see cref="FFmpegRenderConfig"/> (ffmpeg from PATH/CurrentWorkingDirectory and WorkingDirectory is Current)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static async Task<FFmpegRenderResult> EnsureSuccessAsync(this Task<FFmpegRenderResult> t)
        {
            FFmpegRenderResult result = await t.ConfigureAwait(false);
            return result.EnsureSuccess();
        }
    }
}
