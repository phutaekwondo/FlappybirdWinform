
namespace FlappyBird
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labDebug = new System.Windows.Forms.Label();
            this.labPoint = new System.Windows.Forms.Label();
            this.mediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.mediaPlayerHopSFX = new AxWMPLib.AxWindowsMediaPlayer();
            this.labTips = new System.Windows.Forms.Label();
            this.picLeaderboard = new System.Windows.Forms.PictureBox();
            this.picSettingIcon = new System.Windows.Forms.PictureBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.picDesktop = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picNextGround = new System.Windows.Forms.PictureBox();
            this.leaderBoardGeneral = new FlappyBird.LeaderBoard();
            this.gameOverInfoGeneral = new FlappyBird.GameOverInfo();
            this.gameSettingGeneral = new FlappyBird.GameSetting();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerHopSFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextGround)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // labDebug
            // 
            this.labDebug.AutoSize = true;
            this.labDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDebug.Location = new System.Drawing.Point(22, 22);
            this.labDebug.Name = "labDebug";
            this.labDebug.Size = new System.Drawing.Size(48, 18);
            this.labDebug.TabIndex = 3;
            this.labDebug.Text = "debug";
            // 
            // labPoint
            // 
            this.labPoint.AutoSize = true;
            this.labPoint.Font = new System.Drawing.Font("Norwester", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPoint.Location = new System.Drawing.Point(225, 57);
            this.labPoint.Name = "labPoint";
            this.labPoint.Size = new System.Drawing.Size(50, 58);
            this.labPoint.TabIndex = 5;
            this.labPoint.Text = "0";
            // 
            // mediaPlayerMusic
            // 
            this.mediaPlayerMusic.Enabled = true;
            this.mediaPlayerMusic.Location = new System.Drawing.Point(533, 56);
            this.mediaPlayerMusic.Name = "mediaPlayerMusic";
            this.mediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayerMusic.OcxState")));
            this.mediaPlayerMusic.Size = new System.Drawing.Size(108, 58);
            this.mediaPlayerMusic.TabIndex = 7;
            this.mediaPlayerMusic.Visible = false;
            // 
            // mediaPlayerHopSFX
            // 
            this.mediaPlayerHopSFX.Enabled = true;
            this.mediaPlayerHopSFX.Location = new System.Drawing.Point(533, 158);
            this.mediaPlayerHopSFX.Name = "mediaPlayerHopSFX";
            this.mediaPlayerHopSFX.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayerHopSFX.OcxState")));
            this.mediaPlayerHopSFX.Size = new System.Drawing.Size(108, 58);
            this.mediaPlayerHopSFX.TabIndex = 8;
            this.mediaPlayerHopSFX.Visible = false;
            // 
            // labTips
            // 
            this.labTips.AutoSize = true;
            this.labTips.Font = new System.Drawing.Font("Norwester", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTips.Location = new System.Drawing.Point(61, 599);
            this.labTips.Name = "labTips";
            this.labTips.Size = new System.Drawing.Size(374, 42);
            this.labTips.TabIndex = 9;
            this.labTips.Text = "press any key to play";
            // 
            // picLeaderboard
            // 
            this.picLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLeaderboard.Image = global::FlappyBird.Properties.Resources.leaderboard_icon;
            this.picLeaderboard.Location = new System.Drawing.Point(87, 706);
            this.picLeaderboard.Name = "picLeaderboard";
            this.picLeaderboard.Size = new System.Drawing.Size(45, 42);
            this.picLeaderboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeaderboard.TabIndex = 12;
            this.picLeaderboard.TabStop = false;
            this.picLeaderboard.Click += new System.EventHandler(this.picLeaderboard_Click);
            // 
            // picSettingIcon
            // 
            this.picSettingIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSettingIcon.Image = global::FlappyBird.Properties.Resources.settingIcon;
            this.picSettingIcon.Location = new System.Drawing.Point(25, 706);
            this.picSettingIcon.Name = "picSettingIcon";
            this.picSettingIcon.Size = new System.Drawing.Size(45, 42);
            this.picSettingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettingIcon.TabIndex = 11;
            this.picSettingIcon.TabStop = false;
            this.picSettingIcon.Click += new System.EventHandler(this.picSettingIcon_Click);
            // 
            // picBird
            // 
            this.picBird.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picBird.BackColor = System.Drawing.Color.Transparent;
            this.picBird.Image = global::FlappyBird.Properties.Resources.whaleDropingBlue;
            this.picBird.Location = new System.Drawing.Point(52, 306);
            this.picBird.Margin = new System.Windows.Forms.Padding(2);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(80, 48);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 2;
            this.picBird.TabStop = false;
            // 
            // picDesktop
            // 
            this.picDesktop.Image = global::FlappyBird.Properties.Resources.sky1;
            this.picDesktop.Location = new System.Drawing.Point(0, 0);
            this.picDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.picDesktop.Name = "picDesktop";
            this.picDesktop.Size = new System.Drawing.Size(501, 769);
            this.picDesktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDesktop.TabIndex = 0;
            this.picDesktop.TabStop = false;
            // 
            // picGround
            // 
            this.picGround.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.picGround.Location = new System.Drawing.Point(-100, 652);
            this.picGround.Margin = new System.Windows.Forms.Padding(2);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(501, 117);
            this.picGround.TabIndex = 1;
            this.picGround.TabStop = false;
            // 
            // picNextGround
            // 
            this.picNextGround.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picNextGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.picNextGround.Location = new System.Drawing.Point(25, 430);
            this.picNextGround.Margin = new System.Windows.Forms.Padding(2);
            this.picNextGround.Name = "picNextGround";
            this.picNextGround.Size = new System.Drawing.Size(501, 117);
            this.picNextGround.TabIndex = 4;
            this.picNextGround.TabStop = false;
            // 
            // leaderBoardGeneral
            // 
            this.leaderBoardGeneral.Location = new System.Drawing.Point(68, 85);
            this.leaderBoardGeneral.Name = "leaderBoardGeneral";
            this.leaderBoardGeneral.Size = new System.Drawing.Size(386, 562);
            this.leaderBoardGeneral.TabIndex = 13;
            this.leaderBoardGeneral.Visible = false;
            // 
            // gameOverInfoGeneral
            // 
            this.gameOverInfoGeneral.HighScore = "0";
            this.gameOverInfoGeneral.Location = new System.Drawing.Point(68, 173);
            this.gameOverInfoGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.gameOverInfoGeneral.Name = "gameOverInfoGeneral";
            this.gameOverInfoGeneral.Score = "0";
            this.gameOverInfoGeneral.Size = new System.Drawing.Size(359, 374);
            this.gameOverInfoGeneral.TabIndex = 6;
            this.gameOverInfoGeneral.Visible = false;
            // 
            // gameSettingGeneral
            // 
            this.gameSettingGeneral.BackgroundIndex = 1;
            this.gameSettingGeneral.Location = new System.Drawing.Point(43, 44);
            this.gameSettingGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.gameSettingGeneral.MusicVolumn = 50;
            this.gameSettingGeneral.Name = "gameSettingGeneral";
            this.gameSettingGeneral.PlayerName = "player";
            this.gameSettingGeneral.SFXVolumn = 15;
            this.gameSettingGeneral.Size = new System.Drawing.Size(425, 635);
            this.gameSettingGeneral.SkinIndex = 0;
            this.gameSettingGeneral.TabIndex = 10;
            this.gameSettingGeneral.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 769);
            this.Controls.Add(this.gameSettingGeneral);
            this.Controls.Add(this.leaderBoardGeneral);
            this.Controls.Add(this.picLeaderboard);
            this.Controls.Add(this.gameOverInfoGeneral);
            this.Controls.Add(this.picSettingIcon);
            this.Controls.Add(this.labTips);
            this.Controls.Add(this.mediaPlayerHopSFX);
            this.Controls.Add(this.mediaPlayerMusic);
            this.Controls.Add(this.labPoint);
            this.Controls.Add(this.labDebug);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.picDesktop);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picNextGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "Floating Whale";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerHopSFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDesktop;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labDebug;
        private System.Windows.Forms.PictureBox picNextGround;
        private System.Windows.Forms.Label labPoint;
        private GameOverInfo gameOverInfoGeneral;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayerMusic;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayerHopSFX;
        private System.Windows.Forms.Label labTips;
        private GameSetting gameSettingGeneral;
        private System.Windows.Forms.PictureBox picSettingIcon;
        private System.Windows.Forms.PictureBox picLeaderboard;
        private LeaderBoard leaderBoardGeneral;
    }
}

