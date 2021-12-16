namespace FFmpegArgs.Filters.Enums
{
    /// <summary>
    /// https://github.com/FFmpeg/FFmpeg/blob/f6ab103bb5c2dd494620f7a28ae232efe497a4d1/libavutil/channel_layout.h#L90 <br>
    /// </br>https://ffmpeg.org/ffmpeg-utils.html#channel-layout-syntax
    /// </summary>
    public enum ChannelLayout
    {
        /// <summary>
        /// front left
        /// </summary>
        [Name("FL")] FL,
        /// <summary>
        /// front right
        /// </summary>
        [Name("FR")] FR,
        /// <summary>
        /// front center
        /// </summary>
        [Name("FC")] FC,
        /// <summary>
        /// low frequency
        /// </summary>
        [Name("LFE")] LFE,
        /// <summary>
        /// back left
        /// </summary>
        [Name("BL")] BL,
        /// <summary>
        /// back right
        /// </summary>
        [Name("BR")] BR,
        /// <summary>
        /// front left-of-center
        /// </summary>
        [Name("FLC")] FLC,
        /// <summary>
        /// front right-of-center
        /// </summary>
        [Name("FRC")] FRC,
        /// <summary>
        /// back center
        /// </summary>
        [Name("BC")] BC,
        /// <summary>
        /// side left
        /// </summary>
        [Name("SL")] SL,
        /// <summary>
        /// side right
        /// </summary>
        [Name("SR")] SR,
        /// <summary>
        /// top center
        /// </summary>
        [Name("TC")] TC,
        /// <summary>
        /// top front left
        /// </summary>
        [Name("TFL")] TFL,
        /// <summary>
        /// top front center
        /// </summary>
        [Name("TFC")] TFC,
        /// <summary>
        /// top front right
        /// </summary>
        [Name("TFR")] TFR,
        /// <summary>
        /// top back left
        /// </summary>
        [Name("TBL")] TBL,
        /// <summary>
        /// top back center
        /// </summary>
        [Name("TBC")] TBC,
        /// <summary>
        /// top back right
        /// </summary>
        [Name("TBR")] TBR,
        /// <summary>
        /// downmix left
        /// </summary>
        [Name("DL")] DL,
        /// <summary>
        /// downmix right
        /// </summary>
        [Name("DR")] DR,
        /// <summary>
        /// wide left
        /// </summary>
        [Name("WL")] WL,
        /// <summary>
        /// wide right
        /// </summary>
        [Name("WR")] WR,
        /// <summary>
        /// surround direct left
        /// </summary>
        [Name("SDL")] SDL,
        /// <summary>
        /// surround direct right
        /// </summary>
        [Name("SDR")] SDR,
        /// <summary>
        /// low frequency 2
        /// </summary>
        [Name("LFE2")] LFE2,
        /// <summary>
        /// FC
        /// </summary>
        [Name("mono")] AV_CH_LAYOUT_MONO,
        /// <summary>
        /// FL+FR
        /// </summary>
        [Name("stereo")] AV_CH_LAYOUT_STEREO,
        /// <summary>
        /// FL+FR+LFE
        /// </summary>
        [Name("2.1")] AV_CH_LAYOUT_2POINT1,
        /// <summary>
        /// FL+FR+BC
        /// </summary>
        [Name("3.0(back)")] AV_CH_LAYOUT_2_1,
        /// <summary>
        /// FL+FR+FC
        /// </summary>
        [Name("3.0")] AV_CH_LAYOUT_SURROUND,
        /// <summary>
        /// FL+FR+FC+LFE
        /// </summary>
        [Name("3.1")] AV_CH_LAYOUT_3POINT1,
        /// <summary>
        /// FL+FR+FC+BC
        /// </summary>
        [Name("4.0")] AV_CH_LAYOUT_4POINT0,
        /// <summary>
        /// FL+FR+FC+LFE+BC
        /// </summary>
        [Name("4.1")] AV_CH_LAYOUT_4POINT1,
        /// <summary>
        /// FL+FR+SL+SR
        /// </summary>
        [Name("quad(side)")] AV_CH_LAYOUT_2_2,
        /// <summary>
        /// FL+FR+BL+BR
        /// </summary>
        [Name("quad")] AV_CH_LAYOUT_QUAD,
        /// <summary>
        /// FL+FR+FC+SL+SR
        /// </summary>
        [Name("5.0(side)")] AV_CH_LAYOUT_5POINT0,
        /// <summary>
        /// FL+FR+FC+LFE+SL+SR
        /// </summary>
        [Name("5.1(side)")] AV_CH_LAYOUT_5POINT1,
        /// <summary>
        /// FL+FR+FC+BL+BR
        /// </summary>
        [Name("5.0")] AV_CH_LAYOUT_5POINT0_BACK,
        /// <summary>
        /// FL+FR+FC+LFE+BL+BR
        /// </summary>
        [Name("5.1")] AV_CH_LAYOUT_5POINT1_BACK,
        /// <summary>
        /// FL+FR+FC+BC+SL+SR
        /// </summary>
        [Name("6.0")]
        AV_CH_LAYOUT_6POINT0,
        /// <summary>
        /// FL+FR+FLC+FRC+SL+SR
        /// </summary>
        [Name("6.0(front)")] AV_CH_LAYOUT_6POINT0_FRONT,
        /// <summary>
        /// FL+FR+FC+BL+BR+BC
        /// </summary>
        [Name("hexagonal")] AV_CH_LAYOUT_HEXAGONAL,
        /// <summary>
        /// FL+FR+FC+LFE+BC+SL+SR
        /// </summary>
        [Name("6.1")] AV_CH_LAYOUT_6POINT1,

        [Name("6.1(back)")] AV_CH_LAYOUT_6POINT1_BACK,
        /// <summary>
        /// FL+FR+LFE+FLC+FRC+SL+SR
        /// </summary>
        [Name("6.1(front)")] AV_CH_LAYOUT_6POINT1_FRONT,
        /// <summary>
        /// FL+FR+FC+BL+BR+SL+SR
        /// </summary>
        [Name("7.0")] AV_CH_LAYOUT_7POINT0,
        /// <summary>
        /// FL+FR+FC+FLC+FRC+SL+SR
        /// </summary>
        [Name("7.0(front)")] AV_CH_LAYOUT_7POINT0_FRONT,
        /// <summary>
        /// FL+FR+FC+LFE+BL+BR+SL+SR
        /// </summary>
        [Name("7.1")] AV_CH_LAYOUT_7POINT1,
        /// <summary>
        /// FL+FR+FC+LFE+FLC+FRC+SL+SR
        /// </summary>
        [Name("7.1(wide-side)")] AV_CH_LAYOUT_7POINT1_WIDE,
        /// <summary>
        /// FL+FR+FC+LFE+BL+BR+FLC+FRC
        /// </summary>
        [Name("7.1(wide)")] AV_CH_LAYOUT_7POINT1_WIDE_BACK,
        /// <summary>
        /// FL+FR+FC+BL+BR+BC+SL+SR
        /// </summary>
        [Name("octagonal")] AV_CH_LAYOUT_OCTAGONAL,
        /// <summary>
        /// FL+FR+FC+BL+BR+BC+SL+SR+WL+WR+TBL+TBR+TBC+TFC+TFL+TFR
        /// </summary>
        [Name("hexadecagonal")] AV_CH_LAYOUT_HEXADECAGONAL,
        /// <summary>
        /// DL+DR
        /// </summary>
        [Name("downmix")] AV_CH_LAYOUT_STEREO_DOWNMIX,

        [Name("22.2")]
        AV_CH_LAYOUT_22POINT2

    }
}