namespace FFmpegArgs.Cores
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFFmpegArg
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<BaseInput> Inputs { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<BaseOutput> Outputs { get; }

        /// <summary>
        /// 
        /// </summary>
        IFilterGraph FilterGraph { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sound"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IEnumerable<AudioMap> AddAudiosInput(AudioInput sound, int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sound"></param>
        /// <returns></returns>
        AudioMap AddAudioInput(AudioInput sound);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IEnumerable<ImageMap> AddImagesInput(ImageInput image, int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        ImageMap AddImageInput(ImageInput image);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="video"></param>
        /// <param name="imageCount"></param>
        /// <param name="audioCount"></param>
        /// <returns></returns>
        VideoMap AddVideoInput(VideoInput video, int imageCount = 1, int audioCount = 1);

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
