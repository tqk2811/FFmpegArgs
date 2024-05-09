namespace FFmpegArgs.Cores.Enums
{
/// <summary>
/// </summary>
public enum MuxingFileFormat
{
/// <summary>
/// 3GP2 (3GPP2 file format)
/// </summary>
[Name("3g2")]
_3g2,

/// <summary>
/// 3GP (3GPP file format)
/// </summary>
[Name("3gp")]
_3gp,

/// <summary>
/// a64 - video for Commodore 64
/// </summary>
[Name("a64")]
a64,

/// <summary>
/// raw AC-3
/// </summary>
[Name("ac3")]
ac3,

/// <summary>
/// raw AC-4
/// </summary>
[Name("ac4")]
ac4,

/// <summary>
/// ADTS AAC (Advanced Audio Coding)
/// </summary>
[Name("adts")]
adts,

/// <summary>
/// CRI ADX
/// </summary>
[Name("adx")]
adx,

/// <summary>
/// Audio IFF
/// </summary>
[Name("aiff")]
aiff,

/// <summary>
/// PCM A-law
/// </summary>
[Name("alaw")]
alaw,

/// <summary>
/// LEGO Racers ALP
/// </summary>
[Name("alp")]
alp,

/// <summary>
/// 3GPP AMR
/// </summary>
[Name("amr")]
amr,

/// <summary>
/// AMV
/// </summary>
[Name("amv")]
amv,

/// <summary>
/// Ubisoft Rayman 2 APM
/// </summary>
[Name("apm")]
apm,

/// <summary>
/// Animated Portable Network Graphics
/// </summary>
[Name("apng")]
apng,

/// <summary>
/// raw aptX (Audio Processing Technology for Bluetooth)
/// </summary>
[Name("aptx")]
aptx,

/// <summary>
/// raw aptX HD (Audio Processing Technology for Bluetooth)
/// </summary>
[Name("aptx_hd")]
aptx_hd,

/// <summary>
/// Argonaut Games ASF
/// </summary>
[Name("argo_asf")]
argo_asf,

/// <summary>
/// Argonaut Games CVG
/// </summary>
[Name("argo_cvg")]
argo_cvg,

/// <summary>
/// ASF (Advanced / Active Streaming Format)
/// </summary>
[Name("asf")]
asf,

/// <summary>
/// ASF (Advanced / Active Streaming Format)
/// </summary>
[Name("asf_stream")]
asf_stream,

/// <summary>
/// SSA (SubStation Alpha) subtitle
/// </summary>
[Name("ass")]
ass,

/// <summary>
/// AST (Audio Stream)
/// </summary>
[Name("ast")]
ast,

/// <summary>
/// Sun AU
/// </summary>
[Name("au")]
au,

/// <summary>
/// AVI (Audio Video Interleaved)
/// </summary>
[Name("avi")]
avi,

/// <summary>
/// AVIF
/// </summary>
[Name("avif")]
avif,

/// <summary>
/// SWF (ShockWave Flash) (AVM2)
/// </summary>
[Name("avm2")]
avm2,

/// <summary>
/// raw AVS2-P2/IEEE1857.4 video
/// </summary>
[Name("avs2")]
avs2,

/// <summary>
/// AVS3-P2/IEEE1857.10
/// </summary>
[Name("avs3")]
avs3,

/// <summary>
/// G.729 BIT file format
/// </summary>
[Name("bit")]
bit,

/// <summary>
/// Apple CAF (Core Audio Format)
/// </summary>
[Name("caf")]
caf,

/// <summary>
/// raw Chinese AVS (Audio Video Standard) video
/// </summary>
[Name("cavsvideo")]
cavsvideo,

/// <summary>
/// Chromaprint
/// </summary>
[Name("chromaprint")]
chromaprint,

/// <summary>
/// codec2 .c2 muxer
/// </summary>
[Name("codec2")]
codec2,

/// <summary>
/// raw codec2 muxer
/// </summary>
[Name("codec2raw")]
codec2raw,

/// <summary>
/// CRC testing
/// </summary>
[Name("crc")]
crc,

/// <summary>
/// DASH Muxer
/// </summary>
[Name("dash")]
dash,

/// <summary>
/// raw data
/// </summary>
[Name("data")]
data,

/// <summary>
/// D-Cinema audio
/// </summary>
[Name("daud")]
daud,

/// <summary>
/// raw DFPWM1a
/// </summary>
[Name("dfpwm")]
dfpwm,

/// <summary>
/// raw Dirac
/// </summary>
[Name("dirac")]
dirac,

/// <summary>
/// raw DNxHD (SMPTE VC-3)
/// </summary>
[Name("dnxhd")]
dnxhd,

/// <summary>
/// raw DTS
/// </summary>
[Name("dts")]
dts,

/// <summary>
/// DV (Digital Video)
/// </summary>
[Name("dv")]
dv,

/// <summary>
/// MPEG-2 PS (DVD VOB)
/// </summary>
[Name("dvd")]
dvd,

/// <summary>
/// raw E-AC-3
/// </summary>
[Name("eac3")]
eac3,

/// <summary>
/// raw EVC video
/// </summary>
[Name("evc")]
evc,

/// <summary>
/// PCM 32-bit floating-point big-endian
/// </summary>
[Name("f32be")]
f32be,

/// <summary>
/// PCM 32-bit floating-point little-endian
/// </summary>
[Name("f32le")]
f32le,

/// <summary>
/// F4V Adobe Flash Video
/// </summary>
[Name("f4v")]
f4v,

/// <summary>
/// PCM 64-bit floating-point big-endian
/// </summary>
[Name("f64be")]
f64be,

/// <summary>
/// PCM 64-bit floating-point little-endian
/// </summary>
[Name("f64le")]
f64le,

/// <summary>
/// FFmpeg metadata in text
/// </summary>
[Name("ffmetadata")]
ffmetadata,

/// <summary>
/// FIFO queue pseudo-muxer
/// </summary>
[Name("fifo")]
fifo,

/// <summary>
/// Fifo test muxer
/// </summary>
[Name("fifo_test")]
fifo_test,

/// <summary>
/// Sega FILM / CPK
/// </summary>
[Name("film_cpk")]
film_cpk,

/// <summary>
/// Adobe Filmstrip
/// </summary>
[Name("filmstrip")]
filmstrip,

/// <summary>
/// Flexible Image Transport System
/// </summary>
[Name("fits")]
fits,

/// <summary>
/// raw FLAC
/// </summary>
[Name("flac")]
flac,

/// <summary>
/// FLV (Flash Video)
/// </summary>
[Name("flv")]
flv,

/// <summary>
/// framecrc testing
/// </summary>
[Name("framecrc")]
framecrc,

/// <summary>
/// Per-frame hash testing
/// </summary>
[Name("framehash")]
framehash,

/// <summary>
/// Per-frame MD5 testing
/// </summary>
[Name("framemd5")]
framemd5,

/// <summary>
/// raw G.722
/// </summary>
[Name("g722")]
g722,

/// <summary>
/// raw G.723.1
/// </summary>
[Name("g723_1")]
g723_1,

/// <summary>
/// raw big-endian G.726 ("left-justified")
/// </summary>
[Name("g726")]
g726,

/// <summary>
/// raw little-endian G.726 ("right-justified")
/// </summary>
[Name("g726le")]
g726le,

/// <summary>
/// CompuServe Graphics Interchange Format (GIF)
/// </summary>
[Name("gif")]
gif,

/// <summary>
/// raw GSM
/// </summary>
[Name("gsm")]
gsm,

/// <summary>
/// GXF (General eXchange Format)
/// </summary>
[Name("gxf")]
gxf,

/// <summary>
/// raw H.261
/// </summary>
[Name("h261")]
h261,

/// <summary>
/// raw H.263
/// </summary>
[Name("h263")]
h263,

/// <summary>
/// raw H.264 video
/// </summary>
[Name("h264")]
h264,

/// <summary>
/// Hash testing
/// </summary>
[Name("hash")]
hash,

/// <summary>
/// HDS Muxer
/// </summary>
[Name("hds")]
hds,

/// <summary>
/// raw HEVC video
/// </summary>
[Name("hevc")]
hevc,

/// <summary>
/// Apple HTTP Live Streaming
/// </summary>
[Name("hls")]
hls,

/// <summary>
/// Microsoft Windows ICO
/// </summary>
[Name("ico")]
ico,

/// <summary>
/// iLBC storage
/// </summary>
[Name("ilbc")]
ilbc,

/// <summary>
/// image2 sequence
/// </summary>
[Name("image2")]
image2,

/// <summary>
/// piped image2 sequence
/// </summary>
[Name("image2pipe")]
image2pipe,

/// <summary>
/// iPod H.264 MP4 (MPEG-4 Part 14)
/// </summary>
[Name("ipod")]
ipod,

/// <summary>
/// Berkeley/IRCAM/CARL Sound Format
/// </summary>
[Name("ircam")]
ircam,

/// <summary>
/// ISMV/ISMA (Smooth Streaming)
/// </summary>
[Name("ismv")]
ismv,

/// <summary>
/// On2 IVF
/// </summary>
[Name("ivf")]
ivf,

/// <summary>
/// JACOsub subtitle format
/// </summary>
[Name("jacosub")]
jacosub,

/// <summary>
/// Simon &amp; Schuster Interactive VAG
/// </summary>
[Name("kvag")]
kvag,

/// <summary>
/// LOAS/LATM
/// </summary>
[Name("latm")]
latm,

/// <summary>
/// LRC lyrics
/// </summary>
[Name("lrc")]
lrc,

/// <summary>
/// raw MPEG-4 video
/// </summary>
[Name("m4v")]
m4v,

/// <summary>
/// Matroska
/// </summary>
[Name("matroska")]
matroska,

/// <summary>
/// MD5 testing
/// </summary>
[Name("md5")]
md5,

/// <summary>
/// MicroDVD subtitle format
/// </summary>
[Name("microdvd")]
microdvd,

/// <summary>
/// raw MJPEG video
/// </summary>
[Name("mjpeg")]
mjpeg,

/// <summary>
/// extract pts as timecode v2 format, as defined by mkvtoolnix
/// </summary>
[Name("mkvtimestamp_v2")]
mkvtimestamp_v2,

/// <summary>
/// raw MLP
/// </summary>
[Name("mlp")]
mlp,

/// <summary>
/// Yamaha SMAF
/// </summary>
[Name("mmf")]
mmf,

/// <summary>
/// QuickTime / MOV
/// </summary>
[Name("mov")]
mov,

/// <summary>
/// MP2 (MPEG audio layer 2)
/// </summary>
[Name("mp2")]
mp2,

/// <summary>
/// MP3 (MPEG audio layer 3)
/// </summary>
[Name("mp3")]
mp3,

/// <summary>
/// MP4 (MPEG-4 Part 14)
/// </summary>
[Name("mp4")]
mp4,

/// <summary>
/// MPEG-1 Systems / MPEG program stream
/// </summary>
[Name("mpeg")]
mpeg,

/// <summary>
/// raw MPEG-1 video
/// </summary>
[Name("mpeg1video")]
mpeg1video,

/// <summary>
/// raw MPEG-2 video
/// </summary>
[Name("mpeg2video")]
mpeg2video,

/// <summary>
/// MPEG-TS (MPEG-2 Transport Stream)
/// </summary>
[Name("mpegts")]
mpegts,

/// <summary>
/// MIME multipart JPEG
/// </summary>
[Name("mpjpeg")]
mpjpeg,

/// <summary>
/// PCM mu-law
/// </summary>
[Name("mulaw")]
mulaw,

/// <summary>
/// MXF (Material eXchange Format)
/// </summary>
[Name("mxf")]
mxf,

/// <summary>
/// MXF (Material eXchange Format) D-10 Mapping
/// </summary>
[Name("mxf_d10")]
mxf_d10,

/// <summary>
/// MXF (Material eXchange Format) Operational Pattern Atom
/// </summary>
[Name("mxf_opatom")]
mxf_opatom,

/// <summary>
/// raw null video
/// </summary>
[Name("null")]
_null,

/// <summary>
/// NUT
/// </summary>
[Name("nut")]
nut,

/// <summary>
/// AV1 low overhead OBU
/// </summary>
[Name("obu")]
obu,

/// <summary>
/// Ogg Audio
/// </summary>
[Name("oga")]
oga,

/// <summary>
/// Ogg
/// </summary>
[Name("ogg")]
ogg,

/// <summary>
/// Ogg Video
/// </summary>
[Name("ogv")]
ogv,

/// <summary>
/// Sony OpenMG audio
/// </summary>
[Name("oma")]
oma,

/// <summary>
/// Ogg Opus
/// </summary>
[Name("opus")]
opus,

/// <summary>
/// PSP MP4 (MPEG-4 Part 14)
/// </summary>
[Name("psp")]
psp,

/// <summary>
/// raw video
/// </summary>
[Name("rawvideo")]
rawvideo,

/// <summary>
/// RealMedia
/// </summary>
[Name("rm")]
rm,

/// <summary>
/// raw id RoQ
/// </summary>
[Name("roq")]
roq,

/// <summary>
/// Lego Mindstorms RSO
/// </summary>
[Name("rso")]
rso,

/// <summary>
/// RTP output
/// </summary>
[Name("rtp")]
rtp,

/// <summary>
/// RTP/mpegts output format
/// </summary>
[Name("rtp_mpegts")]
rtp_mpegts,

/// <summary>
/// RTSP output
/// </summary>
[Name("rtsp")]
rtsp,

/// <summary>
/// PCM signed 16-bit big-endian
/// </summary>
[Name("s16be")]
s16be,

/// <summary>
/// PCM signed 16-bit little-endian
/// </summary>
[Name("s16le")]
s16le,

/// <summary>
/// PCM signed 24-bit big-endian
/// </summary>
[Name("s24be")]
s24be,

/// <summary>
/// PCM signed 24-bit little-endian
/// </summary>
[Name("s24le")]
s24le,

/// <summary>
/// PCM signed 32-bit big-endian
/// </summary>
[Name("s32be")]
s32be,

/// <summary>
/// PCM signed 32-bit little-endian
/// </summary>
[Name("s32le")]
s32le,

/// <summary>
/// PCM signed 8-bit
/// </summary>
[Name("s8")]
s8,

/// <summary>
/// SAP output
/// </summary>
[Name("sap")]
sap,

/// <summary>
/// raw SBC
/// </summary>
[Name("sbc")]
sbc,

/// <summary>
/// Scenarist Closed Captions
/// </summary>
[Name("scc")]
scc,

/// <summary>
/// SDL2 output device
/// </summary>
[Name("sdl")]
sdl,

/// <summary>
/// SDL2 output device
/// </summary>
[Name("sdl2")]
sdl2,

/// <summary>
/// segment
/// </summary>
[Name("segment")]
segment,

/// <summary>
/// Loki SDL MJPEG
/// </summary>
[Name("smjpeg")]
smjpeg,

/// <summary>
/// Smooth Streaming Muxer
/// </summary>
[Name("smoothstreaming")]
smoothstreaming,

/// <summary>
/// SoX (Sound eXchange) native
/// </summary>
[Name("sox")]
sox,

/// <summary>
/// IEC 61937 (used on S/PDIF - IEC958)
/// </summary>
[Name("spdif")]
spdif,

/// <summary>
/// Ogg Speex
/// </summary>
[Name("spx")]
spx,

/// <summary>
/// SubRip subtitle
/// </summary>
[Name("srt")]
srt,

/// <summary>
/// streaming segment muxer
/// </summary>
[Name("stream_segment")]
stream_segment,

/// <summary>
/// streaming segment muxer
/// </summary>
[Name("ssegment")]
ssegment,

/// <summary>
/// Per-stream hash testing
/// </summary>
[Name("streamhash")]
streamhash,

/// <summary>
/// raw HDMV Presentation Graphic Stream subtitles
/// </summary>
[Name("sup")]
sup,

/// <summary>
/// MPEG-2 PS (SVCD)
/// </summary>
[Name("svcd")]
svcd,

/// <summary>
/// SWF (ShockWave Flash)
/// </summary>
[Name("swf")]
swf,

/// <summary>
/// Multiple muxer tee
/// </summary>
[Name("tee")]
tee,

/// <summary>
/// raw TrueHD
/// </summary>
[Name("truehd")]
truehd,

/// <summary>
/// TTA (True Audio)
/// </summary>
[Name("tta")]
tta,

/// <summary>
/// TTML subtitle
/// </summary>
[Name("ttml")]
ttml,

/// <summary>
/// PCM unsigned 16-bit big-endian
/// </summary>
[Name("u16be")]
u16be,

/// <summary>
/// PCM unsigned 16-bit little-endian
/// </summary>
[Name("u16le")]
u16le,

/// <summary>
/// PCM unsigned 24-bit big-endian
/// </summary>
[Name("u24be")]
u24be,

/// <summary>
/// PCM unsigned 24-bit little-endian
/// </summary>
[Name("u24le")]
u24le,

/// <summary>
/// PCM unsigned 32-bit big-endian
/// </summary>
[Name("u32be")]
u32be,

/// <summary>
/// PCM unsigned 32-bit little-endian
/// </summary>
[Name("u32le")]
u32le,

/// <summary>
/// PCM unsigned 8-bit
/// </summary>
[Name("u8")]
u8,

/// <summary>
/// uncoded framecrc testing
/// </summary>
[Name("uncodedframecrc")]
uncodedframecrc,

/// <summary>
/// raw VC-1 video
/// </summary>
[Name("vc1")]
vc1,

/// <summary>
/// VC-1 test bitstream
/// </summary>
[Name("vc1test")]
vc1test,

/// <summary>
/// MPEG-1 Systems / MPEG program stream (VCD)
/// </summary>
[Name("vcd")]
vcd,

/// <summary>
/// PCM Archimedes VIDC
/// </summary>
[Name("vidc")]
vidc,

/// <summary>
/// MPEG-2 PS (VOB)
/// </summary>
[Name("vob")]
vob,

/// <summary>
/// Creative Voice
/// </summary>
[Name("voc")]
voc,

/// <summary>
/// raw H.266/VVC video
/// </summary>
[Name("vvc")]
vvc,

/// <summary>
/// Sony Wave64
/// </summary>
[Name("w64")]
w64,

/// <summary>
/// WAV / WAVE (Waveform Audio)
/// </summary>
[Name("wav")]
wav,

/// <summary>
/// WebM
/// </summary>
[Name("webm")]
webm,

/// <summary>
/// WebM Chunk Muxer
/// </summary>
[Name("webm_chunk")]
webm_chunk,

/// <summary>
/// WebM DASH Manifest
/// </summary>
[Name("webm_dash_manifest")]
webm_dash_manifest,

/// <summary>
/// WebP
/// </summary>
[Name("webp")]
webp,

/// <summary>
/// WebVTT subtitle
/// </summary>
[Name("webvtt")]
webvtt,

/// <summary>
/// Westwood Studios audio
/// </summary>
[Name("wsaud")]
wsaud,

/// <summary>
/// Windows Television (WTV)
/// </summary>
[Name("wtv")]
wtv,

/// <summary>
/// raw WavPack
/// </summary>
[Name("wv")]
wv,

/// <summary>
/// YUV4MPEG pipe
/// </summary>
[Name("yuv4mpegpipe")]
yuv4mpegpipe,

}
}
