
namespace FlappyBird
{
    partial class Form1
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
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picDesktop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // picGround
            // 
            this.picGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.picGround.Location = new System.Drawing.Point(0, 606);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(500, 144);
            this.picGround.TabIndex = 1;
            this.picGround.TabStop = false;
            // 
            // picDesktop
            // 
            this.picDesktop.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDesktop.Image = global::FlappyBird.Properties.Resources.sky;
            this.picDesktop.Location = new System.Drawing.Point(0, 0);
            this.picDesktop.Name = "picDesktop";
            this.picDesktop.Size = new System.Drawing.Size(500, 639);
            this.picDesktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDesktop.TabIndex = 0;
            this.picDesktop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 750);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picDesktop);
            this.Name = "Form1";
            this.Text = "flappy bird";
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDesktop;
        private System.Windows.Forms.PictureBox picGround;
    }
}

