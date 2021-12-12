using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class GameSetting : UserControl
    {
        public GameSetting()
        {
            InitializeComponent();
        }

        public string PlayerName
        {
            get
            {
                return txtPlayerName.Text;
            }
            set
            {
                txtPlayerName.Text = value;
            }
        }

        public int MusicVolumn
        {
            get
            {
                return trackMusicVolumn.Value;
            }
            set
            {
                trackMusicVolumn.Value = value;
            }
        }
        public int SFXVolumn
        {
            get
            {
                return trackSFXVolumn.Value;
            }
            set
            {
                trackSFXVolumn.Value = value;
            }
        }

        public event EventHandler btnCancelClick
        {
            add
            {
                btnCancel.Click += value;
            }
            remove
            {
                btnCancel.Click -= value;
            }
        }

        public event EventHandler btnAcceptClick
        {
            add
            {
                btnAccept.Click += value;
            }
            remove
            {
                btnAccept.Click -= value;
            }
        }

        private void picWhaleBlue_Click(object sender, EventArgs e)
        {
            radWhaleBlue.Checked = true;
        }

        private void picWhaleRed_Click(object sender, EventArgs e)
        {
            radWhaleRed.Checked = true;
        }

        private void picWhaleGreen_Click(object sender, EventArgs e)
        {
            radWhaleGreen.Checked = true;
        }

        public int SkinIndex
        {
            get
            {
                if (radWhaleBlue.Checked) return 0;
                if (radWhaleRed.Checked) return 1;
                if (radWhaleGreen.Checked) return 2;

                return 0;
            }
            set
            {
                switch (value)
                {
                    case 0: radWhaleBlue.Checked = true; break;
                    case 1: radWhaleRed.Checked = true; break;
                    case 2: radWhaleGreen.Checked = true; break;
                }
            }
        }
        public int BackgroundIndex
        {
            get
            {
                if (radMountain.Checked) return 0;
                if (radSky.Checked) return 1;
                if (radGalaxy.Checked) return 2;

                return 0;
            }
            set
            {
                switch (value)
                {
                    case 0: radMountain.Checked = true; break;
                    case 1: radSky.Checked = true; break;
                    case 2: radGalaxy.Checked = true; break;
                }
            }
        }

        public int Level
        {
            get
            {
                return trackLevel.Value;
            }
            set
            {
                trackLevel.Value = value;
            }
        }

        private void picMountain_Click(object sender, EventArgs e)
        {
            radMountain.Checked = true;

        }

        private void picSky_Click(object sender, EventArgs e)
        {
            radSky.Checked = true;
        }

        private void picGalaxy_Click(object sender, EventArgs e)
        {
            radGalaxy.Checked = true;
        }

        private void trackLevel_Scroll(object sender, EventArgs e)
        {
            switch( trackLevel.Value)
            {
                case 0: labLevel.Text = "level " + "easy"; break;
                case 1: labLevel.Text = "level " + "medium"; break;
                case 2: labLevel.Text = "level " + "hard"; break;
            }
        }
    }
}
