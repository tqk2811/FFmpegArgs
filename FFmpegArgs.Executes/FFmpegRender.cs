﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FFmpegArgs.Executes
{
    public class FFmpegRender
    {
        
        public event Action<RenderProgress> OnEncodingProgress;
        public event Action<string> OnOutputDataReceived;
        
        public FFmpegRenderConfig Config { get; }
        
        internal FFmpegRender(FFmpegRenderConfig config)
        {
            Config = config;
        }

        public string Arguments { get; private set; }

        internal void ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (OnEncodingProgress != null)
            {
                RenderProgress progress = RenderProgress.FromProgressString(e.Data);
                if (progress != null) OnEncodingProgress?.Invoke(progress);
            }
        }

        internal void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OnOutputDataReceived?.Invoke(e?.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArgument(FFmpegArg ffmpegArg, Action<FFmpegRenderConfig> config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegRenderConfig buildConfig = new FFmpegRenderConfig();
            config.Invoke(buildConfig);
            return FromArgument(ffmpegArg, buildConfig);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArgument(FFmpegArg ffmpegArg, FFmpegRenderConfig config)
        {
            if (ffmpegArg == null) throw new ArgumentNullException(nameof(ffmpegArg));
            if (config == null) throw new ArgumentNullException(nameof(config));

            FFmpegRender fFmpegBuild = new FFmpegRender(config);
            string args = ffmpegArg.GetFullCommandline();
            if (config.IsForceUseScript || args.Length > config.ArgumentsMaxLength)
            {
                string scripts = ffmpegArg.FilterGraph.GetFiltersArgs(true, true);
                if(string.IsNullOrWhiteSpace(scripts)) throw new ProcessArgumentOutOfRangeException($"{nameof(FFmpegArg)} argument too long");

                File.WriteAllText(Path.Combine(config.WorkingDirectory, config.FilterScriptName), scripts);
                fFmpegBuild.Arguments = ffmpegArg.GetFullCommandlineWithFilterScript(config.FilterScriptName);

                if (fFmpegBuild.Arguments.Length > config.ArgumentsMaxLength) throw new ProcessArgumentOutOfRangeException($"{nameof(FFmpegArg)} argument too long");
            }
            else fFmpegBuild.Arguments = args;
            return fFmpegBuild;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArgument(string commands, FFmpegRenderConfig config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));
            if (commands.Length > config.ArgumentsMaxLength) throw new ProcessArgumentOutOfRangeException($"{nameof(commands)} too long");

            return new FFmpegRender(config)
            {
                Arguments = commands
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ProcessArgumentOutOfRangeException"></exception>
        public static FFmpegRender FromArgument(string commands, Action<FFmpegRenderConfig> config)
        {
            if (string.IsNullOrWhiteSpace(commands)) throw new ArgumentNullException(nameof(commands));
            if (config == null) throw new ArgumentNullException(nameof(config));            

            FFmpegRenderConfig buildConfig = new FFmpegRenderConfig();
            config.Invoke(buildConfig);
            return FromArgument(commands, buildConfig);
        }
    }
}
