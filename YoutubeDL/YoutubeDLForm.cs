using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Converter;
using System.Net.Http;
using System.Drawing.Imaging;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Exceptions;

namespace YoutubeDL;
#nullable disable
public partial class YoutubeDLForm : Form
{
    private HttpClient Client { get; } = new();
    private YoutubeClient YtClient { get; } = new();

    private readonly string imageDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}/images/";
    private readonly string imageEndpoint = "https://img.youtube.com/vi/{0}/maxresdefault.jpg";


    private readonly Dictionary<string, string> _imageCache = new();

    public YoutubeDLForm()
    {
        InitializeComponent();
        Init();
    }

    private void Init()
    {
        downloadButton.Enabled = false;
        thumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
        thumbnail.BorderStyle = BorderStyle.FixedSingle;
        includeAudio.Checked = true;
        includeVideo.Checked = true;
        audioPath.Text = $"Audio Path: {Config.Audio}";
        videoPath.Text = $"Video Path: {Config.Video}";
    }

    private async void DownloadButton_OnClick(object sender, EventArgs e)
    {
        var video = await YtClient.Videos.GetAsync(urlBox.Text);
        var manifest = await YtClient.Videos.Streams.GetManifestAsync(video.Id);

        if (!includeVideo.Checked)
        {
            var streamInfo = manifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            await YtClient.Videos.Streams.DownloadAsync(streamInfo, @$"{Config.Audio}\{video.Title.Trim()}.{streamInfo.Container}");
        }
    }
    private async Task<string> DownloadAndSaveImage(string videoId)
    {
        string thumbUrl = string.Format(imageEndpoint, videoId);
        if (!Directory.Exists(imageDirectory))
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory(imageDirectory);
            directoryInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
        }
        var check = await Client.GetAsync(thumbUrl);

        if (!check.IsSuccessStatusCode)
        {
            return null;
        }

        byte[] array = await Client.GetByteArrayAsync(thumbUrl);

        using var stream = new MemoryStream(array);
        using var image = Image.FromStream(stream);

        var path = $"{imageDirectory}{Guid.NewGuid()}.jpg";
        image.Save(path, ImageFormat.Jpeg);

        return path;
    }
    private void ResetLayout()
    {
        downloadButton.Enabled = false;
        thumbnail.Image = null;
        title.Hide();
    }

    private async void UrlText_OnChanged(object sender, EventArgs e)
    {
        if (!urlBox.Text.IsYoutubeUrl())
        {
            ResetLayout();
            return;
        }

        downloadButton.Enabled = true;

        Video video;

        try
        {
             video = await YtClient.Videos.GetAsync(urlBox.Text);
        }
        catch (VideoUnavailableException ex)
        {
            ResetLayout();
            MessageBox.Show(ex.Message, "Video is not available");
            return;
        }
        catch (ArgumentException)
        {
            ResetLayout();
            return;
        }
        title.Show();

        title.Text = video.Title.BreakStringToMultiline();
        
        if (_imageCache.ContainsKey(video.Id.Value))
        {
            thumbnail.Image = Image.FromFile(_imageCache[video.Id.Value]);
        }
        else
        {
            string path = await DownloadAndSaveImage(video.Id.Value);

            if (path is not null)
            {
                _imageCache.Add(video.Id.Value, path);
                thumbnail.Image = Image.FromFile(path);
            }
        }
    }

    private void IncludeAudio_OnCheck(object sender, EventArgs e)
    {
        if (!includeAudio.Checked && !includeVideo.Checked)
        {
            includeAudio.Checked = true;
        }
        if (!includeAudio.Checked && includeVideo.Checked)
        {
            includeAudio.Checked = true;
        }
    }

    private void IncludeVideo_OnCheck(object sender, EventArgs e)
    {
        if (!includeAudio.Checked && !includeVideo.Checked)
        {
            includeAudio.Checked = true;
        }
    }

    private void ChangeVideoPath_Click(object sender, EventArgs e)
    {
        var dialog = new FolderBrowserDialog
        {
            ShowNewFolderButton = true
        };
        
        dialog.ShowDialog();

        if (dialog.SelectedPath is null)
        {
            return;
        }

        if (Directory.Exists(dialog.SelectedPath))
        {
            Config.Video = dialog.SelectedPath;
            videoPath.Text = $"Video Path: {Config.Video}";
            return;
        }
    }

    private void ChangeAudioPath_Click(object sender, EventArgs e)
    {
        var dialog = new FolderBrowserDialog
        {
            ShowNewFolderButton = true
        };
        dialog.ShowDialog();
        if (dialog.SelectedPath is null)
        {
            return;
        }
        if (Directory.Exists(dialog.SelectedPath))
        {
            Config.Audio = dialog.SelectedPath;
            audioPath.Text = $"Audio Path: {Config.Audio}";
            return;
        }
    }
}