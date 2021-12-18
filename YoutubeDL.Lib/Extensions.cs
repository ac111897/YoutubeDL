using System.Text;

namespace YoutubeDL.Lib;

public static class Extensions
{
    public static bool IsYoutubeUrl(this string url)
    {
        ArgumentNullException.ThrowIfNull(url, nameof(url));
        if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
        {
            return false;
        }
        if (url.EndsWith("youtube.com") || url.EndsWith("youtube.com/"))
        {
            return false;
        }
        if (url.EndsWith("//"))
        {
            return false;
        }
        Uri uri = new(url);
        string host = uri.Host;

        return host switch
        {
            "www.youtu.be" or "www.youtube.com" or "youtu.be" or "youtube.com" => true,
            _ => false,
        };
    }
    private const int MaxPerLine = 28;
    public static string BreakStringToMultiline(this string value)
    {
        if (value.Length <= MaxPerLine)
        {
            return value;
        }

        StringBuilder sb = new(value.Length + 1);
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == value.Length-1)
            {
                sb.Append(Environment.NewLine);
            }
            sb.Append(value[i]);
        }
        return sb.ToString();
    }
}