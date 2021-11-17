
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
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picDesktop = new System.Windows.Forms.PictureBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            this.SuspendLayout();
            // 
            // picGround
            // 
            this.picGround.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.picGround.Location = new System.Drawing.Point(0, 593);
            this.picGround.Margin = new System.Windows.Forms.Padding(2);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(501, 117);
            this.picGround.TabIndex = 1;
            this.picGround.TabStop = false;
            // 
            // picDesktop
            // 
            this.picDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDesktop.Image = global::FlappyBird.Properties.Resources.sky;
            this.picDesktop.Location = new System.Drawing.Point(0, 0);
            this.picDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.picDesktop.Name = "picDesktop";
            this.picDesktop.Size = new System.Drawing.Size(501, 620);
            this.picDesktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDesktop.TabIndex = 0;
            this.picDesktop.TabStop = false;
            // 
            // picBird
            // 
            this.picBird.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBird.BackColor = System.Drawing.Color.Transparent;
            this.picBird.Image = global::FlappyBird.Properties.Resources.birdscaled;
            this.picBird.Location = new System.Drawing.Point(55, 300);
            this.picBird.Margin = new System.Windows.Forms.Padding(2);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(66, 48);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 2;
            this.picBird.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 710);
            this.Controls.Add(this.labDebug);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picDesktop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "flappy bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDesktop;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labDebug;
    }
}

