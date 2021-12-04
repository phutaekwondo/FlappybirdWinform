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
    public partial class GameOverInfo : UserControl
    {
        public GameOverInfo()
        {
            InitializeComponent();
        }

        public event EventHandler ExitClick
        {
            add
            {
                btnExit.Click += value;
            }
            remove
            {
                btnExit.Click -= value;
            }
        }
        public string Score
        {
            get
            {
                return labScore.Text;
            }
            set
            {
                labScore.Text = value;
            }
        }
        public string HighScore
        {
            get
            {
                return labHighScore.Text;
            }
            set
            {
                labHighScore.Text = value;
            }
        }

    }
}
