﻿namespace Sifon.Abstractions.Profiles
{
    public interface ICrashDetails //TODO: rename
    {
        bool UseDownloadCDN { get; set; }
        bool SendCrashDetails { get; set; }
        string PluginsRepository { get; set; }
        string CustomPluginsFolder { get; set; }
        bool AlignVersions{ get; set; }
    }
}
