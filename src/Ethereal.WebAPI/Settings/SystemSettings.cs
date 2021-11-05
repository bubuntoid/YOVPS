﻿using System;
using System.IO;
using Ethereal.Application;
using Microsoft.Extensions.Configuration;

namespace Ethereal.WebAPI.Settings
{
    public class SystemSettings : SettingsBase, IEtherealSettings
    {
        public string TempPath => GetValue<string>("TempPath")
            .Replace("{current}", Directory.GetCurrentDirectory());

        public string FfmpegExecutablesPath => GetValue<string>("FfmpegExecutablesPath")
            .Replace("{current}", Directory.GetCurrentDirectory());

        public string YtdlpExecutablesPath => GetValue<string>("YtdlpExecutablesPath")
            .Replace("{current}", Directory.GetCurrentDirectory());


        public TimeSpan VideoDurationLimit => GetValue<TimeSpan>("VideoDurationLimit");

        public TimeSpan DownloadingTimeout => GetValue<TimeSpan>("DownloadingTimeout");

        public string YouTubeProvider => GetValue<string>("YouTubeProvider");

        public SystemSettings(IConfiguration config)
            : base(config, "System")
        {
        }
    }
}