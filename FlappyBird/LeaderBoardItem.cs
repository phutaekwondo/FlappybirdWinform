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
    public partial class LeaderBoardItem : UserControl
    {
        public LeaderBoardItem()
        {
            InitializeComponent();
        }

        public string PlayerName
        {
            get
            {
                return labName.Text;
            }
            set
            {
                labName.Text = value;
            }
        }
        public int Score
        {
            get
            {
                return Convert.ToInt32(labScore.Text);
            }
            set
            {
                labScore.Text = value.ToString();
            }
        }
    }
}
