namespace YoutubeDL
{
    partial class YoutubeDLForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeDLForm));
            this.urlBox = new System.Windows.Forms.RichTextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.includeVideo = new System.Windows.Forms.CheckBox();
            this.includeAudio = new System.Windows.Forms.CheckBox();
            this.audioPath = new System.Windows.Forms.Label();
            this.videoPath = new System.Windows.Forms.Label();
            this.changeVideoPath = new System.Windows.Forms.Button();
            this.changeAudioPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urlBox.Location = new System.Drawing.Point(12, 33);
            this.urlBox.Multiline = false;
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(776, 36);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "";
            this.urlBox.TextChanged += new System.EventHandler(this.UrlText_OnChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urlLabel.Location = new System.Drawing.Point(12, 5);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(56, 25);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL:";
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadButton.Location = new System.Drawing.Point(12, 378);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(262, 56);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_OnClick);
            // 
            // thumbnail
            // 
            this.thumbnail.Location = new System.Drawing.Point(12, 98);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(384, 216);
            this.thumbnail.TabIndex = 3;
            this.thumbnail.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(402, 98);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(25, 29);
            this.title.TabIndex = 4;
            this.title.Text = "..";
            // 
            // includeVideo
            // 
            this.includeVideo.AutoSize = true;
            this.includeVideo.Location = new System.Drawing.Point(12, 339);
            this.includeVideo.Name = "includeVideo";
            this.includeVideo.Size = new System.Drawing.Size(56, 19);
            this.includeVideo.TabIndex = 5;
            this.includeVideo.Text = "Video";
            this.includeVideo.UseVisualStyleBackColor = true;
            this.includeVideo.CheckedChanged += new System.EventHandler(this.IncludeVideo_OnCheck);
            // 
            // includeAudio
            // 
            this.includeAudio.AutoSize = true;
            this.includeAudio.Location = new System.Drawing.Point(74, 339);
            this.includeAudio.Name = "includeAudio";
            this.includeAudio.Size = new System.Drawing.Size(58, 19);
            this.includeAudio.TabIndex = 6;
            this.includeAudio.Text = "Audio";
            this.includeAudio.UseVisualStyleBackColor = true;
            this.includeAudio.CheckedChanged += new System.EventHandler(this.IncludeAudio_OnCheck);
            // 
            // audioPath
            // 
            this.audioPath.AutoSize = true;
            this.audioPath.Location = new System.Drawing.Point(319, 415);
            this.audioPath.Name = "audioPath";
            this.audioPath.Size = new System.Drawing.Size(110, 15);
            this.audioPath.TabIndex = 7;
            this.audioPath.Text = "Audio Path: Default";
            // 
            // videoPath
            // 
            this.videoPath.AutoSize = true;
            this.videoPath.Location = new System.Drawing.Point(319, 382);
            this.videoPath.Name = "videoPath";
            this.videoPath.Size = new System.Drawing.Size(108, 15);
            this.videoPath.TabIndex = 8;
            this.videoPath.Text = "Video Path: Default";
            // 
            // changeVideoPath
            // 
            this.changeVideoPath.Location = new System.Drawing.Point(287, 378);
            this.changeVideoPath.Name = "changeVideoPath";
            this.changeVideoPath.Size = new System.Drawing.Size(26, 23);
            this.changeVideoPath.TabIndex = 9;
            this.changeVideoPath.Text = "..";
            this.changeVideoPath.UseVisualStyleBackColor = true;
            this.changeVideoPath.Click += new System.EventHandler(this.ChangeVideoPath_Click);
            // 
            // changeAudioPath
            // 
            this.changeAudioPath.Location = new System.Drawing.Point(287, 411);
            this.changeAudioPath.Name = "changeAudioPath";
            this.changeAudioPath.Size = new System.Drawing.Size(26, 23);
            this.changeAudioPath.TabIndex = 10;
            this.changeAudioPath.Text = "..";
            this.changeAudioPath.UseVisualStyleBackColor = true;
            this.changeAudioPath.Click += new System.EventHandler(this.ChangeAudioPath_Click);
            // 
            // YoutubeDLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.changeAudioPath);
            this.Controls.Add(this.changeVideoPath);
            this.Controls.Add(this.videoPath);
            this.Controls.Add(this.audioPath);
            this.Controls.Add(this.includeAudio);
            this.Controls.Add(this.includeVideo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.thumbnail);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "YoutubeDLForm";
            this.Text = "YoutubeDL by paradox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox urlBox;
        private Label urlLabel;
        private Button downloadButton;
        private PictureBox thumbnail;
        private Label title;
        private CheckBox includeVideo;
        private CheckBox includeAudio;
        private Label audioPath;
        private Label videoPath;
        private Button changeVideoPath;
        private Button changeAudioPath;
    }
}