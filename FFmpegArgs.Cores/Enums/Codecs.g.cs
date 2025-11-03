namespace FFmpegArgs.Cores.Enums
{
    /// <summary>
    /// </summary>
    public enum Codecs
    {
        /// <summary>
        /// Uncompressed 4:2:2 10-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("012v")]
        _012v,
        /// <summary>
        /// 4X Movie
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("4xm")]
        _4xm,
        /// <summary>
        /// QuickTime 8BPS video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("8bps")]
        _8bps,
        /// <summary>
        /// Multicolor charset for Commodore 64 (encoders: a64multi)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute(".EVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("a64_multi")]
        a64_multi,
        /// <summary>
        /// Multicolor charset for Commodore 64, extended with 5th color (colram) (encoders: a64multi5)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute(".EVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("a64_multi5")]
        a64_multi5,
        /// <summary>
        /// Autodesk RLE
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aasc")]
        aasc,
        /// <summary>
        /// Amuse Graphics Movie
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("agm")]
        agm,
        /// <summary>
        /// Apple Intermediate Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aic")]
        aic,
        /// <summary>
        /// Alias/Wavefront PIX image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("alias_pix")]
        alias_pix,
        /// <summary>
        /// AMV Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("amv")]
        amv,
        /// <summary>
        /// Deluxe Paint Animation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("anm")]
        anm,
        /// <summary>
        /// ASCII/ANSI art
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ansi")]
        ansi,
        /// <summary>
        /// APNG (Animated Portable Network Graphics) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("apng")]
        apng,
        /// <summary>
        /// Advanced Professional Video (encoders: liboapv)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("apv")]
        apv,
        /// <summary>
        /// Gryphon&apos;s Anim Compressor
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("arbc")]
        arbc,
        /// <summary>
        /// Argonaut Games Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("argo")]
        argo,
        /// <summary>
        /// ASUS V1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("asv1")]
        asv1,
        /// <summary>
        /// ASUS V2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("asv2")]
        asv2,
        /// <summary>
        /// Auravision AURA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aura")]
        aura,
        /// <summary>
        /// Auravision Aura 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aura2")]
        aura2,
        /// <summary>
        /// Alliance for Open Media AV1 (decoders: libdav1d libaom-av1 av1 av1_cuvid av1_qsv av1_amf) (encoders: libaom-av1 librav1e libsvtav1 av1_nvenc av1_qsv av1_amf av1_mf av1_vaapi av1_vulkan)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("av1")]
        av1,
        /// <summary>
        /// Avid AVI Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("avrn")]
        avrn,
        /// <summary>
        /// Avid 1:1 10-bit RGB Packer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("avrp")]
        avrp,
        /// <summary>
        /// AVS (Audio Video Standard) video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("avs")]
        avs,
        /// <summary>
        /// AVS2-P2/IEEE1857.4 (decoders: libdavs2) (encoders: libxavs2)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("avs2")]
        avs2,
        /// <summary>
        /// AVS3-P2/IEEE1857.10 (decoders: libuavs3d)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("avs3")]
        avs3,
        /// <summary>
        /// Avid Meridien Uncompressed
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("avui")]
        avui,
        /// <summary>
        /// Bethesda VID video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bethsoftvid")]
        bethsoftvid,
        /// <summary>
        /// Brute Force &amp; Ignorance
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bfi")]
        bfi,
        /// <summary>
        /// Bink video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("binkvideo")]
        binkvideo,
        /// <summary>
        /// Binary text
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI..")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bintext")]
        bintext,
        /// <summary>
        /// Bitpacked
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bitpacked")]
        bitpacked,
        /// <summary>
        /// BMP (Windows and OS/2 bitmap)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bmp")]
        bmp,
        /// <summary>
        /// Discworld II BMV video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bmv_video")]
        bmv_video,
        /// <summary>
        /// BRender PIX image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("brender_pix")]
        brender_pix,
        /// <summary>
        /// Interplay C93
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("c93")]
        c93,
        /// <summary>
        /// Chinese AVS (Audio Video Standard) (AVS1-P2, JiZhun profile)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cavs")]
        cavs,
        /// <summary>
        /// CD Graphics video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cdgraphics")]
        cdgraphics,
        /// <summary>
        /// CDToons video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cdtoons")]
        cdtoons,
        /// <summary>
        /// Commodore CDXL video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cdxl")]
        cdxl,
        /// <summary>
        /// GoPro CineForm HD
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cfhd")]
        cfhd,
        /// <summary>
        /// Cinepak
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cinepak")]
        cinepak,
        /// <summary>
        /// Iterated Systems ClearVideo
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("clearvideo")]
        clearvideo,
        /// <summary>
        /// Cirrus Logic AccuPak
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cljr")]
        cljr,
        /// <summary>
        /// Canopus Lossless Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cllc")]
        cllc,
        /// <summary>
        /// Electronic Arts CMV video (decoders: eacmv)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cmv")]
        cmv,
        /// <summary>
        /// CPiA video format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cpia")]
        cpia,
        /// <summary>
        /// Cintel RAW
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cri")]
        cri,
        /// <summary>
        /// CamStudio (decoders: camstudio)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cscd")]
        cscd,
        /// <summary>
        /// Creative YUV (CYUV)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cyuv")]
        cyuv,
        /// <summary>
        /// Daala
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..V.LS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("daala")]
        daala,
        /// <summary>
        /// DirectDraw Surface image decoder
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dds")]
        dds,
        /// <summary>
        /// Chronomaster DFA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dfa")]
        dfa,
        /// <summary>
        /// Dirac (encoders: vc2)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.LS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dirac")]
        dirac,
        /// <summary>
        /// VC3/DNxHD
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dnxhd")]
        dnxhd,
        /// <summary>
        /// DNxUncompressed / SMPTE RDD 50
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dnxuc")]
        dnxuc,
        /// <summary>
        /// DPX (Digital Picture Exchange) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dpx")]
        dpx,
        /// <summary>
        /// Delphine Software International CIN video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dsicinvideo")]
        dsicinvideo,
        /// <summary>
        /// DV (Digital Video)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dvvideo")]
        dvvideo,
        /// <summary>
        /// Feeble Files/ScummVM DXA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dxa")]
        dxa,
        /// <summary>
        /// Dxtory
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dxtory")]
        dxtory,
        /// <summary>
        /// Resolume DXV
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dxv")]
        dxv,
        /// <summary>
        /// Escape 124
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("escape124")]
        escape124,
        /// <summary>
        /// Escape 130
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("escape130")]
        escape130,
        /// <summary>
        /// MPEG-5 EVC (Essential Video Coding)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("evc")]
        evc,
        /// <summary>
        /// OpenEXR image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("exr")]
        exr,
        /// <summary>
        /// FFmpeg video codec #1 (encoders: ffv1 ffv1_vulkan)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ffv1")]
        ffv1,
        /// <summary>
        /// Huffyuv FFmpeg variant
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ffvhuff")]
        ffvhuff,
        /// <summary>
        /// Mirillis FIC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("fic")]
        fic,
        /// <summary>
        /// FITS (Flexible Image Transport System)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("fits")]
        fits,
        /// <summary>
        /// Flash Screen Video v1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("flashsv")]
        flashsv,
        /// <summary>
        /// Flash Screen Video v2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("flashsv2")]
        flashsv2,
        /// <summary>
        /// Autodesk Animator Flic video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("flic")]
        flic,
        /// <summary>
        /// FLV / Sorenson Spark / Sorenson H.263 (Flash Video) (decoders: flv) (encoders: flv)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("flv1")]
        flv1,
        /// <summary>
        /// FM Screen Capture Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("fmvc")]
        fmvc,
        /// <summary>
        /// Fraps
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("fraps")]
        fraps,
        /// <summary>
        /// Forward Uncompressed
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("frwu")]
        frwu,
        /// <summary>
        /// Go2Meeting
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("g2m")]
        g2m,
        /// <summary>
        /// Gremlin Digital Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("gdv")]
        gdv,
        /// <summary>
        /// GEM Raster image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("gem")]
        gem,
        /// <summary>
        /// CompuServe GIF (Graphics Interchange Format)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("gif")]
        gif,
        /// <summary>
        /// H.261
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("h261")]
        h261,
        /// <summary>
        /// H.263 / H.263-1996, H.263+ / H.263-1998 / H.263 version 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("h263")]
        h263,
        /// <summary>
        /// Intel H.263
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("h263i")]
        h263i,
        /// <summary>
        /// H.263+ / H.263-1998 / H.263 version 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("h263p")]
        h263p,
        /// <summary>
        /// H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10 (decoders: h264 h264_qsv libopenh264 h264_amf h264_cuvid) (encoders: libx264 libx264rgb libopenh264 h264_amf h264_mf h264_nvenc h264_qsv h264_vaapi h264_vulkan)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.LS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("h264")]
        h264,
        /// <summary>
        /// Vidvox Hap
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hap")]
        hap,
        /// <summary>
        /// HDR (Radiance RGBE format) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hdr")]
        hdr,
        /// <summary>
        /// H.265 / HEVC (High Efficiency Video Coding) (decoders: hevc hevc_qsv hevc_amf hevc_cuvid) (encoders: libx265 hevc_amf hevc_d3d12va hevc_mf hevc_nvenc hevc_qsv hevc_vaapi hevc_vulkan libkvazaar)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hevc")]
        hevc,
        /// <summary>
        /// HNM 4 video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hnm4video")]
        hnm4video,
        /// <summary>
        /// Canopus HQ/HQA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hq_hqa")]
        hq_hqa,
        /// <summary>
        /// Canopus HQX
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hqx")]
        hqx,
        /// <summary>
        /// HuffYUV
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("huffyuv")]
        huffyuv,
        /// <summary>
        /// HuffYUV MT
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hymt")]
        hymt,
        /// <summary>
        /// id Quake II CIN video (decoders: idcinvideo)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("idcin")]
        idcin,
        /// <summary>
        /// iCEDraw text
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI..")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("idf")]
        idf,
        /// <summary>
        /// IFF ACBM/ANIM/DEEP/ILBM/PBM/RGB8/RGBN (decoders: iff)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("iff_ilbm")]
        iff_ilbm,
        /// <summary>
        /// Infinity IMM4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("imm4")]
        imm4,
        /// <summary>
        /// Infinity IMM5
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("imm5")]
        imm5,
        /// <summary>
        /// Intel Indeo 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("indeo2")]
        indeo2,
        /// <summary>
        /// Intel Indeo 3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("indeo3")]
        indeo3,
        /// <summary>
        /// Intel Indeo Video Interactive 4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("indeo4")]
        indeo4,
        /// <summary>
        /// Intel Indeo Video Interactive 5
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("indeo5")]
        indeo5,
        /// <summary>
        /// Interplay MVE video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("interplayvideo")]
        interplayvideo,
        /// <summary>
        /// IPU Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ipu")]
        ipu,
        /// <summary>
        /// JPEG 2000 (encoders: jpeg2000 libopenjpeg)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg2000")]
        jpeg2000,
        /// <summary>
        /// JPEG-LS
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpegls")]
        jpegls,
        /// <summary>
        /// JPEG XL (decoders: libjxl) (encoders: libjxl)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpegxl")]
        jpegxl,
        /// <summary>
        /// JPEG XL animated (decoders: libjxl_anim) (encoders: libjxl_anim)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.LS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpegxl_anim")]
        jpegxl_anim,
        /// <summary>
        /// Bitmap Brothers JV video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("jv")]
        jv,
        /// <summary>
        /// Kega Game Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("kgv1")]
        kgv1,
        /// <summary>
        /// Karl Morton&apos;s video codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("kmvc")]
        kmvc,
        /// <summary>
        /// Lagarith lossless
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("lagarith")]
        lagarith,
        /// <summary>
        /// LEAD MCMP
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("lead")]
        lead,
        /// <summary>
        /// Lossless JPEG
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute(".EVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ljpeg")]
        ljpeg,
        /// <summary>
        /// LOCO
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("loco")]
        loco,
        /// <summary>
        /// LEAD Screen Capture
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("lscr")]
        lscr,
        /// <summary>
        /// Matrox Uncompressed SD
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("m101")]
        m101,
        /// <summary>
        /// Electronic Arts Madcow Video (decoders: eamad)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mad")]
        mad,
        /// <summary>
        /// MagicYUV video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("magicyuv")]
        magicyuv,
        /// <summary>
        /// Sony PlayStation MDEC (Motion DECoder)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mdec")]
        mdec,
        /// <summary>
        /// Media 100i
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("media100")]
        media100,
        /// <summary>
        /// Mimic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mimic")]
        mimic,
        /// <summary>
        /// Motion JPEG (decoders: mjpeg mjpeg_cuvid mjpeg_qsv) (encoders: mjpeg mjpeg_qsv mjpeg_vaapi)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mjpeg")]
        mjpeg,
        /// <summary>
        /// Apple MJPEG-B
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mjpegb")]
        mjpegb,
        /// <summary>
        /// American Laser Games MM Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mmvideo")]
        mmvideo,
        /// <summary>
        /// MobiClip Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mobiclip")]
        mobiclip,
        /// <summary>
        /// Motion Pixels video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("motionpixels")]
        motionpixels,
        /// <summary>
        /// MPEG-1 video (decoders: mpeg1video mpeg1_cuvid)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg1video")]
        mpeg1video,
        /// <summary>
        /// MPEG-2 video (decoders: mpeg2video mpegvideo mpeg2_qsv mpeg2_cuvid) (encoders: mpeg2video mpeg2_qsv mpeg2_vaapi)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg2video")]
        mpeg2video,
        /// <summary>
        /// MPEG-4 part 2 (decoders: mpeg4 mpeg4_cuvid) (encoders: mpeg4 libxvid)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg4")]
        mpeg4,
        /// <summary>
        /// MS ATC Screen
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msa1")]
        msa1,
        /// <summary>
        /// Mandsoft Screen Capture Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mscc")]
        mscc,
        /// <summary>
        /// MPEG-4 part 2 Microsoft variant version 1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msmpeg4v1")]
        msmpeg4v1,
        /// <summary>
        /// MPEG-4 part 2 Microsoft variant version 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msmpeg4v2")]
        msmpeg4v2,
        /// <summary>
        /// MPEG-4 part 2 Microsoft variant version 3 (decoders: msmpeg4) (encoders: msmpeg4)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msmpeg4v3")]
        msmpeg4v3,
        /// <summary>
        /// Microsoft Paint (MSP) version 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msp2")]
        msp2,
        /// <summary>
        /// Microsoft RLE
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msrle")]
        msrle,
        /// <summary>
        /// MS Screen 1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mss1")]
        mss1,
        /// <summary>
        /// MS Windows Media Video V9 Screen
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mss2")]
        mss2,
        /// <summary>
        /// Microsoft Video 1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msvideo1")]
        msvideo1,
        /// <summary>
        /// LCL (LossLess Codec Library) MSZH
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mszh")]
        mszh,
        /// <summary>
        /// MS Expression Encoder Screen
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mts2")]
        mts2,
        /// <summary>
        /// MidiVid 3.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mv30")]
        mv30,
        /// <summary>
        /// Silicon Graphics Motion Video Compressor 1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mvc1")]
        mvc1,
        /// <summary>
        /// Silicon Graphics Motion Video Compressor 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mvc2")]
        mvc2,
        /// <summary>
        /// MidiVid VQ
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mvdv")]
        mvdv,
        /// <summary>
        /// MidiVid Archive Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mvha")]
        mvha,
        /// <summary>
        /// MatchWare Screen Capture Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mwsc")]
        mwsc,
        /// <summary>
        /// Mobotix MxPEG video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mxpeg")]
        mxpeg,
        /// <summary>
        /// NotchLC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("notchlc")]
        notchlc,
        /// <summary>
        /// NuppelVideo/RTJPEG
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("nuv")]
        nuv,
        /// <summary>
        /// Amazing Studio Packed Animation File Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("paf_video")]
        paf_video,
        /// <summary>
        /// PAM (Portable AnyMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pam")]
        pam,
        /// <summary>
        /// PBM (Portable BitMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pbm")]
        pbm,
        /// <summary>
        /// PC Paintbrush PCX image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcx")]
        pcx,
        /// <summary>
        /// PDV (PlayDate Video)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pdv")]
        pdv,
        /// <summary>
        /// PFM (Portable FloatMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pfm")]
        pfm,
        /// <summary>
        /// PGM (Portable GrayMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pgm")]
        pgm,
        /// <summary>
        /// PGMYUV (Portable GrayMap YUV) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pgmyuv")]
        pgmyuv,
        /// <summary>
        /// PGX (JPEG2000 Test Format)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pgx")]
        pgx,
        /// <summary>
        /// PHM (Portable HalfFloatMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("phm")]
        phm,
        /// <summary>
        /// Kodak Photo CD
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("photocd")]
        photocd,
        /// <summary>
        /// Pictor/PC Paint
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pictor")]
        pictor,
        /// <summary>
        /// Apple Pixlet
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pixlet")]
        pixlet,
        /// <summary>
        /// PNG (Portable Network Graphics) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("png")]
        png,
        /// <summary>
        /// PPM (Portable PixelMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ppm")]
        ppm,
        /// <summary>
        /// Apple ProRes (iCodec Pro) (encoders: prores prores_aw prores_ks)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("prores")]
        prores,
        /// <summary>
        /// Apple ProRes RAW
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("prores_raw")]
        prores_raw,
        /// <summary>
        /// Brooktree ProSumer Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("prosumer")]
        prosumer,
        /// <summary>
        /// Photoshop PSD file
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("psd")]
        psd,
        /// <summary>
        /// V.Flash PTX image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ptx")]
        ptx,
        /// <summary>
        /// Apple QuickDraw
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qdraw")]
        qdraw,
        /// <summary>
        /// QOI (Quite OK Image)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qoi")]
        qoi,
        /// <summary>
        /// Q-team QPEG
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qpeg")]
        qpeg,
        /// <summary>
        /// QuickTime Animation (RLE) video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qtrle")]
        qtrle,
        /// <summary>
        /// AJA Kona 10-bit RGB Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("r10k")]
        r10k,
        /// <summary>
        /// Uncompressed RGB 10-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("r210")]
        r210,
        /// <summary>
        /// RemotelyAnywhere Screen Capture
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rasc")]
        rasc,
        /// <summary>
        /// raw video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rawvideo")]
        rawvideo,
        /// <summary>
        /// RL2 video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rl2")]
        rl2,
        /// <summary>
        /// id RoQ video (decoders: roqvideo) (encoders: roqvideo)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("roq")]
        roq,
        /// <summary>
        /// QuickTime video (RPZA)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rpza")]
        rpza,
        /// <summary>
        /// innoHeim/Rsupport Screen Capture Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rscc")]
        rscc,
        /// <summary>
        /// RTV1 (RivaTuner Video)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rtv1")]
        rtv1,
        /// <summary>
        /// RealVideo 1.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rv10")]
        rv10,
        /// <summary>
        /// RealVideo 2.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rv20")]
        rv20,
        /// <summary>
        /// RealVideo 3.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rv30")]
        rv30,
        /// <summary>
        /// RealVideo 4.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rv40")]
        rv40,
        /// <summary>
        /// RealVideo 6.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rv60")]
        rv60,
        /// <summary>
        /// LucasArts SANM/SMUSH video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sanm")]
        sanm,
        /// <summary>
        /// ScreenPressor
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.LS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("scpr")]
        scpr,
        /// <summary>
        /// Screenpresso
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("screenpresso")]
        screenpresso,
        /// <summary>
        /// Digital Pictures SGA Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sga")]
        sga,
        /// <summary>
        /// SGI image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sgi")]
        sgi,
        /// <summary>
        /// SGI RLE 8-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sgirle")]
        sgirle,
        /// <summary>
        /// BitJazz SheerVideo
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sheervideo")]
        sheervideo,
        /// <summary>
        /// Simbiosis Interactive IMX Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("simbiosis_imx")]
        simbiosis_imx,
        /// <summary>
        /// Smacker video (decoders: smackvid)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("smackvideo")]
        smackvideo,
        /// <summary>
        /// QuickTime Graphics (SMC)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("smc")]
        smc,
        /// <summary>
        /// Sigmatel Motion Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("smvjpeg")]
        smvjpeg,
        /// <summary>
        /// Snow
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.LS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("snow")]
        snow,
        /// <summary>
        /// Sunplus JPEG (SP5X)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sp5x")]
        sp5x,
        /// <summary>
        /// NewTek SpeedHQ
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("speedhq")]
        speedhq,
        /// <summary>
        /// Screen Recorder Gold Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("srgc")]
        srgc,
        /// <summary>
        /// Sun Rasterfile image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sunrast")]
        sunrast,
        /// <summary>
        /// Scalable Vector Graphics
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("svg")]
        svg,
        /// <summary>
        /// Sorenson Vector Quantizer 1 / Sorenson Video 1 / SVQ1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("svq1")]
        svq1,
        /// <summary>
        /// Sorenson Vector Quantizer 3 / Sorenson Video 3 / SVQ3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("svq3")]
        svq3,
        /// <summary>
        /// Truevision Targa image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("targa")]
        targa,
        /// <summary>
        /// Pinnacle TARGA CineWave YUV16
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("targa_y216")]
        targa_y216,
        /// <summary>
        /// TDSC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tdsc")]
        tdsc,
        /// <summary>
        /// Electronic Arts TGQ video (decoders: eatgq)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tgq")]
        tgq,
        /// <summary>
        /// Electronic Arts TGV video (decoders: eatgv)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tgv")]
        tgv,
        /// <summary>
        /// Theora (encoders: libtheora)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("theora")]
        theora,
        /// <summary>
        /// Nintendo Gamecube THP video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("thp")]
        thp,
        /// <summary>
        /// Tiertex Limited SEQ video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tiertexseqvideo")]
        tiertexseqvideo,
        /// <summary>
        /// TIFF image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tiff")]
        tiff,
        /// <summary>
        /// 8088flex TMV
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tmv")]
        tmv,
        /// <summary>
        /// Electronic Arts TQI video (decoders: eatqi)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tqi")]
        tqi,
        /// <summary>
        /// Duck TrueMotion 1.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("truemotion1")]
        truemotion1,
        /// <summary>
        /// Duck TrueMotion 2.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("truemotion2")]
        truemotion2,
        /// <summary>
        /// Duck TrueMotion 2.0 Real Time
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("truemotion2rt")]
        truemotion2rt,
        /// <summary>
        /// TechSmith Screen Capture Codec (decoders: camtasia)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tscc")]
        tscc,
        /// <summary>
        /// TechSmith Screen Codec 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tscc2")]
        tscc2,
        /// <summary>
        /// Renderware TXD (TeXture Dictionary) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("txd")]
        txd,
        /// <summary>
        /// IBM UltiMotion (decoders: ultimotion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ulti")]
        ulti,
        /// <summary>
        /// Ut Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("utvideo")]
        utvideo,
        /// <summary>
        /// Uncompressed 4:2:2 10-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("v210")]
        v210,
        /// <summary>
        /// Uncompressed 4:2:2 10-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("v210x")]
        v210x,
        /// <summary>
        /// Uncompressed packed 4:4:4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("v308")]
        v308,
        /// <summary>
        /// Uncompressed packed QT 4:4:4:4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("v408")]
        v408,
        /// <summary>
        /// Uncompressed 4:4:4 10-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("v410")]
        v410,
        /// <summary>
        /// Beam Software VB
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vb")]
        vb,
        /// <summary>
        /// VBLE Lossless Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vble")]
        vble,
        /// <summary>
        /// Vizrt Binary Image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vbn")]
        vbn,
        /// <summary>
        /// SMPTE VC-1 (decoders: vc1 vc1_qsv vc1_cuvid)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vc1")]
        vc1,
        /// <summary>
        /// Windows Media Video 9 Image v2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vc1image")]
        vc1image,
        /// <summary>
        /// ATI VCR1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vcr1")]
        vcr1,
        /// <summary>
        /// Miro VideoXL (decoders: xl)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vixl")]
        vixl,
        /// <summary>
        /// Sierra VMD video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vmdvideo")]
        vmdvideo,
        /// <summary>
        /// vMix Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vmix")]
        vmix,
        /// <summary>
        /// VMware Screen Codec / VMware Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vmnc")]
        vmnc,
        /// <summary>
        /// Null video codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vnull")]
        vnull,
        /// <summary>
        /// On2 VP3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp3")]
        vp3,
        /// <summary>
        /// On2 VP4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp4")]
        vp4,
        /// <summary>
        /// On2 VP5
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp5")]
        vp5,
        /// <summary>
        /// On2 VP6
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp6")]
        vp6,
        /// <summary>
        /// On2 VP6 (Flash version, with alpha channel)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp6a")]
        vp6a,
        /// <summary>
        /// On2 VP6 (Flash version)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp6f")]
        vp6f,
        /// <summary>
        /// On2 VP7
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp7")]
        vp7,
        /// <summary>
        /// On2 VP8 (decoders: vp8 libvpx vp8_cuvid vp8_qsv) (encoders: libvpx vp8_vaapi)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp8")]
        vp8,
        /// <summary>
        /// Google VP9 (decoders: vp9 libvpx-vp9 vp9_amf vp9_cuvid vp9_qsv) (encoders: libvpx-vp9 vp9_vaapi vp9_qsv)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vp9")]
        vp9,
        /// <summary>
        /// ViewQuest VQC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vqc")]
        vqc,
        /// <summary>
        /// H.266 / VVC (Versatile Video Coding) (decoders: vvc vvc_qsv) (encoders: libvvenc)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vvc")]
        vvc,
        /// <summary>
        /// WBMP (Wireless Application Protocol Bitmap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wbmp")]
        wbmp,
        /// <summary>
        /// WinCAM Motion Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wcmv")]
        wcmv,
        /// <summary>
        /// WebP (encoders: libwebp_anim libwebp)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("webp")]
        webp,
        /// <summary>
        /// Windows Media Video 7
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmv1")]
        wmv1,
        /// <summary>
        /// Windows Media Video 8
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmv2")]
        wmv2,
        /// <summary>
        /// Windows Media Video 9
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmv3")]
        wmv3,
        /// <summary>
        /// Windows Media Video 9 Image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmv3image")]
        wmv3image,
        /// <summary>
        /// Winnov WNV1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wnv1")]
        wnv1,
        /// <summary>
        /// AVFrame to AVPacket passthrough
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wrapped_avframe")]
        wrapped_avframe,
        /// <summary>
        /// Westwood Studios VQA (Vector Quantized Animation) video (decoders: vqavideo)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ws_vqa")]
        ws_vqa,
        /// <summary>
        /// Wing Commander III / Xan
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xan_wc3")]
        xan_wc3,
        /// <summary>
        /// Wing Commander IV / Xxan
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xan_wc4")]
        xan_wc4,
        /// <summary>
        /// eXtended BINary text
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI..")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xbin")]
        xbin,
        /// <summary>
        /// XBM (X BitMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xbm")]
        xbm,
        /// <summary>
        /// X-face image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xface")]
        xface,
        /// <summary>
        /// XPM (X PixMap) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xpm")]
        xpm,
        /// <summary>
        /// XWD (X Window Dump) image
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xwd")]
        xwd,
        /// <summary>
        /// Uncompressed YUV 4:1:1 12-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("y41p")]
        y41p,
        /// <summary>
        /// YUY2 Lossless Codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.VI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ylc")]
        ylc,
        /// <summary>
        /// Psygnosis YOP Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("yop")]
        yop,
        /// <summary>
        /// Uncompressed packed 4:2:0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv4")]
        yuv4,
        /// <summary>
        /// ZeroCodec Lossless Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.V..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("zerocodec")]
        zerocodec,
        /// <summary>
        /// LCL (LossLess Codec Library) ZLIB
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEVI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("zlib")]
        zlib,
        /// <summary>
        /// Zip Motion Blocks Video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEV..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("zmbv")]
        zmbv,
        /// <summary>
        /// 4GV (Fourth Generation Vocoder)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("4gv")]
        _4gv,
        /// <summary>
        /// 8SVX exponential
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("8svx_exp")]
        _8svx_exp,
        /// <summary>
        /// 8SVX fibonacci
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("8svx_fib")]
        _8svx_fib,
        /// <summary>
        /// AAC (Advanced Audio Coding) (decoders: aac aac_fixed) (encoders: aac aac_mf)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEA.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aac")]
        aac,
        /// <summary>
        /// AAC LATM (Advanced Audio Coding LATM syntax)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.A.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aac_latm")]
        aac_latm,
        /// <summary>
        /// ATSC A/52A (AC-3) (decoders: ac3 ac3_fixed) (encoders: ac3 ac3_fixed ac3_mf)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ac3")]
        ac3,
        /// <summary>
        /// AC-4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..A.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ac4")]
        ac4,
        /// <summary>
        /// Sipro ACELP.KELVIN
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("acelp.kelvin")]
        acelpDotkelvin,
        /// <summary>
        /// ADPCM 4X Movie
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_4xm")]
        adpcm_4xm,
        /// <summary>
        /// SEGA CRI ADX ADPCM
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_adx")]
        adpcm_adx,
        /// <summary>
        /// ADPCM Nintendo Gamecube AFC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_afc")]
        adpcm_afc,
        /// <summary>
        /// ADPCM AmuseGraphics Movie AGM
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_agm")]
        adpcm_agm,
        /// <summary>
        /// ADPCM Yamaha AICA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_aica")]
        adpcm_aica,
        /// <summary>
        /// ADPCM Argonaut Games
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_argo")]
        adpcm_argo,
        /// <summary>
        /// ADPCM Creative Technology
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ct")]
        adpcm_ct,
        /// <summary>
        /// ADPCM Nintendo Gamecube DTK
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_dtk")]
        adpcm_dtk,
        /// <summary>
        /// ADPCM Electronic Arts
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ea")]
        adpcm_ea,
        /// <summary>
        /// ADPCM Electronic Arts Maxis CDROM XA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ea_maxis_xa")]
        adpcm_ea_maxis_xa,
        /// <summary>
        /// ADPCM Electronic Arts R1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ea_r1")]
        adpcm_ea_r1,
        /// <summary>
        /// ADPCM Electronic Arts R2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ea_r2")]
        adpcm_ea_r2,
        /// <summary>
        /// ADPCM Electronic Arts R3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ea_r3")]
        adpcm_ea_r3,
        /// <summary>
        /// ADPCM Electronic Arts XAS
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ea_xas")]
        adpcm_ea_xas,
        /// <summary>
        /// G.722 ADPCM (decoders: g722) (encoders: g722)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_g722")]
        adpcm_g722,
        /// <summary>
        /// G.726 ADPCM (decoders: g726) (encoders: g726)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_g726")]
        adpcm_g726,
        /// <summary>
        /// G.726 ADPCM little-endian (decoders: g726le) (encoders: g726le)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_g726le")]
        adpcm_g726le,
        /// <summary>
        /// ADPCM IMA Acorn Replay
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_acorn")]
        adpcm_ima_acorn,
        /// <summary>
        /// ADPCM IMA High Voltage Software ALP
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_alp")]
        adpcm_ima_alp,
        /// <summary>
        /// ADPCM IMA AMV
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_amv")]
        adpcm_ima_amv,
        /// <summary>
        /// ADPCM IMA CRYO APC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_apc")]
        adpcm_ima_apc,
        /// <summary>
        /// ADPCM IMA Ubisoft APM
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_apm")]
        adpcm_ima_apm,
        /// <summary>
        /// ADPCM IMA Cunning Developments
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_cunning")]
        adpcm_ima_cunning,
        /// <summary>
        /// ADPCM IMA Eurocom DAT4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_dat4")]
        adpcm_ima_dat4,
        /// <summary>
        /// ADPCM IMA Duck DK3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_dk3")]
        adpcm_ima_dk3,
        /// <summary>
        /// ADPCM IMA Duck DK4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_dk4")]
        adpcm_ima_dk4,
        /// <summary>
        /// ADPCM IMA Electronic Arts EACS
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_ea_eacs")]
        adpcm_ima_ea_eacs,
        /// <summary>
        /// ADPCM IMA Electronic Arts SEAD
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_ea_sead")]
        adpcm_ima_ea_sead,
        /// <summary>
        /// ADPCM IMA Funcom ISS
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_iss")]
        adpcm_ima_iss,
        /// <summary>
        /// ADPCM IMA MobiClip MOFLEX
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_moflex")]
        adpcm_ima_moflex,
        /// <summary>
        /// ADPCM IMA Capcom&apos;s MT Framework
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_mtf")]
        adpcm_ima_mtf,
        /// <summary>
        /// ADPCM IMA Dialogic OKI
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_oki")]
        adpcm_ima_oki,
        /// <summary>
        /// ADPCM IMA QuickTime
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_qt")]
        adpcm_ima_qt,
        /// <summary>
        /// ADPCM IMA Radical
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_rad")]
        adpcm_ima_rad,
        /// <summary>
        /// ADPCM IMA Loki SDL MJPEG
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_smjpeg")]
        adpcm_ima_smjpeg,
        /// <summary>
        /// ADPCM IMA Simon &amp; Schuster Interactive
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_ssi")]
        adpcm_ima_ssi,
        /// <summary>
        /// ADPCM IMA WAV
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_wav")]
        adpcm_ima_wav,
        /// <summary>
        /// ADPCM IMA Westwood
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_ws")]
        adpcm_ima_ws,
        /// <summary>
        /// ADPCM IMA Xbox
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ima_xbox")]
        adpcm_ima_xbox,
        /// <summary>
        /// ADPCM Microsoft
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_ms")]
        adpcm_ms,
        /// <summary>
        /// ADPCM MTAF
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_mtaf")]
        adpcm_mtaf,
        /// <summary>
        /// ADPCM Playstation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_psx")]
        adpcm_psx,
        /// <summary>
        /// ADPCM Sanyo
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_sanyo")]
        adpcm_sanyo,
        /// <summary>
        /// ADPCM Sound Blaster Pro 2-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_sbpro_2")]
        adpcm_sbpro_2,
        /// <summary>
        /// ADPCM Sound Blaster Pro 2.6-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_sbpro_3")]
        adpcm_sbpro_3,
        /// <summary>
        /// ADPCM Sound Blaster Pro 4-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_sbpro_4")]
        adpcm_sbpro_4,
        /// <summary>
        /// ADPCM Shockwave Flash
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_swf")]
        adpcm_swf,
        /// <summary>
        /// ADPCM Nintendo THP
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_thp")]
        adpcm_thp,
        /// <summary>
        /// ADPCM Nintendo THP (Little-Endian)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_thp_le")]
        adpcm_thp_le,
        /// <summary>
        /// LucasArts VIMA audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_vima")]
        adpcm_vima,
        /// <summary>
        /// ADPCM CDROM XA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_xa")]
        adpcm_xa,
        /// <summary>
        /// ADPCM Konami XMD
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_xmd")]
        adpcm_xmd,
        /// <summary>
        /// ADPCM Yamaha
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_yamaha")]
        adpcm_yamaha,
        /// <summary>
        /// ADPCM Zork
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("adpcm_zork")]
        adpcm_zork,
        /// <summary>
        /// ALAC (Apple Lossless Audio Codec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("alac")]
        alac,
        /// <summary>
        /// AMR-NB (Adaptive Multi-Rate NarrowBand) (decoders: amrnb libopencore_amrnb) (encoders: libopencore_amrnb)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("amr_nb")]
        amr_nb,
        /// <summary>
        /// AMR-WB (Adaptive Multi-Rate WideBand) (decoders: amrwb libopencore_amrwb)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("amr_wb")]
        amr_wb,
        /// <summary>
        /// Null audio codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEA...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("anull")]
        anull,
        /// <summary>
        /// Marian&apos;s A-pac audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("apac")]
        apac,
        /// <summary>
        /// Monkey&apos;s Audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ape")]
        ape,
        /// <summary>
        /// aptX (Audio Processing Technology for Bluetooth)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aptx")]
        aptx,
        /// <summary>
        /// aptX HD (Audio Processing Technology for Bluetooth)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("aptx_hd")]
        aptx_hd,
        /// <summary>
        /// ATRAC1 (Adaptive TRansform Acoustic Coding)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("atrac1")]
        atrac1,
        /// <summary>
        /// ATRAC3 (Adaptive TRansform Acoustic Coding 3)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("atrac3")]
        atrac3,
        /// <summary>
        /// ATRAC3 AL (Adaptive TRansform Acoustic Coding 3 Advanced Lossless)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("atrac3al")]
        atrac3al,
        /// <summary>
        /// ATRAC3+ (Adaptive TRansform Acoustic Coding 3+) (decoders: atrac3plus)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("atrac3p")]
        atrac3p,
        /// <summary>
        /// ATRAC3+ AL (Adaptive TRansform Acoustic Coding 3+ Advanced Lossless) (decoders: atrac3plusal)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("atrac3pal")]
        atrac3pal,
        /// <summary>
        /// ATRAC9 (Adaptive TRansform Acoustic Coding 9)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("atrac9")]
        atrac9,
        /// <summary>
        /// On2 Audio for Video Codec (decoders: on2avc)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("avc")]
        avc,
        /// <summary>
        /// Bink Audio (DCT)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("binkaudio_dct")]
        binkaudio_dct,
        /// <summary>
        /// Bink Audio (RDFT)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("binkaudio_rdft")]
        binkaudio_rdft,
        /// <summary>
        /// Discworld II BMV audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bmv_audio")]
        bmv_audio,
        /// <summary>
        /// Bonk audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bonk")]
        bonk,
        /// <summary>
        /// DPCM Cuberoot-Delta-Exact
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbd2_dpcm")]
        cbd2_dpcm,
        /// <summary>
        /// Constrained Energy Lapped Transform (CELT)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("celt")]
        celt,
        /// <summary>
        /// codec2 (very low bitrate speech codec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("codec2")]
        codec2,
        /// <summary>
        /// RFC 3389 Comfort Noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("comfortnoise")]
        comfortnoise,
        /// <summary>
        /// Cook / Cooker / Gecko (RealAudio G2)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("cook")]
        cook,
        /// <summary>
        /// DPCM Xilam DERF
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("derf_dpcm")]
        derf_dpcm,
        /// <summary>
        /// DFPWM (Dynamic Filter Pulse Width Modulation)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEA.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dfpwm")]
        dfpwm,
        /// <summary>
        /// Dolby E
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dolby_e")]
        dolby_e,
        /// <summary>
        /// DSD (Direct Stream Digital), least significant bit first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dsd_lsbf")]
        dsd_lsbf,
        /// <summary>
        /// DSD (Direct Stream Digital), least significant bit first, planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dsd_lsbf_planar")]
        dsd_lsbf_planar,
        /// <summary>
        /// DSD (Direct Stream Digital), most significant bit first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dsd_msbf")]
        dsd_msbf,
        /// <summary>
        /// DSD (Direct Stream Digital), most significant bit first, planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dsd_msbf_planar")]
        dsd_msbf_planar,
        /// <summary>
        /// Delphine Software International CIN audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dsicinaudio")]
        dsicinaudio,
        /// <summary>
        /// Digital Speech Standard - Standard Play mode (DSS SP)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dss_sp")]
        dss_sp,
        /// <summary>
        /// DST (Direct Stream Transfer)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dst")]
        dst,
        /// <summary>
        /// DCA (DTS Coherent Acoustics) (decoders: dca) (encoders: dca)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dts")]
        dts,
        /// <summary>
        /// DV audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dvaudio")]
        dvaudio,
        /// <summary>
        /// ATSC A/52B (AC-3, E-AC-3)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("eac3")]
        eac3,
        /// <summary>
        /// EVRC (Enhanced Variable Rate Codec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("evrc")]
        evrc,
        /// <summary>
        /// MobiClip FastAudio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("fastaudio")]
        fastaudio,
        /// <summary>
        /// FLAC (Free Lossless Audio Codec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("flac")]
        flac,
        /// <summary>
        /// FTR Voice
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ftr")]
        ftr,
        /// <summary>
        /// G.723.1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("g723_1")]
        g723_1,
        /// <summary>
        /// G.728
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("g728")]
        g728,
        /// <summary>
        /// G.729
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("g729")]
        g729,
        /// <summary>
        /// DPCM Gremlin
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("gremlin_dpcm")]
        gremlin_dpcm,
        /// <summary>
        /// GSM
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("gsm")]
        gsm,
        /// <summary>
        /// GSM Microsoft variant
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("gsm_ms")]
        gsm_ms,
        /// <summary>
        /// CRI HCA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hca")]
        hca,
        /// <summary>
        /// HCOM Audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hcom")]
        hcom,
        /// <summary>
        /// IAC (Indeo Audio Coder)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("iac")]
        iac,
        /// <summary>
        /// iLBC (Internet Low Bitrate Codec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ilbc")]
        ilbc,
        /// <summary>
        /// IMC (Intel Music Coder)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("imc")]
        imc,
        /// <summary>
        /// DPCM Interplay
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("interplay_dpcm")]
        interplay_dpcm,
        /// <summary>
        /// Interplay ACM
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("interplayacm")]
        interplayacm,
        /// <summary>
        /// LC3 (Low Complexity Communication Codec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("lc3")]
        lc3,
        /// <summary>
        /// MACE (Macintosh Audio Compression/Expansion) 3:1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mace3")]
        mace3,
        /// <summary>
        /// MACE (Macintosh Audio Compression/Expansion) 6:1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mace6")]
        mace6,
        /// <summary>
        /// Voxware MetaSound
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("metasound")]
        metasound,
        /// <summary>
        /// Micronas SC-4 Audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("misc4")]
        misc4,
        /// <summary>
        /// MLP (Meridian Lossless Packing)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEA..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mlp")]
        mlp,
        /// <summary>
        /// MP1 (MPEG audio layer 1) (decoders: mp1 mp1float)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mp1")]
        mp1,
        /// <summary>
        /// MP2 (MPEG audio layer 2) (decoders: mp2 mp2float) (encoders: mp2 mp2fixed libtwolame)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mp2")]
        mp2,
        /// <summary>
        /// MP3 (MPEG audio layer 3) (decoders: mp3float mp3) (encoders: libmp3lame mp3_mf)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mp3")]
        mp3,
        /// <summary>
        /// ADU (Application Data Unit) MP3 (MPEG audio layer 3) (decoders: mp3adufloat mp3adu)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mp3adu")]
        mp3adu,
        /// <summary>
        /// MP3onMP4 (decoders: mp3on4float mp3on4)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mp3on4")]
        mp3on4,
        /// <summary>
        /// MPEG-4 Audio Lossless Coding (ALS) (decoders: als)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mp4als")]
        mp4als,
        /// <summary>
        /// MPEG-H 3D Audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..A.L.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpegh_3d_audio")]
        mpegh_3d_audio,
        /// <summary>
        /// MSN Siren
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("msnsiren")]
        msnsiren,
        /// <summary>
        /// Musepack SV7 (decoders: mpc7)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("musepack7")]
        musepack7,
        /// <summary>
        /// Musepack SV8 (decoders: mpc8)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("musepack8")]
        musepack8,
        /// <summary>
        /// Nellymoser Asao
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("nellymoser")]
        nellymoser,
        /// <summary>
        /// Opus (Opus Interactive Audio Codec) (decoders: opus libopus) (encoders: opus libopus)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("opus")]
        opus,
        /// <summary>
        /// OSQ (Original Sound Quality)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("osq")]
        osq,
        /// <summary>
        /// Amazing Studio Packed Animation File Audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("paf_audio")]
        paf_audio,
        /// <summary>
        /// PCM A-law / G.711 A-law
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_alaw")]
        pcm_alaw,
        /// <summary>
        /// PCM signed 16|20|24-bit big-endian for Blu-ray media
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_bluray")]
        pcm_bluray,
        /// <summary>
        /// PCM signed 20|24-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_dvd")]
        pcm_dvd,
        /// <summary>
        /// PCM 16.8 floating point little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_f16le")]
        pcm_f16le,
        /// <summary>
        /// PCM 24.0 floating point little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_f24le")]
        pcm_f24le,
        /// <summary>
        /// PCM 32-bit floating point big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_f32be")]
        pcm_f32be,
        /// <summary>
        /// PCM 32-bit floating point little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_f32le")]
        pcm_f32le,
        /// <summary>
        /// PCM 64-bit floating point big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_f64be")]
        pcm_f64be,
        /// <summary>
        /// PCM 64-bit floating point little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_f64le")]
        pcm_f64le,
        /// <summary>
        /// PCM signed 20-bit little-endian planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_lxf")]
        pcm_lxf,
        /// <summary>
        /// PCM mu-law / G.711 mu-law
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_mulaw")]
        pcm_mulaw,
        /// <summary>
        /// PCM signed 16-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s16be")]
        pcm_s16be,
        /// <summary>
        /// PCM signed 16-bit big-endian planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s16be_planar")]
        pcm_s16be_planar,
        /// <summary>
        /// PCM signed 16-bit little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s16le")]
        pcm_s16le,
        /// <summary>
        /// PCM signed 16-bit little-endian planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s16le_planar")]
        pcm_s16le_planar,
        /// <summary>
        /// PCM signed 24-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s24be")]
        pcm_s24be,
        /// <summary>
        /// PCM D-Cinema audio signed 24-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s24daud")]
        pcm_s24daud,
        /// <summary>
        /// PCM signed 24-bit little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s24le")]
        pcm_s24le,
        /// <summary>
        /// PCM signed 24-bit little-endian planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s24le_planar")]
        pcm_s24le_planar,
        /// <summary>
        /// PCM signed 32-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s32be")]
        pcm_s32be,
        /// <summary>
        /// PCM signed 32-bit little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s32le")]
        pcm_s32le,
        /// <summary>
        /// PCM signed 32-bit little-endian planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s32le_planar")]
        pcm_s32le_planar,
        /// <summary>
        /// PCM signed 64-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s64be")]
        pcm_s64be,
        /// <summary>
        /// PCM signed 64-bit little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s64le")]
        pcm_s64le,
        /// <summary>
        /// PCM signed 8-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s8")]
        pcm_s8,
        /// <summary>
        /// PCM signed 8-bit planar
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_s8_planar")]
        pcm_s8_planar,
        /// <summary>
        /// PCM SGA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_sga")]
        pcm_sga,
        /// <summary>
        /// PCM unsigned 16-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_u16be")]
        pcm_u16be,
        /// <summary>
        /// PCM unsigned 16-bit little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_u16le")]
        pcm_u16le,
        /// <summary>
        /// PCM unsigned 24-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_u24be")]
        pcm_u24be,
        /// <summary>
        /// PCM unsigned 24-bit little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_u24le")]
        pcm_u24le,
        /// <summary>
        /// PCM unsigned 32-bit big-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_u32be")]
        pcm_u32be,
        /// <summary>
        /// PCM unsigned 32-bit little-endian
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_u32le")]
        pcm_u32le,
        /// <summary>
        /// PCM unsigned 8-bit
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_u8")]
        pcm_u8,
        /// <summary>
        /// PCM Archimedes VIDC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcm_vidc")]
        pcm_vidc,
        /// <summary>
        /// QCELP / PureVoice
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qcelp")]
        qcelp,
        /// <summary>
        /// QDesign Music Codec 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qdm2")]
        qdm2,
        /// <summary>
        /// QDesign Music
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qdmc")]
        qdmc,
        /// <summary>
        /// QOA (Quite OK Audio)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("qoa")]
        qoa,
        /// <summary>
        /// RealAudio 1.0 (14.4K) (decoders: real_144) (encoders: real_144)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ra_144")]
        ra_144,
        /// <summary>
        /// RealAudio 2.0 (28.8K) (decoders: real_288)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ra_288")]
        ra_288,
        /// <summary>
        /// RealAudio Lossless
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ralf")]
        ralf,
        /// <summary>
        /// RKA (RK Audio)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("rka")]
        rka,
        /// <summary>
        /// DPCM id RoQ
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("roq_dpcm")]
        roq_dpcm,
        /// <summary>
        /// SMPTE 302M
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("s302m")]
        s302m,
        /// <summary>
        /// SBC (low-complexity subband codec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbc")]
        sbc,
        /// <summary>
        /// DPCM Squareroot-Delta-Exact
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sdx2_dpcm")]
        sdx2_dpcm,
        /// <summary>
        /// Shorten
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("shorten")]
        shorten,
        /// <summary>
        /// RealAudio SIPR / ACELP.NET
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sipr")]
        sipr,
        /// <summary>
        /// Siren
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("siren")]
        siren,
        /// <summary>
        /// Smacker audio (decoders: smackaud)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("smackaudio")]
        smackaudio,
        /// <summary>
        /// SMV (Selectable Mode Vocoder)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("smv")]
        smv,
        /// <summary>
        /// DPCM Sol
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sol_dpcm")]
        sol_dpcm,
        /// <summary>
        /// Sonic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI..")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sonic")]
        sonic,
        /// <summary>
        /// Sonic lossless
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..AI..")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sonicls")]
        sonicls,
        /// <summary>
        /// Speex
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("speex")]
        speex,
        /// <summary>
        /// TAK (Tom&apos;s lossless Audio Kompressor)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.A..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tak")]
        tak,
        /// <summary>
        /// TrueHD
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEA..S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("truehd")]
        truehd,
        /// <summary>
        /// DSP Group TrueSpeech
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("truespeech")]
        truespeech,
        /// <summary>
        /// TTA (True Audio)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("tta")]
        tta,
        /// <summary>
        /// VQF TwinVQ
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("twinvq")]
        twinvq,
        /// <summary>
        /// Sierra VMD audio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vmdaudio")]
        vmdaudio,
        /// <summary>
        /// Vorbis (decoders: vorbis libvorbis) (encoders: vorbis libvorbis)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vorbis")]
        vorbis,
        /// <summary>
        /// DPCM Marble WADY
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wady_dpcm")]
        wady_dpcm,
        /// <summary>
        /// Waveform Archiver
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wavarc")]
        wavarc,
        /// <summary>
        /// Wave synthesis pseudo-codec
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI..")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wavesynth")]
        wavesynth,
        /// <summary>
        /// WavPack
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAILS")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wavpack")]
        wavpack,
        /// <summary>
        /// Westwood Audio (SND1) (decoders: ws_snd1)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("westwood_snd1")]
        westwood_snd1,
        /// <summary>
        /// Windows Media Audio Lossless
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AI.S")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmalossless")]
        wmalossless,
        /// <summary>
        /// Windows Media Audio 9 Professional
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmapro")]
        wmapro,
        /// <summary>
        /// Windows Media Audio 1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmav1")]
        wmav1,
        /// <summary>
        /// Windows Media Audio 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DEAIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmav2")]
        wmav2,
        /// <summary>
        /// Windows Media Audio Voice
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("wmavoice")]
        wmavoice,
        /// <summary>
        /// DPCM Xan
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xan_dpcm")]
        xan_dpcm,
        /// <summary>
        /// Xbox Media Audio 1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xma1")]
        xma1,
        /// <summary>
        /// Xbox Media Audio 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.AIL.")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xma2")]
        xma2,
        /// <summary>
        /// binary data
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("bin_data")]
        bin_data,
        /// <summary>
        /// DVD Nav packet
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dvd_nav_packet")]
        dvd_nav_packet,
        /// <summary>
        /// Electronic Program Guide
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("epg")]
        epg,
        /// <summary>
        /// SMPTE 336M Key-Length-Value (KLV) metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("klv")]
        klv,
        /// <summary>
        /// LCEVC (Low Complexity Enhancement Video Coding) / MPEG-5 LCEVC / MPEG-5 part 2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("lcevc")]
        lcevc,
        /// <summary>
        /// raw MPEG-TS stream
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpegts")]
        mpegts,
        /// <summary>
        /// OpenType font
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("otf")]
        otf,
        /// <summary>
        /// SCTE 35 Message Queue
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("scte_35")]
        scte_35,
        /// <summary>
        /// SMPTE ST 2038 VANC in MPEG-2 TS
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte_2038")]
        smpte_2038,
        /// <summary>
        /// MXF SMPTE-436M ANC
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte_436m_anc")]
        smpte_436m_anc,
        /// <summary>
        /// timed ID3 metadata
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("timed_id3")]
        timed_id3,
        /// <summary>
        /// TrueType font
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..D...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ttf")]
        ttf,
        /// <summary>
        /// ARIB STD-B24 caption (decoders: libaribcaption libaribb24)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("arib_caption")]
        arib_caption,
        /// <summary>
        /// ASS (Advanced SSA) subtitle (decoders: ssa ass) (encoders: ssa ass)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ass")]
        ass,
        /// <summary>
        /// DVB subtitles (decoders: dvbsub) (encoders: dvbsub)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dvb_subtitle")]
        dvb_subtitle,
        /// <summary>
        /// DVB teletext (decoders: libzvbi_teletextdec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dvb_teletext")]
        dvb_teletext,
        /// <summary>
        /// DVD subtitles (decoders: dvdsub) (encoders: dvdsub)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("dvd_subtitle")]
        dvd_subtitle,
        /// <summary>
        /// EIA-608 closed captions (decoders: cc_dec)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("eia_608")]
        eia_608,
        /// <summary>
        /// HDMV Presentation Graphic Stream subtitles (decoders: pgssub)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hdmv_pgs_subtitle")]
        hdmv_pgs_subtitle,
        /// <summary>
        /// HDMV Text subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("hdmv_text_subtitle")]
        hdmv_text_subtitle,
        /// <summary>
        /// ivtv VBI captions
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ivtv_vbi")]
        ivtv_vbi,
        /// <summary>
        /// JACOsub subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("jacosub")]
        jacosub,
        /// <summary>
        /// MicroDVD subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("microdvd")]
        microdvd,
        /// <summary>
        /// MOV text
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mov_text")]
        mov_text,
        /// <summary>
        /// MPL2 subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpl2")]
        mpl2,
        /// <summary>
        /// PJS (Phoenix Japanimation Society) subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("pjs")]
        pjs,
        /// <summary>
        /// RealText subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("realtext")]
        realtext,
        /// <summary>
        /// SAMI subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("sami")]
        sami,
        /// <summary>
        /// SubRip subtitle with embedded timing
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("srt")]
        srt,
        /// <summary>
        /// SSA (SubStation Alpha) subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("..S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ssa")]
        ssa,
        /// <summary>
        /// Spruce subtitle format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("stl")]
        stl,
        /// <summary>
        /// SubRip subtitle (decoders: srt subrip) (encoders: srt subrip)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("subrip")]
        subrip,
        /// <summary>
        /// SubViewer subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("subviewer")]
        subviewer,
        /// <summary>
        /// SubViewer v1 subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("subviewer1")]
        subviewer1,
        /// <summary>
        /// raw UTF-8 text
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("text")]
        text,
        /// <summary>
        /// Timed Text Markup Language
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute(".ES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("ttml")]
        ttml,
        /// <summary>
        /// VPlayer subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("D.S...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("vplayer")]
        vplayer,
        /// <summary>
        /// WebVTT subtitle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("webvtt")]
        webvtt,
        /// <summary>
        /// XSUB
        /// </summary>
        [FFmpegArgs.Cores.Attributes.CodecFlagAttribute("DES...")]
        [FFmpegArgs.Cores.Attributes.NameAttribute("xsub")]
        xsub
    }
}