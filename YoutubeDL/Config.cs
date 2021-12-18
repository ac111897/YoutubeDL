using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.Windows.IO;
namespace YoutubeDL;
#nullable disable
internal static class Config
{
    private static Configuration _configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    public static string Audio
    {
        set
        {
            _configuration.AppSettings.Settings[nameof(Audio)].Value = value;
            _configuration.Save(ConfigurationSaveMode.Modified);
        }
        get
        {

            return ActualOrDefault(_configuration.AppSettings.Settings[nameof(Audio)].Value);
        }
    }
    public static string Video
    {
        set
        {
            _configuration.AppSettings.Settings[nameof(Video)].Value = value;
            _configuration.Save(ConfigurationSaveMode.Modified);
        }
        get
        {
            return ActualOrDefault(_configuration.AppSettings.Settings[nameof(Video)].Value);
        }
    }
    private static string ActualOrDefault(string path)
    {
        if (path == "empty")
        {
            return new KnownFolder(KnownFolderType.Downloads).Path;
        }
        return path;
    }
}
