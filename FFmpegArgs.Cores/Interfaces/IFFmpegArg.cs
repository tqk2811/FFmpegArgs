namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFFmpegArg : IBaseFFArg
    {

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<BaseOutput> Outputs { get; }


        /// <summary>
        /// 
        /// </summary>
        FilterGraph FilterGraph { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        IEnumerable<AudioMap> AddAudiosInput(AudioInput sound);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        IEnumerable<ImageMap> AddImagesInput(ImageInput image);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        VideoMap AddVideoInput(VideoInput video);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="output"></param>
        void AddOutput(BaseOutput output);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetGlobalArgs();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetInputsArgs();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetOutputsArgs();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="useChain"></param>
        /// <returns></returns>
        string GetFullCommandline(bool useChain = true);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="script_name_or_path"></param>
        /// <returns></returns>
        string GetFullCommandlineWithFilterScript(string script_name_or_path);

    }
}
