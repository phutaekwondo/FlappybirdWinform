
namespace FlappyBird
{
    partial class GameSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.picWhaleBlue = new System.Windows.Forms.PictureBox();
            this.picWhaleRed = new System.Windows.Forms.PictureBox();
            this.picWhaleGreen = new System.Windows.Forms.PictureBox();
            this.radWhaleBlue = new System.Windows.Forms.RadioButton();
            this.radWhaleRed = new System.Windows.Forms.RadioButton();
            this.radWhaleGreen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.trackMusicVolumn = new System.Windows.Forms.TrackBar();
            this.trackSFXVolumn = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWhaleBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhaleRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhaleGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMusicVolumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSFXVolumn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Norwester", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(144, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "setting";
            // 
            // picWhaleBlue
            // 
            this.picWhaleBlue.Image = global::FlappyBird.Properties.Resources.whaleDropingBlue;
            this.picWhaleBlue.Location = new System.Drawing.Point(45, 114);
            this.picWhaleBlue.Name = "picWhaleBlue";
            this.picWhaleBlue.Size = new System.Drawing.Size(80, 53);
            this.picWhaleBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWhaleBlue.TabIndex = 1;
            this.picWhaleBlue.TabStop = false;
            this.picWhaleBlue.Click += new System.EventHandler(this.picWhaleBlue_Click);
            // 
            // picWhaleRed
            // 
            this.picWhaleRed.Image = global::FlappyBird.Properties.Resources.whaleDropingRed;
            this.picWhaleRed.Location = new System.Drawing.Point(160, 114);
            this.picWhaleRed.Name = "picWhaleRed";
            this.picWhaleRed.Size = new System.Drawing.Size(80, 53);
            this.picWhaleRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWhaleRed.TabIndex = 2;
            this.picWhaleRed.TabStop = false;
            this.picWhaleRed.Click += new System.EventHandler(this.picWhaleRed_Click);
            // 
            // picWhaleGreen
            // 
            this.picWhaleGreen.Image = global::FlappyBird.Properties.Resources.whaleDropingGreen;
            this.picWhaleGreen.Location = new System.Drawing.Point(281, 114);
            this.picWhaleGreen.Name = "picWhaleGreen";
            this.picWhaleGreen.Size = new System.Drawing.Size(80, 53);
            this.picWhaleGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWhaleGreen.TabIndex = 3;
            this.picWhaleGreen.TabStop = false;
            this.picWhaleGreen.Click += new System.EventHandler(this.picWhaleGreen_Click);
            // 
            // radWhaleBlue
            // 
            this.radWhaleBlue.AutoSize = true;
            this.radWhaleBlue.Checked = true;
            this.radWhaleBlue.Location = new System.Drawing.Point(81, 196);
            this.radWhaleBlue.Name = "radWhaleBlue";
            this.radWhaleBlue.Size = new System.Drawing.Size(14, 13);
            this.radWhaleBlue.TabIndex = 4;
            this.radWhaleBlue.TabStop = true;
            this.radWhaleBlue.UseVisualStyleBackColor = true;
            // 
            // radWhaleRed
            // 
            this.radWhaleRed.AutoSize = true;
            this.radWhaleRed.Location = new System.Drawing.Point(196, 196);
            this.radWhaleRed.Name = "radWhaleRed";
            this.radWhaleRed.Size = new System.Drawing.Size(14, 13);
            this.radWhaleRed.TabIndex = 5;
            this.radWhaleRed.UseVisualStyleBackColor = true;
            // 
            // radWhaleGreen
            // 
            this.radWhaleGreen.AutoSize = true;
            this.radWhaleGreen.Location = new System.Drawing.Point(319, 196);
            this.radWhaleGreen.Name = "radWhaleGreen";
            this.radWhaleGreen.Size = new System.Drawing.Size(14, 13);
            this.radWhaleGreen.TabIndex = 6;
            this.radWhaleGreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Norwester", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Music Volumn";
            // 
            // trackMusicVolumn
            // 
            this.trackMusicVolumn.Location = new System.Drawing.Point(150, 278);
            this.trackMusicVolumn.Maximum = 50;
            this.trackMusicVolumn.Name = "trackMusicVolumn";
            this.trackMusicVolumn.Size = new System.Drawing.Size(248, 45);
            this.trackMusicVolumn.TabIndex = 8;
            this.trackMusicVolumn.Value = 50;
            // 
            // trackSFXVolumn
            // 
            this.trackSFXVolumn.Location = new System.Drawing.Point(150, 350);
            this.trackSFXVolumn.Maximum = 50;
            this.trackSFXVolumn.Name = "trackSFXVolumn";
            this.trackSFXVolumn.Size = new System.Drawing.Size(248, 45);
            this.trackSFXVolumn.TabIndex = 10;
            this.trackSFXVolumn.Value = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Norwester", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "SFX Volumn";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.LightGreen;
            this.btnAccept.Font = new System.Drawing.Font("Norwester", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(114, 495);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(96, 45);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.Font = new System.Drawing.Font("Norwester", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(216, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // GameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.trackSFXVolumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackMusicVolumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radWhaleGreen);
            this.Controls.Add(this.radWhaleRed);
            this.Controls.Add(this.radWhaleBlue);
            this.Controls.Add(this.picWhaleGreen);
            this.Controls.Add(this.picWhaleRed);
            this.Controls.Add(this.picWhaleBlue);
            this.Controls.Add(this.label1);
            this.Name = "GameSetting";
            this.Size = new System.Drawing.Size(425, 568);
            ((System.ComponentModel.ISupportInitialize)(this.picWhaleBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhaleRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhaleGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMusicVolumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSFXVolumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picWhaleBlue;
        private System.Windows.Forms.PictureBox picWhaleRed;
        private System.Windows.Forms.PictureBox picWhaleGreen;
        private System.Windows.Forms.RadioButton radWhaleBlue;
        private System.Windows.Forms.RadioButton radWhaleRed;
        private System.Windows.Forms.RadioButton radWhaleGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackMusicVolumn;
        private System.Windows.Forms.TrackBar trackSFXVolumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}
