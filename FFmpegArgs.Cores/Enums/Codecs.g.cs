namespace FFmpegArgs.Cores.Enums
{
/// <summary>
/// </summary>
public enum Codecs
{
/// <summary>
/// Uncompressed 4:2:2 10-bit
/// </summary>
[CodecFlag("D.VI.S")][Name("012v")]_012v,

/// <summary>
/// 4X Movie
/// </summary>
[CodecFlag("D.V.L.")][Name("4xm")]_4xm,

/// <summary>
/// QuickTime 8BPS video
/// </summary>
[CodecFlag("D.VI.S")][Name("8bps")]_8bps,

/// <summary>
/// Multicolor charset for Commodore 64 (encoders: a64multi)
/// </summary>
[CodecFlag(".EVIL.")][Name("a64_multi")]a64_multi,

/// <summary>
/// Multicolor charset for Commodore 64, extended with 5th color (colram) (encoders: a64multi5)
/// </summary>
[CodecFlag(".EVIL.")][Name("a64_multi5")]a64_multi5,

/// <summary>
/// Autodesk RLE
/// </summary>
[CodecFlag("D.V..S")][Name("aasc")]aasc,

/// <summary>
/// Amuse Graphics Movie
/// </summary>
[CodecFlag("D.V.L.")][Name("agm")]agm,

/// <summary>
/// Apple Intermediate Codec
/// </summary>
[CodecFlag("D.VIL.")][Name("aic")]aic,

/// <summary>
/// Alias/Wavefront PIX image
/// </summary>
[CodecFlag("DEVI.S")][Name("alias_pix")]alias_pix,

/// <summary>
/// AMV Video
/// </summary>
[CodecFlag("DEVIL.")][Name("amv")]amv,

/// <summary>
/// Deluxe Paint Animation
/// </summary>
[CodecFlag("D.V.L.")][Name("anm")]anm,

/// <summary>
/// ASCII/ANSI art
/// </summary>
[CodecFlag("D.V.L.")][Name("ansi")]ansi,

/// <summary>
/// APNG (Animated Portable Network Graphics) image
/// </summary>
[CodecFlag("DEV..S")][Name("apng")]apng,

/// <summary>
/// Gryphon&#39;s Anim Compressor
/// </summary>
[CodecFlag("D.V.L.")][Name("arbc")]arbc,

/// <summary>
/// Argonaut Games Video
/// </summary>
[CodecFlag("D.V.L.")][Name("argo")]argo,

/// <summary>
/// ASUS V1
/// </summary>
[CodecFlag("DEVIL.")][Name("asv1")]asv1,

/// <summary>
/// ASUS V2
/// </summary>
[CodecFlag("DEVIL.")][Name("asv2")]asv2,

/// <summary>
/// Auravision AURA
/// </summary>
[CodecFlag("D.VIL.")][Name("aura")]aura,

/// <summary>
/// Auravision Aura 2
/// </summary>
[CodecFlag("D.VIL.")][Name("aura2")]aura2,

/// <summary>
/// Alliance for Open Media AV1 (decoders: libdav1d libaom-av1 av1 av1_cuvid av1_qsv) (encoders: libaom-av1 librav1e av1_nvenc av1_qsv av1_amf av1_vaapi)
/// </summary>
[CodecFlag("DEV.L.")][Name("av1")]av1,

/// <summary>
/// Avid AVI Codec
/// </summary>
[CodecFlag("D.V...")][Name("avrn")]avrn,

/// <summary>
/// Avid 1:1 10-bit RGB Packer
/// </summary>
[CodecFlag("DEVI.S")][Name("avrp")]avrp,

/// <summary>
/// AVS (Audio Video Standard) video
/// </summary>
[CodecFlag("D.V.L.")][Name("avs")]avs,

/// <summary>
/// AVS2-P2/IEEE1857.4 (decoders: libdavs2) (encoders: libxavs2)
/// </summary>
[CodecFlag("DEV.L.")][Name("avs2")]avs2,

/// <summary>
/// AVS3-P2/IEEE1857.10 (decoders: libuavs3d)
/// </summary>
[CodecFlag("D.V.L.")][Name("avs3")]avs3,

/// <summary>
/// Avid Meridien Uncompressed
/// </summary>
[CodecFlag("DEVI.S")][Name("avui")]avui,

/// <summary>
/// Bethesda VID video
/// </summary>
[CodecFlag("D.V.L.")][Name("bethsoftvid")]bethsoftvid,

/// <summary>
/// Brute Force &amp; Ignorance
/// </summary>
[CodecFlag("D.V.L.")][Name("bfi")]bfi,

/// <summary>
/// Bink video
/// </summary>
[CodecFlag("D.V.L.")][Name("binkvideo")]binkvideo,

/// <summary>
/// Binary text
/// </summary>
[CodecFlag("D.VI..")][Name("bintext")]bintext,

/// <summary>
/// Bitpacked
/// </summary>
[CodecFlag("DEVI.S")][Name("bitpacked")]bitpacked,

/// <summary>
/// BMP (Windows and OS/2 bitmap)
/// </summary>
[CodecFlag("DEVI.S")][Name("bmp")]bmp,

/// <summary>
/// Discworld II BMV video
/// </summary>
[CodecFlag("D.V..S")][Name("bmv_video")]bmv_video,

/// <summary>
/// BRender PIX image
/// </summary>
[CodecFlag("D.VI.S")][Name("brender_pix")]brender_pix,

/// <summary>
/// Interplay C93
/// </summary>
[CodecFlag("D.V.L.")][Name("c93")]c93,

/// <summary>
/// Chinese AVS (Audio Video Standard) (AVS1-P2, JiZhun profile)
/// </summary>
[CodecFlag("D.V.L.")][Name("cavs")]cavs,

/// <summary>
/// CD Graphics video
/// </summary>
[CodecFlag("D.V.L.")][Name("cdgraphics")]cdgraphics,

/// <summary>
/// CDToons video
/// </summary>
[CodecFlag("D.V..S")][Name("cdtoons")]cdtoons,

/// <summary>
/// Commodore CDXL video
/// </summary>
[CodecFlag("D.VIL.")][Name("cdxl")]cdxl,

/// <summary>
/// GoPro CineForm HD
/// </summary>
[CodecFlag("DEV.L.")][Name("cfhd")]cfhd,

/// <summary>
/// Cinepak
/// </summary>
[CodecFlag("DEV.L.")][Name("cinepak")]cinepak,

/// <summary>
/// Iterated Systems ClearVideo
/// </summary>
[CodecFlag("D.V.L.")][Name("clearvideo")]clearvideo,

/// <summary>
/// Cirrus Logic AccuPak
/// </summary>
[CodecFlag("DEVIL.")][Name("cljr")]cljr,

/// <summary>
/// Canopus Lossless Codec
/// </summary>
[CodecFlag("D.VI.S")][Name("cllc")]cllc,

/// <summary>
/// Electronic Arts CMV video (decoders: eacmv)
/// </summary>
[CodecFlag("D.V.L.")][Name("cmv")]cmv,

/// <summary>
/// CPiA video format
/// </summary>
[CodecFlag("D.V...")][Name("cpia")]cpia,

/// <summary>
/// Cintel RAW
/// </summary>
[CodecFlag("D.VILS")][Name("cri")]cri,

/// <summary>
/// CamStudio (decoders: camstudio)
/// </summary>
[CodecFlag("D.V..S")][Name("cscd")]cscd,

/// <summary>
/// Creative YUV (CYUV)
/// </summary>
[CodecFlag("D.VIL.")][Name("cyuv")]cyuv,

/// <summary>
/// Daala
/// </summary>
[CodecFlag("..V.LS")][Name("daala")]daala,

/// <summary>
/// DirectDraw Surface image decoder
/// </summary>
[CodecFlag("D.VILS")][Name("dds")]dds,

/// <summary>
/// Chronomaster DFA
/// </summary>
[CodecFlag("D.V.L.")][Name("dfa")]dfa,

/// <summary>
/// Dirac (encoders: vc2)
/// </summary>
[CodecFlag("DEV.LS")][Name("dirac")]dirac,

/// <summary>
/// VC3/DNxHD
/// </summary>
[CodecFlag("DEVIL.")][Name("dnxhd")]dnxhd,

/// <summary>
/// DPX (Digital Picture Exchange) image
/// </summary>
[CodecFlag("DEVI.S")][Name("dpx")]dpx,

/// <summary>
/// Delphine Software International CIN video
/// </summary>
[CodecFlag("D.V.L.")][Name("dsicinvideo")]dsicinvideo,

/// <summary>
/// DV (Digital Video)
/// </summary>
[CodecFlag("DEVIL.")][Name("dvvideo")]dvvideo,

/// <summary>
/// Feeble Files/ScummVM DXA
/// </summary>
[CodecFlag("D.V..S")][Name("dxa")]dxa,

/// <summary>
/// Dxtory
/// </summary>
[CodecFlag("D.VI.S")][Name("dxtory")]dxtory,

/// <summary>
/// Resolume DXV
/// </summary>
[CodecFlag("DEVIL.")][Name("dxv")]dxv,

/// <summary>
/// Escape 124
/// </summary>
[CodecFlag("D.V.L.")][Name("escape124")]escape124,

/// <summary>
/// Escape 130
/// </summary>
[CodecFlag("D.V.L.")][Name("escape130")]escape130,

/// <summary>
/// MPEG-5 EVC (Essential Video Coding)
/// </summary>
[CodecFlag("..V.L.")][Name("evc")]evc,

/// <summary>
/// OpenEXR image
/// </summary>
[CodecFlag("DEVILS")][Name("exr")]exr,

/// <summary>
/// FFmpeg video codec #1
/// </summary>
[CodecFlag("DEV..S")][Name("ffv1")]ffv1,

/// <summary>
/// Huffyuv FFmpeg variant
/// </summary>
[CodecFlag("DEVI.S")][Name("ffvhuff")]ffvhuff,

/// <summary>
/// Mirillis FIC
/// </summary>
[CodecFlag("D.V.L.")][Name("fic")]fic,

/// <summary>
/// FITS (Flexible Image Transport System)
/// </summary>
[CodecFlag("DEVI.S")][Name("fits")]fits,

/// <summary>
/// Flash Screen Video v1
/// </summary>
[CodecFlag("DEV..S")][Name("flashsv")]flashsv,

/// <summary>
/// Flash Screen Video v2
/// </summary>
[CodecFlag("DEV.L.")][Name("flashsv2")]flashsv2,

/// <summary>
/// Autodesk Animator Flic video
/// </summary>
[CodecFlag("D.V..S")][Name("flic")]flic,

/// <summary>
/// FLV / Sorenson Spark / Sorenson H.263 (Flash Video) (decoders: flv) (encoders: flv)
/// </summary>
[CodecFlag("DEV.L.")][Name("flv1")]flv1,

/// <summary>
/// FM Screen Capture Codec
/// </summary>
[CodecFlag("D.V..S")][Name("fmvc")]fmvc,

/// <summary>
/// Fraps
/// </summary>
[CodecFlag("D.VI.S")][Name("fraps")]fraps,

/// <summary>
/// Forward Uncompressed
/// </summary>
[CodecFlag("D.VI.S")][Name("frwu")]frwu,

/// <summary>
/// Go2Meeting
/// </summary>
[CodecFlag("D.V.L.")][Name("g2m")]g2m,

/// <summary>
/// Gremlin Digital Video
/// </summary>
[CodecFlag("D.V.L.")][Name("gdv")]gdv,

/// <summary>
/// GEM Raster image
/// </summary>
[CodecFlag("D.V.L.")][Name("gem")]gem,

/// <summary>
/// CompuServe GIF (Graphics Interchange Format)
/// </summary>
[CodecFlag("DEV..S")][Name("gif")]gif,

/// <summary>
/// H.261
/// </summary>
[CodecFlag("DEV.L.")][Name("h261")]h261,

/// <summary>
/// H.263 / H.263-1996, H.263+ / H.263-1998 / H.263 version 2
/// </summary>
[CodecFlag("DEV.L.")][Name("h263")]h263,

/// <summary>
/// Intel H.263
/// </summary>
[CodecFlag("D.V.L.")][Name("h263i")]h263i,

/// <summary>
/// H.263+ / H.263-1998 / H.263 version 2
/// </summary>
[CodecFlag("DEV.L.")][Name("h263p")]h263p,

/// <summary>
/// H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10 (decoders: h264 h264_qsv libopenh264 h264_cuvid) (encoders: libx264 libx264rgb libopenh264 h264_amf h264_mf h264_nvenc h264_qsv h264_vaapi)
/// </summary>
[CodecFlag("DEV.LS")][Name("h264")]h264,

/// <summary>
/// Vidvox Hap
/// </summary>
[CodecFlag("DEVIL.")][Name("hap")]hap,

/// <summary>
/// HDR (Radiance RGBE format) image
/// </summary>
[CodecFlag("DEVIL.")][Name("hdr")]hdr,

/// <summary>
/// H.265 / HEVC (High Efficiency Video Coding) (decoders: hevc hevc_qsv hevc_cuvid) (encoders: libx265 hevc_amf hevc_mf hevc_nvenc hevc_qsv hevc_vaapi libkvazaar)
/// </summary>
[CodecFlag("DEV.L.")][Name("hevc")]hevc,

/// <summary>
/// HNM 4 video
/// </summary>
[CodecFlag("D.V.L.")][Name("hnm4video")]hnm4video,

/// <summary>
/// Canopus HQ/HQA
/// </summary>
[CodecFlag("D.VIL.")][Name("hq_hqa")]hq_hqa,

/// <summary>
/// Canopus HQX
/// </summary>
[CodecFlag("D.VIL.")][Name("hqx")]hqx,

/// <summary>
/// HuffYUV
/// </summary>
[CodecFlag("DEVI.S")][Name("huffyuv")]huffyuv,

/// <summary>
/// HuffYUV MT
/// </summary>
[CodecFlag("D.VI.S")][Name("hymt")]hymt,

/// <summary>
/// id Quake II CIN video (decoders: idcinvideo)
/// </summary>
[CodecFlag("D.V.L.")][Name("idcin")]idcin,

/// <summary>
/// iCEDraw text
/// </summary>
[CodecFlag("D.VI..")][Name("idf")]idf,

/// <summary>
/// IFF ACBM/ANIM/DEEP/ILBM/PBM/RGB8/RGBN (decoders: iff)
/// </summary>
[CodecFlag("D.V.L.")][Name("iff_ilbm")]iff_ilbm,

/// <summary>
/// Infinity IMM4
/// </summary>
[CodecFlag("D.V.L.")][Name("imm4")]imm4,

/// <summary>
/// Infinity IMM5
/// </summary>
[CodecFlag("D.V.L.")][Name("imm5")]imm5,

/// <summary>
/// Intel Indeo 2
/// </summary>
[CodecFlag("D.V.L.")][Name("indeo2")]indeo2,

/// <summary>
/// Intel Indeo 3
/// </summary>
[CodecFlag("D.V.L.")][Name("indeo3")]indeo3,

/// <summary>
/// Intel Indeo Video Interactive 4
/// </summary>
[CodecFlag("D.V.L.")][Name("indeo4")]indeo4,

/// <summary>
/// Intel Indeo Video Interactive 5
/// </summary>
[CodecFlag("D.V.L.")][Name("indeo5")]indeo5,

/// <summary>
/// Interplay MVE video
/// </summary>
[CodecFlag("D.V.L.")][Name("interplayvideo")]interplayvideo,

/// <summary>
/// IPU Video
/// </summary>
[CodecFlag("D.VIL.")][Name("ipu")]ipu,

/// <summary>
/// JPEG 2000 (encoders: jpeg2000 libopenjpeg)
/// </summary>
[CodecFlag("DEVILS")][Name("jpeg2000")]jpeg2000,

/// <summary>
/// JPEG-LS
/// </summary>
[CodecFlag("DEVILS")][Name("jpegls")]jpegls,

/// <summary>
/// JPEG XL (decoders: libjxl) (encoders: libjxl)
/// </summary>
[CodecFlag("DEVILS")][Name("jpegxl")]jpegxl,

/// <summary>
/// Bitmap Brothers JV video
/// </summary>
[CodecFlag("D.VIL.")][Name("jv")]jv,

/// <summary>
/// Kega Game Video
/// </summary>
[CodecFlag("D.V.L.")][Name("kgv1")]kgv1,

/// <summary>
/// Karl Morton&#39;s video codec
/// </summary>
[CodecFlag("D.V.L.")][Name("kmvc")]kmvc,

/// <summary>
/// Lagarith lossless
/// </summary>
[CodecFlag("D.VI.S")][Name("lagarith")]lagarith,

/// <summary>
/// LEAD MCMP
/// </summary>
[CodecFlag("D.VIL.")][Name("lead")]lead,

/// <summary>
/// Lossless JPEG
/// </summary>
[CodecFlag(".EVI.S")][Name("ljpeg")]ljpeg,

/// <summary>
/// LOCO
/// </summary>
[CodecFlag("D.VI.S")][Name("loco")]loco,

/// <summary>
/// LEAD Screen Capture
/// </summary>
[CodecFlag("D.V.L.")][Name("lscr")]lscr,

/// <summary>
/// Matrox Uncompressed SD
/// </summary>
[CodecFlag("D.VI.S")][Name("m101")]m101,

/// <summary>
/// Electronic Arts Madcow Video (decoders: eamad)
/// </summary>
[CodecFlag("D.V.L.")][Name("mad")]mad,

/// <summary>
/// MagicYUV video
/// </summary>
[CodecFlag("DEVI.S")][Name("magicyuv")]magicyuv,

/// <summary>
/// Sony PlayStation MDEC (Motion DECoder)
/// </summary>
[CodecFlag("D.VIL.")][Name("mdec")]mdec,

/// <summary>
/// Media 100i
/// </summary>
[CodecFlag("D.VIL.")][Name("media100")]media100,

/// <summary>
/// Mimic
/// </summary>
[CodecFlag("D.V.L.")][Name("mimic")]mimic,

/// <summary>
/// Motion JPEG (decoders: mjpeg mjpeg_cuvid mjpeg_qsv) (encoders: mjpeg mjpeg_qsv mjpeg_vaapi)
/// </summary>
[CodecFlag("DEVIL.")][Name("mjpeg")]mjpeg,

/// <summary>
/// Apple MJPEG-B
/// </summary>
[CodecFlag("D.VIL.")][Name("mjpegb")]mjpegb,

/// <summary>
/// American Laser Games MM Video
/// </summary>
[CodecFlag("D.V.L.")][Name("mmvideo")]mmvideo,

/// <summary>
/// MobiClip Video
/// </summary>
[CodecFlag("D.V.L.")][Name("mobiclip")]mobiclip,

/// <summary>
/// Motion Pixels video
/// </summary>
[CodecFlag("D.V.L.")][Name("motionpixels")]motionpixels,

/// <summary>
/// MPEG-1 video (decoders: mpeg1video mpeg1_cuvid)
/// </summary>
[CodecFlag("DEV.L.")][Name("mpeg1video")]mpeg1video,

/// <summary>
/// MPEG-2 video (decoders: mpeg2video mpegvideo mpeg2_qsv mpeg2_cuvid) (encoders: mpeg2video mpeg2_qsv mpeg2_vaapi)
/// </summary>
[CodecFlag("DEV.L.")][Name("mpeg2video")]mpeg2video,

/// <summary>
/// MPEG-4 part 2 (decoders: mpeg4 mpeg4_cuvid) (encoders: mpeg4 libxvid)
/// </summary>
[CodecFlag("DEV.L.")][Name("mpeg4")]mpeg4,

/// <summary>
/// MS ATC Screen
/// </summary>
[CodecFlag("D.V.L.")][Name("msa1")]msa1,

/// <summary>
/// Mandsoft Screen Capture Codec
/// </summary>
[CodecFlag("D.VI.S")][Name("mscc")]mscc,

/// <summary>
/// MPEG-4 part 2 Microsoft variant version 1
/// </summary>
[CodecFlag("D.V.L.")][Name("msmpeg4v1")]msmpeg4v1,

/// <summary>
/// MPEG-4 part 2 Microsoft variant version 2
/// </summary>
[CodecFlag("DEV.L.")][Name("msmpeg4v2")]msmpeg4v2,

/// <summary>
/// MPEG-4 part 2 Microsoft variant version 3 (decoders: msmpeg4) (encoders: msmpeg4)
/// </summary>
[CodecFlag("DEV.L.")][Name("msmpeg4v3")]msmpeg4v3,

/// <summary>
/// Microsoft Paint (MSP) version 2
/// </summary>
[CodecFlag("D.VI.S")][Name("msp2")]msp2,

/// <summary>
/// Microsoft RLE
/// </summary>
[CodecFlag("DEV..S")][Name("msrle")]msrle,

/// <summary>
/// MS Screen 1
/// </summary>
[CodecFlag("D.V.L.")][Name("mss1")]mss1,

/// <summary>
/// MS Windows Media Video V9 Screen
/// </summary>
[CodecFlag("D.VIL.")][Name("mss2")]mss2,

/// <summary>
/// Microsoft Video 1
/// </summary>
[CodecFlag("DEV.L.")][Name("msvideo1")]msvideo1,

/// <summary>
/// LCL (LossLess Codec Library) MSZH
/// </summary>
[CodecFlag("D.VI.S")][Name("mszh")]mszh,

/// <summary>
/// MS Expression Encoder Screen
/// </summary>
[CodecFlag("D.V.L.")][Name("mts2")]mts2,

/// <summary>
/// MidiVid 3.0
/// </summary>
[CodecFlag("D.V.L.")][Name("mv30")]mv30,

/// <summary>
/// Silicon Graphics Motion Video Compressor 1
/// </summary>
[CodecFlag("D.VIL.")][Name("mvc1")]mvc1,

/// <summary>
/// Silicon Graphics Motion Video Compressor 2
/// </summary>
[CodecFlag("D.VIL.")][Name("mvc2")]mvc2,

/// <summary>
/// MidiVid VQ
/// </summary>
[CodecFlag("D.V.L.")][Name("mvdv")]mvdv,

/// <summary>
/// MidiVid Archive Codec
/// </summary>
[CodecFlag("D.VIL.")][Name("mvha")]mvha,

/// <summary>
/// MatchWare Screen Capture Codec
/// </summary>
[CodecFlag("D.V..S")][Name("mwsc")]mwsc,

/// <summary>
/// Mobotix MxPEG video
/// </summary>
[CodecFlag("D.V.L.")][Name("mxpeg")]mxpeg,

/// <summary>
/// NotchLC
/// </summary>
[CodecFlag("D.VIL.")][Name("notchlc")]notchlc,

/// <summary>
/// NuppelVideo/RTJPEG
/// </summary>
[CodecFlag("D.V.L.")][Name("nuv")]nuv,

/// <summary>
/// Amazing Studio Packed Animation File Video
/// </summary>
[CodecFlag("D.V.L.")][Name("paf_video")]paf_video,

/// <summary>
/// PAM (Portable AnyMap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("pam")]pam,

/// <summary>
/// PBM (Portable BitMap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("pbm")]pbm,

/// <summary>
/// PC Paintbrush PCX image
/// </summary>
[CodecFlag("DEVI.S")][Name("pcx")]pcx,

/// <summary>
/// PDV (PlayDate Video)
/// </summary>
[CodecFlag("D.V.L.")][Name("pdv")]pdv,

/// <summary>
/// PFM (Portable FloatMap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("pfm")]pfm,

/// <summary>
/// PGM (Portable GrayMap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("pgm")]pgm,

/// <summary>
/// PGMYUV (Portable GrayMap YUV) image
/// </summary>
[CodecFlag("DEVI.S")][Name("pgmyuv")]pgmyuv,

/// <summary>
/// PGX (JPEG2000 Test Format)
/// </summary>
[CodecFlag("D.VI.S")][Name("pgx")]pgx,

/// <summary>
/// PHM (Portable HalfFloatMap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("phm")]phm,

/// <summary>
/// Kodak Photo CD
/// </summary>
[CodecFlag("D.V.L.")][Name("photocd")]photocd,

/// <summary>
/// Pictor/PC Paint
/// </summary>
[CodecFlag("D.VIL.")][Name("pictor")]pictor,

/// <summary>
/// Apple Pixlet
/// </summary>
[CodecFlag("D.VIL.")][Name("pixlet")]pixlet,

/// <summary>
/// PNG (Portable Network Graphics) image
/// </summary>
[CodecFlag("DEV..S")][Name("png")]png,

/// <summary>
/// PPM (Portable PixelMap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("ppm")]ppm,

/// <summary>
/// Apple ProRes (iCodec Pro) (encoders: prores prores_aw prores_ks)
/// </summary>
[CodecFlag("DEVIL.")][Name("prores")]prores,

/// <summary>
/// Brooktree ProSumer Video
/// </summary>
[CodecFlag("D.VIL.")][Name("prosumer")]prosumer,

/// <summary>
/// Photoshop PSD file
/// </summary>
[CodecFlag("D.VI.S")][Name("psd")]psd,

/// <summary>
/// V.Flash PTX image
/// </summary>
[CodecFlag("D.VIL.")][Name("ptx")]ptx,

/// <summary>
/// Apple QuickDraw
/// </summary>
[CodecFlag("D.VI.S")][Name("qdraw")]qdraw,

/// <summary>
/// QOI (Quite OK Image)
/// </summary>
[CodecFlag("DEVI.S")][Name("qoi")]qoi,

/// <summary>
/// Q-team QPEG
/// </summary>
[CodecFlag("D.V.L.")][Name("qpeg")]qpeg,

/// <summary>
/// QuickTime Animation (RLE) video
/// </summary>
[CodecFlag("DEV..S")][Name("qtrle")]qtrle,

/// <summary>
/// AJA Kona 10-bit RGB Codec
/// </summary>
[CodecFlag("DEVI.S")][Name("r10k")]r10k,

/// <summary>
/// Uncompressed RGB 10-bit
/// </summary>
[CodecFlag("DEVI.S")][Name("r210")]r210,

/// <summary>
/// RemotelyAnywhere Screen Capture
/// </summary>
[CodecFlag("D.V.L.")][Name("rasc")]rasc,

/// <summary>
/// raw video
/// </summary>
[CodecFlag("DEVI.S")][Name("rawvideo")]rawvideo,

/// <summary>
/// RL2 video
/// </summary>
[CodecFlag("D.VIL.")][Name("rl2")]rl2,

/// <summary>
/// id RoQ video (decoders: roqvideo) (encoders: roqvideo)
/// </summary>
[CodecFlag("DEV.L.")][Name("roq")]roq,

/// <summary>
/// QuickTime video (RPZA)
/// </summary>
[CodecFlag("DEV.L.")][Name("rpza")]rpza,

/// <summary>
/// innoHeim/Rsupport Screen Capture Codec
/// </summary>
[CodecFlag("D.V..S")][Name("rscc")]rscc,

/// <summary>
/// RTV1 (RivaTuner Video)
/// </summary>
[CodecFlag("D.VIL.")][Name("rtv1")]rtv1,

/// <summary>
/// RealVideo 1.0
/// </summary>
[CodecFlag("DEV.L.")][Name("rv10")]rv10,

/// <summary>
/// RealVideo 2.0
/// </summary>
[CodecFlag("DEV.L.")][Name("rv20")]rv20,

/// <summary>
/// RealVideo 3.0
/// </summary>
[CodecFlag("D.V.L.")][Name("rv30")]rv30,

/// <summary>
/// RealVideo 4.0
/// </summary>
[CodecFlag("D.V.L.")][Name("rv40")]rv40,

/// <summary>
/// LucasArts SANM/SMUSH video
/// </summary>
[CodecFlag("D.V.L.")][Name("sanm")]sanm,

/// <summary>
/// ScreenPressor
/// </summary>
[CodecFlag("D.V.LS")][Name("scpr")]scpr,

/// <summary>
/// Screenpresso
/// </summary>
[CodecFlag("D.V..S")][Name("screenpresso")]screenpresso,

/// <summary>
/// Digital Pictures SGA Video
/// </summary>
[CodecFlag("D.V.L.")][Name("sga")]sga,

/// <summary>
/// SGI image
/// </summary>
[CodecFlag("DEVI.S")][Name("sgi")]sgi,

/// <summary>
/// SGI RLE 8-bit
/// </summary>
[CodecFlag("D.VI.S")][Name("sgirle")]sgirle,

/// <summary>
/// BitJazz SheerVideo
/// </summary>
[CodecFlag("D.VI.S")][Name("sheervideo")]sheervideo,

/// <summary>
/// Simbiosis Interactive IMX Video
/// </summary>
[CodecFlag("D.V.L.")][Name("simbiosis_imx")]simbiosis_imx,

/// <summary>
/// Smacker video (decoders: smackvid)
/// </summary>
[CodecFlag("D.V.L.")][Name("smackvideo")]smackvideo,

/// <summary>
/// QuickTime Graphics (SMC)
/// </summary>
[CodecFlag("DEV.L.")][Name("smc")]smc,

/// <summary>
/// Sigmatel Motion Video
/// </summary>
[CodecFlag("D.VIL.")][Name("smvjpeg")]smvjpeg,

/// <summary>
/// Snow
/// </summary>
[CodecFlag("DEV.LS")][Name("snow")]snow,

/// <summary>
/// Sunplus JPEG (SP5X)
/// </summary>
[CodecFlag("D.VIL.")][Name("sp5x")]sp5x,

/// <summary>
/// NewTek SpeedHQ
/// </summary>
[CodecFlag("DEVIL.")][Name("speedhq")]speedhq,

/// <summary>
/// Screen Recorder Gold Codec
/// </summary>
[CodecFlag("D.VI.S")][Name("srgc")]srgc,

/// <summary>
/// Sun Rasterfile image
/// </summary>
[CodecFlag("DEVI.S")][Name("sunrast")]sunrast,

/// <summary>
/// Scalable Vector Graphics
/// </summary>
[CodecFlag("..V..S")][Name("svg")]svg,

/// <summary>
/// Sorenson Vector Quantizer 1 / Sorenson Video 1 / SVQ1
/// </summary>
[CodecFlag("DEV.L.")][Name("svq1")]svq1,

/// <summary>
/// Sorenson Vector Quantizer 3 / Sorenson Video 3 / SVQ3
/// </summary>
[CodecFlag("D.V.L.")][Name("svq3")]svq3,

/// <summary>
/// Truevision Targa image
/// </summary>
[CodecFlag("DEVI.S")][Name("targa")]targa,

/// <summary>
/// Pinnacle TARGA CineWave YUV16
/// </summary>
[CodecFlag("D.VI.S")][Name("targa_y216")]targa_y216,

/// <summary>
/// TDSC
/// </summary>
[CodecFlag("D.V.L.")][Name("tdsc")]tdsc,

/// <summary>
/// Electronic Arts TGQ video (decoders: eatgq)
/// </summary>
[CodecFlag("D.V.L.")][Name("tgq")]tgq,

/// <summary>
/// Electronic Arts TGV video (decoders: eatgv)
/// </summary>
[CodecFlag("D.V.L.")][Name("tgv")]tgv,

/// <summary>
/// Theora (encoders: libtheora)
/// </summary>
[CodecFlag("DEV.L.")][Name("theora")]theora,

/// <summary>
/// Nintendo Gamecube THP video
/// </summary>
[CodecFlag("D.VIL.")][Name("thp")]thp,

/// <summary>
/// Tiertex Limited SEQ video
/// </summary>
[CodecFlag("D.V.L.")][Name("tiertexseqvideo")]tiertexseqvideo,

/// <summary>
/// TIFF image
/// </summary>
[CodecFlag("DEVI.S")][Name("tiff")]tiff,

/// <summary>
/// 8088flex TMV
/// </summary>
[CodecFlag("D.VIL.")][Name("tmv")]tmv,

/// <summary>
/// Electronic Arts TQI video (decoders: eatqi)
/// </summary>
[CodecFlag("D.V.L.")][Name("tqi")]tqi,

/// <summary>
/// Duck TrueMotion 1.0
/// </summary>
[CodecFlag("D.V.L.")][Name("truemotion1")]truemotion1,

/// <summary>
/// Duck TrueMotion 2.0
/// </summary>
[CodecFlag("D.V.L.")][Name("truemotion2")]truemotion2,

/// <summary>
/// Duck TrueMotion 2.0 Real Time
/// </summary>
[CodecFlag("D.VIL.")][Name("truemotion2rt")]truemotion2rt,

/// <summary>
/// TechSmith Screen Capture Codec (decoders: camtasia)
/// </summary>
[CodecFlag("D.V..S")][Name("tscc")]tscc,

/// <summary>
/// TechSmith Screen Codec 2
/// </summary>
[CodecFlag("D.V.L.")][Name("tscc2")]tscc2,

/// <summary>
/// Renderware TXD (TeXture Dictionary) image
/// </summary>
[CodecFlag("D.VIL.")][Name("txd")]txd,

/// <summary>
/// IBM UltiMotion (decoders: ultimotion)
/// </summary>
[CodecFlag("D.V.L.")][Name("ulti")]ulti,

/// <summary>
/// Ut Video
/// </summary>
[CodecFlag("DEVI.S")][Name("utvideo")]utvideo,

/// <summary>
/// Uncompressed 4:2:2 10-bit
/// </summary>
[CodecFlag("DEVI.S")][Name("v210")]v210,

/// <summary>
/// Uncompressed 4:2:2 10-bit
/// </summary>
[CodecFlag("D.VI.S")][Name("v210x")]v210x,

/// <summary>
/// Uncompressed packed 4:4:4
/// </summary>
[CodecFlag("DEVI.S")][Name("v308")]v308,

/// <summary>
/// Uncompressed packed QT 4:4:4:4
/// </summary>
[CodecFlag("DEVI.S")][Name("v408")]v408,

/// <summary>
/// Uncompressed 4:4:4 10-bit
/// </summary>
[CodecFlag("DEVI.S")][Name("v410")]v410,

/// <summary>
/// Beam Software VB
/// </summary>
[CodecFlag("D.V.L.")][Name("vb")]vb,

/// <summary>
/// VBLE Lossless Codec
/// </summary>
[CodecFlag("D.VI.S")][Name("vble")]vble,

/// <summary>
/// Vizrt Binary Image
/// </summary>
[CodecFlag("DEV.L.")][Name("vbn")]vbn,

/// <summary>
/// SMPTE VC-1 (decoders: vc1 vc1_qsv vc1_cuvid)
/// </summary>
[CodecFlag("D.V.L.")][Name("vc1")]vc1,

/// <summary>
/// Windows Media Video 9 Image v2
/// </summary>
[CodecFlag("D.V.L.")][Name("vc1image")]vc1image,

/// <summary>
/// ATI VCR1
/// </summary>
[CodecFlag("D.VIL.")][Name("vcr1")]vcr1,

/// <summary>
/// Miro VideoXL (decoders: xl)
/// </summary>
[CodecFlag("D.VIL.")][Name("vixl")]vixl,

/// <summary>
/// Sierra VMD video
/// </summary>
[CodecFlag("D.V.L.")][Name("vmdvideo")]vmdvideo,

/// <summary>
/// vMix Video
/// </summary>
[CodecFlag("D.VIL.")][Name("vmix")]vmix,

/// <summary>
/// VMware Screen Codec / VMware Video
/// </summary>
[CodecFlag("D.V..S")][Name("vmnc")]vmnc,

/// <summary>
/// Null video codec
/// </summary>
[CodecFlag("DEV...")][Name("vnull")]vnull,

/// <summary>
/// On2 VP3
/// </summary>
[CodecFlag("D.V.L.")][Name("vp3")]vp3,

/// <summary>
/// On2 VP4
/// </summary>
[CodecFlag("D.V.L.")][Name("vp4")]vp4,

/// <summary>
/// On2 VP5
/// </summary>
[CodecFlag("D.V.L.")][Name("vp5")]vp5,

/// <summary>
/// On2 VP6
/// </summary>
[CodecFlag("D.V.L.")][Name("vp6")]vp6,

/// <summary>
/// On2 VP6 (Flash version, with alpha channel)
/// </summary>
[CodecFlag("D.V.L.")][Name("vp6a")]vp6a,

/// <summary>
/// On2 VP6 (Flash version)
/// </summary>
[CodecFlag("D.V.L.")][Name("vp6f")]vp6f,

/// <summary>
/// On2 VP7
/// </summary>
[CodecFlag("D.V.L.")][Name("vp7")]vp7,

/// <summary>
/// On2 VP8 (decoders: vp8 libvpx vp8_cuvid vp8_qsv) (encoders: libvpx vp8_vaapi)
/// </summary>
[CodecFlag("DEV.L.")][Name("vp8")]vp8,

/// <summary>
/// Google VP9 (decoders: vp9 libvpx-vp9 vp9_cuvid vp9_qsv) (encoders: libvpx-vp9 vp9_vaapi vp9_qsv)
/// </summary>
[CodecFlag("DEV.L.")][Name("vp9")]vp9,

/// <summary>
/// ViewQuest VQC
/// </summary>
[CodecFlag("D.V.L.")][Name("vqc")]vqc,

/// <summary>
/// H.266 / VVC (Versatile Video Coding)
/// </summary>
[CodecFlag("D.V.L.")][Name("vvc")]vvc,

/// <summary>
/// WBMP (Wireless Application Protocol Bitmap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("wbmp")]wbmp,

/// <summary>
/// WinCAM Motion Video
/// </summary>
[CodecFlag("D.V..S")][Name("wcmv")]wcmv,

/// <summary>
/// WebP (encoders: libwebp_anim libwebp)
/// </summary>
[CodecFlag("DEVILS")][Name("webp")]webp,

/// <summary>
/// Windows Media Video 7
/// </summary>
[CodecFlag("DEV.L.")][Name("wmv1")]wmv1,

/// <summary>
/// Windows Media Video 8
/// </summary>
[CodecFlag("DEV.L.")][Name("wmv2")]wmv2,

/// <summary>
/// Windows Media Video 9
/// </summary>
[CodecFlag("D.V.L.")][Name("wmv3")]wmv3,

/// <summary>
/// Windows Media Video 9 Image
/// </summary>
[CodecFlag("D.V.L.")][Name("wmv3image")]wmv3image,

/// <summary>
/// Winnov WNV1
/// </summary>
[CodecFlag("D.VIL.")][Name("wnv1")]wnv1,

/// <summary>
/// AVFrame to AVPacket passthrough
/// </summary>
[CodecFlag("DEV..S")][Name("wrapped_avframe")]wrapped_avframe,

/// <summary>
/// Westwood Studios VQA (Vector Quantized Animation) video (decoders: vqavideo)
/// </summary>
[CodecFlag("D.V.L.")][Name("ws_vqa")]ws_vqa,

/// <summary>
/// Wing Commander III / Xan
/// </summary>
[CodecFlag("D.V.L.")][Name("xan_wc3")]xan_wc3,

/// <summary>
/// Wing Commander IV / Xxan
/// </summary>
[CodecFlag("D.V.L.")][Name("xan_wc4")]xan_wc4,

/// <summary>
/// eXtended BINary text
/// </summary>
[CodecFlag("D.VI..")][Name("xbin")]xbin,

/// <summary>
/// XBM (X BitMap) image
/// </summary>
[CodecFlag("DEVI.S")][Name("xbm")]xbm,

/// <summary>
/// X-face image
/// </summary>
[CodecFlag("DEVIL.")][Name("xface")]xface,

/// <summary>
/// XPM (X PixMap) image
/// </summary>
[CodecFlag("D.VI.S")][Name("xpm")]xpm,

/// <summary>
/// XWD (X Window Dump) image
/// </summary>
[CodecFlag("DEVI.S")][Name("xwd")]xwd,

/// <summary>
/// Uncompressed YUV 4:1:1 12-bit
/// </summary>
[CodecFlag("DEVI.S")][Name("y41p")]y41p,

/// <summary>
/// YUY2 Lossless Codec
/// </summary>
[CodecFlag("D.VI.S")][Name("ylc")]ylc,

/// <summary>
/// Psygnosis YOP Video
/// </summary>
[CodecFlag("D.V.L.")][Name("yop")]yop,

/// <summary>
/// Uncompressed packed 4:2:0
/// </summary>
[CodecFlag("DEVI.S")][Name("yuv4")]yuv4,

/// <summary>
/// ZeroCodec Lossless Video
/// </summary>
[CodecFlag("D.V..S")][Name("zerocodec")]zerocodec,

/// <summary>
/// LCL (LossLess Codec Library) ZLIB
/// </summary>
[CodecFlag("DEVI.S")][Name("zlib")]zlib,

/// <summary>
/// Zip Motion Blocks Video
/// </summary>
[CodecFlag("DEV..S")][Name("zmbv")]zmbv,

/// <summary>
/// 4GV (Fourth Generation Vocoder)
/// </summary>
[CodecFlag("..AIL.")][Name("4gv")]_4gv,

/// <summary>
/// 8SVX exponential
/// </summary>
[CodecFlag("D.AIL.")][Name("8svx_exp")]_8svx_exp,

/// <summary>
/// 8SVX fibonacci
/// </summary>
[CodecFlag("D.AIL.")][Name("8svx_fib")]_8svx_fib,

/// <summary>
/// AAC (Advanced Audio Coding) (decoders: aac aac_fixed) (encoders: aac aac_mf)
/// </summary>
[CodecFlag("DEAIL.")][Name("aac")]aac,

/// <summary>
/// AAC LATM (Advanced Audio Coding LATM syntax)
/// </summary>
[CodecFlag("D.AIL.")][Name("aac_latm")]aac_latm,

/// <summary>
/// ATSC A/52A (AC-3) (decoders: ac3 ac3_fixed) (encoders: ac3 ac3_fixed ac3_mf)
/// </summary>
[CodecFlag("DEAIL.")][Name("ac3")]ac3,

/// <summary>
/// AC-4
/// </summary>
[CodecFlag("..A.L.")][Name("ac4")]ac4,

/// <summary>
/// Sipro ACELP.KELVIN
/// </summary>
[CodecFlag("D.AIL.")][Name("acelp.kelvin")]acelpDotkelvin,

/// <summary>
/// ADPCM 4X Movie
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_4xm")]adpcm_4xm,

/// <summary>
/// SEGA CRI ADX ADPCM
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_adx")]adpcm_adx,

/// <summary>
/// ADPCM Nintendo Gamecube AFC
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_afc")]adpcm_afc,

/// <summary>
/// ADPCM AmuseGraphics Movie AGM
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_agm")]adpcm_agm,

/// <summary>
/// ADPCM Yamaha AICA
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_aica")]adpcm_aica,

/// <summary>
/// ADPCM Argonaut Games
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_argo")]adpcm_argo,

/// <summary>
/// ADPCM Creative Technology
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ct")]adpcm_ct,

/// <summary>
/// ADPCM Nintendo Gamecube DTK
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_dtk")]adpcm_dtk,

/// <summary>
/// ADPCM Electronic Arts
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ea")]adpcm_ea,

/// <summary>
/// ADPCM Electronic Arts Maxis CDROM XA
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ea_maxis_xa")]adpcm_ea_maxis_xa,

/// <summary>
/// ADPCM Electronic Arts R1
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ea_r1")]adpcm_ea_r1,

/// <summary>
/// ADPCM Electronic Arts R2
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ea_r2")]adpcm_ea_r2,

/// <summary>
/// ADPCM Electronic Arts R3
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ea_r3")]adpcm_ea_r3,

/// <summary>
/// ADPCM Electronic Arts XAS
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ea_xas")]adpcm_ea_xas,

/// <summary>
/// G.722 ADPCM (decoders: g722) (encoders: g722)
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_g722")]adpcm_g722,

/// <summary>
/// G.726 ADPCM (decoders: g726) (encoders: g726)
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_g726")]adpcm_g726,

/// <summary>
/// G.726 ADPCM little-endian (decoders: g726le) (encoders: g726le)
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_g726le")]adpcm_g726le,

/// <summary>
/// ADPCM IMA Acorn Replay
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_acorn")]adpcm_ima_acorn,

/// <summary>
/// ADPCM IMA High Voltage Software ALP
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ima_alp")]adpcm_ima_alp,

/// <summary>
/// ADPCM IMA AMV
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ima_amv")]adpcm_ima_amv,

/// <summary>
/// ADPCM IMA CRYO APC
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_apc")]adpcm_ima_apc,

/// <summary>
/// ADPCM IMA Ubisoft APM
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ima_apm")]adpcm_ima_apm,

/// <summary>
/// ADPCM IMA Cunning Developments
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_cunning")]adpcm_ima_cunning,

/// <summary>
/// ADPCM IMA Eurocom DAT4
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_dat4")]adpcm_ima_dat4,

/// <summary>
/// ADPCM IMA Duck DK3
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_dk3")]adpcm_ima_dk3,

/// <summary>
/// ADPCM IMA Duck DK4
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_dk4")]adpcm_ima_dk4,

/// <summary>
/// ADPCM IMA Electronic Arts EACS
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_ea_eacs")]adpcm_ima_ea_eacs,

/// <summary>
/// ADPCM IMA Electronic Arts SEAD
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_ea_sead")]adpcm_ima_ea_sead,

/// <summary>
/// ADPCM IMA Funcom ISS
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_iss")]adpcm_ima_iss,

/// <summary>
/// ADPCM IMA MobiClip MOFLEX
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_moflex")]adpcm_ima_moflex,

/// <summary>
/// ADPCM IMA Capcom&#39;s MT Framework
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_mtf")]adpcm_ima_mtf,

/// <summary>
/// ADPCM IMA Dialogic OKI
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_oki")]adpcm_ima_oki,

/// <summary>
/// ADPCM IMA QuickTime
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ima_qt")]adpcm_ima_qt,

/// <summary>
/// ADPCM IMA Radical
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_rad")]adpcm_ima_rad,

/// <summary>
/// ADPCM IMA Loki SDL MJPEG
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_ima_smjpeg")]adpcm_ima_smjpeg,

/// <summary>
/// ADPCM IMA Simon &amp; Schuster Interactive
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ima_ssi")]adpcm_ima_ssi,

/// <summary>
/// ADPCM IMA WAV
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ima_wav")]adpcm_ima_wav,

/// <summary>
/// ADPCM IMA Westwood
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ima_ws")]adpcm_ima_ws,

/// <summary>
/// ADPCM Microsoft
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_ms")]adpcm_ms,

/// <summary>
/// ADPCM MTAF
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_mtaf")]adpcm_mtaf,

/// <summary>
/// ADPCM Playstation
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_psx")]adpcm_psx,

/// <summary>
/// ADPCM Sound Blaster Pro 2-bit
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_sbpro_2")]adpcm_sbpro_2,

/// <summary>
/// ADPCM Sound Blaster Pro 2.6-bit
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_sbpro_3")]adpcm_sbpro_3,

/// <summary>
/// ADPCM Sound Blaster Pro 4-bit
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_sbpro_4")]adpcm_sbpro_4,

/// <summary>
/// ADPCM Shockwave Flash
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_swf")]adpcm_swf,

/// <summary>
/// ADPCM Nintendo THP
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_thp")]adpcm_thp,

/// <summary>
/// ADPCM Nintendo THP (Little-Endian)
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_thp_le")]adpcm_thp_le,

/// <summary>
/// LucasArts VIMA audio
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_vima")]adpcm_vima,

/// <summary>
/// ADPCM CDROM XA
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_xa")]adpcm_xa,

/// <summary>
/// ADPCM Konami XMD
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_xmd")]adpcm_xmd,

/// <summary>
/// ADPCM Yamaha
/// </summary>
[CodecFlag("DEAIL.")][Name("adpcm_yamaha")]adpcm_yamaha,

/// <summary>
/// ADPCM Zork
/// </summary>
[CodecFlag("D.AIL.")][Name("adpcm_zork")]adpcm_zork,

/// <summary>
/// ALAC (Apple Lossless Audio Codec)
/// </summary>
[CodecFlag("DEAI.S")][Name("alac")]alac,

/// <summary>
/// AMR-NB (Adaptive Multi-Rate NarrowBand) (decoders: amrnb libopencore_amrnb) (encoders: libopencore_amrnb)
/// </summary>
[CodecFlag("DEAIL.")][Name("amr_nb")]amr_nb,

/// <summary>
/// AMR-WB (Adaptive Multi-Rate WideBand) (decoders: amrwb libopencore_amrwb)
/// </summary>
[CodecFlag("D.AIL.")][Name("amr_wb")]amr_wb,

/// <summary>
/// Null audio codec
/// </summary>
[CodecFlag("DEA...")][Name("anull")]anull,

/// <summary>
/// Marian&#39;s A-pac audio
/// </summary>
[CodecFlag("D.AI.S")][Name("apac")]apac,

/// <summary>
/// Monkey&#39;s Audio
/// </summary>
[CodecFlag("D.AI.S")][Name("ape")]ape,

/// <summary>
/// aptX (Audio Processing Technology for Bluetooth)
/// </summary>
[CodecFlag("DEAIL.")][Name("aptx")]aptx,

/// <summary>
/// aptX HD (Audio Processing Technology for Bluetooth)
/// </summary>
[CodecFlag("DEAIL.")][Name("aptx_hd")]aptx_hd,

/// <summary>
/// ATRAC1 (Adaptive TRansform Acoustic Coding)
/// </summary>
[CodecFlag("D.AIL.")][Name("atrac1")]atrac1,

/// <summary>
/// ATRAC3 (Adaptive TRansform Acoustic Coding 3)
/// </summary>
[CodecFlag("D.AIL.")][Name("atrac3")]atrac3,

/// <summary>
/// ATRAC3 AL (Adaptive TRansform Acoustic Coding 3 Advanced Lossless)
/// </summary>
[CodecFlag("D.AI.S")][Name("atrac3al")]atrac3al,

/// <summary>
/// ATRAC3+ (Adaptive TRansform Acoustic Coding 3+) (decoders: atrac3plus)
/// </summary>
[CodecFlag("D.AIL.")][Name("atrac3p")]atrac3p,

/// <summary>
/// ATRAC3+ AL (Adaptive TRansform Acoustic Coding 3+ Advanced Lossless) (decoders: atrac3plusal)
/// </summary>
[CodecFlag("D.AI.S")][Name("atrac3pal")]atrac3pal,

/// <summary>
/// ATRAC9 (Adaptive TRansform Acoustic Coding 9)
/// </summary>
[CodecFlag("D.AIL.")][Name("atrac9")]atrac9,

/// <summary>
/// On2 Audio for Video Codec (decoders: on2avc)
/// </summary>
[CodecFlag("D.AIL.")][Name("avc")]avc,

/// <summary>
/// Bink Audio (DCT)
/// </summary>
[CodecFlag("D.AIL.")][Name("binkaudio_dct")]binkaudio_dct,

/// <summary>
/// Bink Audio (RDFT)
/// </summary>
[CodecFlag("D.AIL.")][Name("binkaudio_rdft")]binkaudio_rdft,

/// <summary>
/// Discworld II BMV audio
/// </summary>
[CodecFlag("D.AIL.")][Name("bmv_audio")]bmv_audio,

/// <summary>
/// Bonk audio
/// </summary>
[CodecFlag("D.AILS")][Name("bonk")]bonk,

/// <summary>
/// DPCM Cuberoot-Delta-Exact
/// </summary>
[CodecFlag("D.AIL.")][Name("cbd2_dpcm")]cbd2_dpcm,

/// <summary>
/// Constrained Energy Lapped Transform (CELT)
/// </summary>
[CodecFlag("..AIL.")][Name("celt")]celt,

/// <summary>
/// codec2 (very low bitrate speech codec)
/// </summary>
[CodecFlag("..AIL.")][Name("codec2")]codec2,

/// <summary>
/// RFC 3389 Comfort Noise
/// </summary>
[CodecFlag("DEAIL.")][Name("comfortnoise")]comfortnoise,

/// <summary>
/// Cook / Cooker / Gecko (RealAudio G2)
/// </summary>
[CodecFlag("D.AIL.")][Name("cook")]cook,

/// <summary>
/// DPCM Xilam DERF
/// </summary>
[CodecFlag("D.AIL.")][Name("derf_dpcm")]derf_dpcm,

/// <summary>
/// DFPWM (Dynamic Filter Pulse Width Modulation)
/// </summary>
[CodecFlag("DEA.L.")][Name("dfpwm")]dfpwm,

/// <summary>
/// Dolby E
/// </summary>
[CodecFlag("D.AIL.")][Name("dolby_e")]dolby_e,

/// <summary>
/// DSD (Direct Stream Digital), least significant bit first
/// </summary>
[CodecFlag("D.AIL.")][Name("dsd_lsbf")]dsd_lsbf,

/// <summary>
/// DSD (Direct Stream Digital), least significant bit first, planar
/// </summary>
[CodecFlag("D.AIL.")][Name("dsd_lsbf_planar")]dsd_lsbf_planar,

/// <summary>
/// DSD (Direct Stream Digital), most significant bit first
/// </summary>
[CodecFlag("D.AIL.")][Name("dsd_msbf")]dsd_msbf,

/// <summary>
/// DSD (Direct Stream Digital), most significant bit first, planar
/// </summary>
[CodecFlag("D.AIL.")][Name("dsd_msbf_planar")]dsd_msbf_planar,

/// <summary>
/// Delphine Software International CIN audio
/// </summary>
[CodecFlag("D.AIL.")][Name("dsicinaudio")]dsicinaudio,

/// <summary>
/// Digital Speech Standard - Standard Play mode (DSS SP)
/// </summary>
[CodecFlag("D.AIL.")][Name("dss_sp")]dss_sp,

/// <summary>
/// DST (Direct Stream Transfer)
/// </summary>
[CodecFlag("D.AI.S")][Name("dst")]dst,

/// <summary>
/// DCA (DTS Coherent Acoustics) (decoders: dca) (encoders: dca)
/// </summary>
[CodecFlag("DEAILS")][Name("dts")]dts,

/// <summary>
/// DV audio
/// </summary>
[CodecFlag("D.AIL.")][Name("dvaudio")]dvaudio,

/// <summary>
/// ATSC A/52B (AC-3, E-AC-3)
/// </summary>
[CodecFlag("DEAIL.")][Name("eac3")]eac3,

/// <summary>
/// EVRC (Enhanced Variable Rate Codec)
/// </summary>
[CodecFlag("D.AIL.")][Name("evrc")]evrc,

/// <summary>
/// MobiClip FastAudio
/// </summary>
[CodecFlag("D.AIL.")][Name("fastaudio")]fastaudio,

/// <summary>
/// FLAC (Free Lossless Audio Codec)
/// </summary>
[CodecFlag("DEAI.S")][Name("flac")]flac,

/// <summary>
/// FTR Voice
/// </summary>
[CodecFlag("D.AIL.")][Name("ftr")]ftr,

/// <summary>
/// G.723.1
/// </summary>
[CodecFlag("DEAIL.")][Name("g723_1")]g723_1,

/// <summary>
/// G.729
/// </summary>
[CodecFlag("D.AIL.")][Name("g729")]g729,

/// <summary>
/// DPCM Gremlin
/// </summary>
[CodecFlag("D.AIL.")][Name("gremlin_dpcm")]gremlin_dpcm,

/// <summary>
/// GSM
/// </summary>
[CodecFlag("D.AIL.")][Name("gsm")]gsm,

/// <summary>
/// GSM Microsoft variant
/// </summary>
[CodecFlag("D.AIL.")][Name("gsm_ms")]gsm_ms,

/// <summary>
/// CRI HCA
/// </summary>
[CodecFlag("D.AIL.")][Name("hca")]hca,

/// <summary>
/// HCOM Audio
/// </summary>
[CodecFlag("D.AIL.")][Name("hcom")]hcom,

/// <summary>
/// IAC (Indeo Audio Coder)
/// </summary>
[CodecFlag("D.AIL.")][Name("iac")]iac,

/// <summary>
/// iLBC (Internet Low Bitrate Codec)
/// </summary>
[CodecFlag("D.AIL.")][Name("ilbc")]ilbc,

/// <summary>
/// IMC (Intel Music Coder)
/// </summary>
[CodecFlag("D.AIL.")][Name("imc")]imc,

/// <summary>
/// DPCM Interplay
/// </summary>
[CodecFlag("D.AIL.")][Name("interplay_dpcm")]interplay_dpcm,

/// <summary>
/// Interplay ACM
/// </summary>
[CodecFlag("D.AIL.")][Name("interplayacm")]interplayacm,

/// <summary>
/// MACE (Macintosh Audio Compression/Expansion) 3:1
/// </summary>
[CodecFlag("D.AIL.")][Name("mace3")]mace3,

/// <summary>
/// MACE (Macintosh Audio Compression/Expansion) 6:1
/// </summary>
[CodecFlag("D.AIL.")][Name("mace6")]mace6,

/// <summary>
/// Voxware MetaSound
/// </summary>
[CodecFlag("D.AIL.")][Name("metasound")]metasound,

/// <summary>
/// Micronas SC-4 Audio
/// </summary>
[CodecFlag("D.AIL.")][Name("misc4")]misc4,

/// <summary>
/// MLP (Meridian Lossless Packing)
/// </summary>
[CodecFlag("DEA..S")][Name("mlp")]mlp,

/// <summary>
/// MP1 (MPEG audio layer 1) (decoders: mp1 mp1float)
/// </summary>
[CodecFlag("D.AIL.")][Name("mp1")]mp1,

/// <summary>
/// MP2 (MPEG audio layer 2) (decoders: mp2 mp2float) (encoders: mp2 mp2fixed libtwolame)
/// </summary>
[CodecFlag("DEAIL.")][Name("mp2")]mp2,

/// <summary>
/// MP3 (MPEG audio layer 3) (decoders: mp3float mp3) (encoders: libmp3lame mp3_mf)
/// </summary>
[CodecFlag("DEAIL.")][Name("mp3")]mp3,

/// <summary>
/// ADU (Application Data Unit) MP3 (MPEG audio layer 3) (decoders: mp3adufloat mp3adu)
/// </summary>
[CodecFlag("D.AIL.")][Name("mp3adu")]mp3adu,

/// <summary>
/// MP3onMP4 (decoders: mp3on4float mp3on4)
/// </summary>
[CodecFlag("D.AIL.")][Name("mp3on4")]mp3on4,

/// <summary>
/// MPEG-4 Audio Lossless Coding (ALS) (decoders: als)
/// </summary>
[CodecFlag("D.AI.S")][Name("mp4als")]mp4als,

/// <summary>
/// MPEG-H 3D Audio
/// </summary>
[CodecFlag("..A.L.")][Name("mpegh_3d_audio")]mpegh_3d_audio,

/// <summary>
/// MSN Siren
/// </summary>
[CodecFlag("D.AIL.")][Name("msnsiren")]msnsiren,

/// <summary>
/// Musepack SV7 (decoders: mpc7)
/// </summary>
[CodecFlag("D.AIL.")][Name("musepack7")]musepack7,

/// <summary>
/// Musepack SV8 (decoders: mpc8)
/// </summary>
[CodecFlag("D.AIL.")][Name("musepack8")]musepack8,

/// <summary>
/// Nellymoser Asao
/// </summary>
[CodecFlag("DEAIL.")][Name("nellymoser")]nellymoser,

/// <summary>
/// Opus (Opus Interactive Audio Codec) (decoders: opus libopus) (encoders: opus libopus)
/// </summary>
[CodecFlag("DEAIL.")][Name("opus")]opus,

/// <summary>
/// OSQ (Original Sound Quality)
/// </summary>
[CodecFlag("D.AI.S")][Name("osq")]osq,

/// <summary>
/// Amazing Studio Packed Animation File Audio
/// </summary>
[CodecFlag("D.AIL.")][Name("paf_audio")]paf_audio,

/// <summary>
/// PCM A-law / G.711 A-law
/// </summary>
[CodecFlag("DEAIL.")][Name("pcm_alaw")]pcm_alaw,

/// <summary>
/// PCM signed 16|20|24-bit big-endian for Blu-ray media
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_bluray")]pcm_bluray,

/// <summary>
/// PCM signed 20|24-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_dvd")]pcm_dvd,

/// <summary>
/// PCM 16.8 floating point little-endian
/// </summary>
[CodecFlag("D.AI.S")][Name("pcm_f16le")]pcm_f16le,

/// <summary>
/// PCM 24.0 floating point little-endian
/// </summary>
[CodecFlag("D.AI.S")][Name("pcm_f24le")]pcm_f24le,

/// <summary>
/// PCM 32-bit floating point big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_f32be")]pcm_f32be,

/// <summary>
/// PCM 32-bit floating point little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_f32le")]pcm_f32le,

/// <summary>
/// PCM 64-bit floating point big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_f64be")]pcm_f64be,

/// <summary>
/// PCM 64-bit floating point little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_f64le")]pcm_f64le,

/// <summary>
/// PCM signed 20-bit little-endian planar
/// </summary>
[CodecFlag("D.AI.S")][Name("pcm_lxf")]pcm_lxf,

/// <summary>
/// PCM mu-law / G.711 mu-law
/// </summary>
[CodecFlag("DEAIL.")][Name("pcm_mulaw")]pcm_mulaw,

/// <summary>
/// PCM signed 16-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s16be")]pcm_s16be,

/// <summary>
/// PCM signed 16-bit big-endian planar
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s16be_planar")]pcm_s16be_planar,

/// <summary>
/// PCM signed 16-bit little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s16le")]pcm_s16le,

/// <summary>
/// PCM signed 16-bit little-endian planar
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s16le_planar")]pcm_s16le_planar,

/// <summary>
/// PCM signed 24-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s24be")]pcm_s24be,

/// <summary>
/// PCM D-Cinema audio signed 24-bit
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s24daud")]pcm_s24daud,

/// <summary>
/// PCM signed 24-bit little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s24le")]pcm_s24le,

/// <summary>
/// PCM signed 24-bit little-endian planar
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s24le_planar")]pcm_s24le_planar,

/// <summary>
/// PCM signed 32-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s32be")]pcm_s32be,

/// <summary>
/// PCM signed 32-bit little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s32le")]pcm_s32le,

/// <summary>
/// PCM signed 32-bit little-endian planar
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s32le_planar")]pcm_s32le_planar,

/// <summary>
/// PCM signed 64-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s64be")]pcm_s64be,

/// <summary>
/// PCM signed 64-bit little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s64le")]pcm_s64le,

/// <summary>
/// PCM signed 8-bit
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s8")]pcm_s8,

/// <summary>
/// PCM signed 8-bit planar
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_s8_planar")]pcm_s8_planar,

/// <summary>
/// PCM SGA
/// </summary>
[CodecFlag("D.AI.S")][Name("pcm_sga")]pcm_sga,

/// <summary>
/// PCM unsigned 16-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_u16be")]pcm_u16be,

/// <summary>
/// PCM unsigned 16-bit little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_u16le")]pcm_u16le,

/// <summary>
/// PCM unsigned 24-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_u24be")]pcm_u24be,

/// <summary>
/// PCM unsigned 24-bit little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_u24le")]pcm_u24le,

/// <summary>
/// PCM unsigned 32-bit big-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_u32be")]pcm_u32be,

/// <summary>
/// PCM unsigned 32-bit little-endian
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_u32le")]pcm_u32le,

/// <summary>
/// PCM unsigned 8-bit
/// </summary>
[CodecFlag("DEAI.S")][Name("pcm_u8")]pcm_u8,

/// <summary>
/// PCM Archimedes VIDC
/// </summary>
[CodecFlag("DEAIL.")][Name("pcm_vidc")]pcm_vidc,

/// <summary>
/// QCELP / PureVoice
/// </summary>
[CodecFlag("D.AIL.")][Name("qcelp")]qcelp,

/// <summary>
/// QDesign Music Codec 2
/// </summary>
[CodecFlag("D.AIL.")][Name("qdm2")]qdm2,

/// <summary>
/// QDesign Music
/// </summary>
[CodecFlag("D.AIL.")][Name("qdmc")]qdmc,

/// <summary>
/// QOA (Quite OK Audio)
/// </summary>
[CodecFlag("D.AIL.")][Name("qoa")]qoa,

/// <summary>
/// RealAudio 1.0 (14.4K) (decoders: real_144) (encoders: real_144)
/// </summary>
[CodecFlag("DEAIL.")][Name("ra_144")]ra_144,

/// <summary>
/// RealAudio 2.0 (28.8K) (decoders: real_288)
/// </summary>
[CodecFlag("D.AIL.")][Name("ra_288")]ra_288,

/// <summary>
/// RealAudio Lossless
/// </summary>
[CodecFlag("D.AI.S")][Name("ralf")]ralf,

/// <summary>
/// RKA (RK Audio)
/// </summary>
[CodecFlag("D.AILS")][Name("rka")]rka,

/// <summary>
/// DPCM id RoQ
/// </summary>
[CodecFlag("DEAIL.")][Name("roq_dpcm")]roq_dpcm,

/// <summary>
/// SMPTE 302M
/// </summary>
[CodecFlag("DEAI.S")][Name("s302m")]s302m,

/// <summary>
/// SBC (low-complexity subband codec)
/// </summary>
[CodecFlag("DEAIL.")][Name("sbc")]sbc,

/// <summary>
/// DPCM Squareroot-Delta-Exact
/// </summary>
[CodecFlag("D.AIL.")][Name("sdx2_dpcm")]sdx2_dpcm,

/// <summary>
/// Shorten
/// </summary>
[CodecFlag("D.AI.S")][Name("shorten")]shorten,

/// <summary>
/// RealAudio SIPR / ACELP.NET
/// </summary>
[CodecFlag("D.AIL.")][Name("sipr")]sipr,

/// <summary>
/// Siren
/// </summary>
[CodecFlag("D.AIL.")][Name("siren")]siren,

/// <summary>
/// Smacker audio (decoders: smackaud)
/// </summary>
[CodecFlag("D.AIL.")][Name("smackaudio")]smackaudio,

/// <summary>
/// SMV (Selectable Mode Vocoder)
/// </summary>
[CodecFlag("..AIL.")][Name("smv")]smv,

/// <summary>
/// DPCM Sol
/// </summary>
[CodecFlag("D.AIL.")][Name("sol_dpcm")]sol_dpcm,

/// <summary>
/// Sonic
/// </summary>
[CodecFlag("DEAI..")][Name("sonic")]sonic,

/// <summary>
/// Sonic lossless
/// </summary>
[CodecFlag(".EAI..")][Name("sonicls")]sonicls,

/// <summary>
/// Speex
/// </summary>
[CodecFlag("D.AIL.")][Name("speex")]speex,

/// <summary>
/// TAK (Tom&#39;s lossless Audio Kompressor)
/// </summary>
[CodecFlag("D.A..S")][Name("tak")]tak,

/// <summary>
/// TrueHD
/// </summary>
[CodecFlag("DEA..S")][Name("truehd")]truehd,

/// <summary>
/// DSP Group TrueSpeech
/// </summary>
[CodecFlag("D.AIL.")][Name("truespeech")]truespeech,

/// <summary>
/// TTA (True Audio)
/// </summary>
[CodecFlag("DEAI.S")][Name("tta")]tta,

/// <summary>
/// VQF TwinVQ
/// </summary>
[CodecFlag("D.AIL.")][Name("twinvq")]twinvq,

/// <summary>
/// Sierra VMD audio
/// </summary>
[CodecFlag("D.AIL.")][Name("vmdaudio")]vmdaudio,

/// <summary>
/// Vorbis (decoders: vorbis libvorbis) (encoders: vorbis libvorbis)
/// </summary>
[CodecFlag("DEAIL.")][Name("vorbis")]vorbis,

/// <summary>
/// DPCM Marble WADY
/// </summary>
[CodecFlag("D.AIL.")][Name("wady_dpcm")]wady_dpcm,

/// <summary>
/// Waveform Archiver
/// </summary>
[CodecFlag("D.AI.S")][Name("wavarc")]wavarc,

/// <summary>
/// Wave synthesis pseudo-codec
/// </summary>
[CodecFlag("D.AI..")][Name("wavesynth")]wavesynth,

/// <summary>
/// WavPack
/// </summary>
[CodecFlag("DEAILS")][Name("wavpack")]wavpack,

/// <summary>
/// Westwood Audio (SND1) (decoders: ws_snd1)
/// </summary>
[CodecFlag("D.AIL.")][Name("westwood_snd1")]westwood_snd1,

/// <summary>
/// Windows Media Audio Lossless
/// </summary>
[CodecFlag("D.AI.S")][Name("wmalossless")]wmalossless,

/// <summary>
/// Windows Media Audio 9 Professional
/// </summary>
[CodecFlag("D.AIL.")][Name("wmapro")]wmapro,

/// <summary>
/// Windows Media Audio 1
/// </summary>
[CodecFlag("DEAIL.")][Name("wmav1")]wmav1,

/// <summary>
/// Windows Media Audio 2
/// </summary>
[CodecFlag("DEAIL.")][Name("wmav2")]wmav2,

/// <summary>
/// Windows Media Audio Voice
/// </summary>
[CodecFlag("D.AIL.")][Name("wmavoice")]wmavoice,

/// <summary>
/// DPCM Xan
/// </summary>
[CodecFlag("D.AIL.")][Name("xan_dpcm")]xan_dpcm,

/// <summary>
/// Xbox Media Audio 1
/// </summary>
[CodecFlag("D.AIL.")][Name("xma1")]xma1,

/// <summary>
/// Xbox Media Audio 2
/// </summary>
[CodecFlag("D.AIL.")][Name("xma2")]xma2,

/// <summary>
/// binary data
/// </summary>
[CodecFlag("..D...")][Name("bin_data")]bin_data,

/// <summary>
/// DVD Nav packet
/// </summary>
[CodecFlag("..D...")][Name("dvd_nav_packet")]dvd_nav_packet,

/// <summary>
/// Electronic Program Guide
/// </summary>
[CodecFlag("..D...")][Name("epg")]epg,

/// <summary>
/// SMPTE 336M Key-Length-Value (KLV) metadata
/// </summary>
[CodecFlag("..D...")][Name("klv")]klv,

/// <summary>
/// raw MPEG-TS stream
/// </summary>
[CodecFlag("..D...")][Name("mpegts")]mpegts,

/// <summary>
/// OpenType font
/// </summary>
[CodecFlag("..D...")][Name("otf")]otf,

/// <summary>
/// SCTE 35 Message Queue
/// </summary>
[CodecFlag("..D...")][Name("scte_35")]scte_35,

/// <summary>
/// SMPTE ST 2038 VANC in MPEG-2 TS
/// </summary>
[CodecFlag("..D...")][Name("smpte_2038")]smpte_2038,

/// <summary>
/// timed ID3 metadata
/// </summary>
[CodecFlag("..D...")][Name("timed_id3")]timed_id3,

/// <summary>
/// TrueType font
/// </summary>
[CodecFlag("..D...")][Name("ttf")]ttf,

/// <summary>
/// ARIB STD-B24 caption (decoders: libaribcaption libaribb24)
/// </summary>
[CodecFlag("D.S...")][Name("arib_caption")]arib_caption,

/// <summary>
/// ASS (Advanced SSA) subtitle (decoders: ssa ass) (encoders: ssa ass)
/// </summary>
[CodecFlag("DES...")][Name("ass")]ass,

/// <summary>
/// DVB subtitles (decoders: dvbsub) (encoders: dvbsub)
/// </summary>
[CodecFlag("DES...")][Name("dvb_subtitle")]dvb_subtitle,

/// <summary>
/// DVB teletext (decoders: libzvbi_teletextdec)
/// </summary>
[CodecFlag("D.S...")][Name("dvb_teletext")]dvb_teletext,

/// <summary>
/// DVD subtitles (decoders: dvdsub) (encoders: dvdsub)
/// </summary>
[CodecFlag("DES...")][Name("dvd_subtitle")]dvd_subtitle,

/// <summary>
/// EIA-608 closed captions (decoders: cc_dec)
/// </summary>
[CodecFlag("D.S...")][Name("eia_608")]eia_608,

/// <summary>
/// HDMV Presentation Graphic Stream subtitles (decoders: pgssub)
/// </summary>
[CodecFlag("D.S...")][Name("hdmv_pgs_subtitle")]hdmv_pgs_subtitle,

/// <summary>
/// HDMV Text subtitle
/// </summary>
[CodecFlag("..S...")][Name("hdmv_text_subtitle")]hdmv_text_subtitle,

/// <summary>
/// JACOsub subtitle
/// </summary>
[CodecFlag("D.S...")][Name("jacosub")]jacosub,

/// <summary>
/// MicroDVD subtitle
/// </summary>
[CodecFlag("D.S...")][Name("microdvd")]microdvd,

/// <summary>
/// MOV text
/// </summary>
[CodecFlag("DES...")][Name("mov_text")]mov_text,

/// <summary>
/// MPL2 subtitle
/// </summary>
[CodecFlag("D.S...")][Name("mpl2")]mpl2,

/// <summary>
/// PJS (Phoenix Japanimation Society) subtitle
/// </summary>
[CodecFlag("D.S...")][Name("pjs")]pjs,

/// <summary>
/// RealText subtitle
/// </summary>
[CodecFlag("D.S...")][Name("realtext")]realtext,

/// <summary>
/// SAMI subtitle
/// </summary>
[CodecFlag("D.S...")][Name("sami")]sami,

/// <summary>
/// SubRip subtitle with embedded timing
/// </summary>
[CodecFlag("..S...")][Name("srt")]srt,

/// <summary>
/// SSA (SubStation Alpha) subtitle
/// </summary>
[CodecFlag("..S...")][Name("ssa")]ssa,

/// <summary>
/// Spruce subtitle format
/// </summary>
[CodecFlag("D.S...")][Name("stl")]stl,

/// <summary>
/// SubRip subtitle (decoders: srt subrip) (encoders: srt subrip)
/// </summary>
[CodecFlag("DES...")][Name("subrip")]subrip,

/// <summary>
/// SubViewer subtitle
/// </summary>
[CodecFlag("D.S...")][Name("subviewer")]subviewer,

/// <summary>
/// SubViewer v1 subtitle
/// </summary>
[CodecFlag("D.S...")][Name("subviewer1")]subviewer1,

/// <summary>
/// raw UTF-8 text
/// </summary>
[CodecFlag("DES...")][Name("text")]text,

/// <summary>
/// Timed Text Markup Language
/// </summary>
[CodecFlag(".ES...")][Name("ttml")]ttml,

/// <summary>
/// VPlayer subtitle
/// </summary>
[CodecFlag("D.S...")][Name("vplayer")]vplayer,

/// <summary>
/// WebVTT subtitle
/// </summary>
[CodecFlag("DES...")][Name("webvtt")]webvtt,

/// <summary>
/// XSUB
/// </summary>
[CodecFlag("DES...")][Name("xsub")]xsub,

}
}
