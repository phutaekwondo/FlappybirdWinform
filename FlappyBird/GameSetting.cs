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
                if (radWhaleBlue.Checked)  return 0;
                if (radWhaleRed.Checked)   return 1;
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
    }
}
