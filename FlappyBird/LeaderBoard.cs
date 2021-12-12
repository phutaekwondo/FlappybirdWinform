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
    public partial class LeaderBoard : UserControl
    {
        public LeaderBoard()
        {
            InitializeComponent();
        }
        public void LoadLeaderboard( List<mainForm.Player> top5 )
        {
            flowShowLeaderboard.Controls.Clear();
            foreach( mainForm.Player playerInfo in top5)
            {
                LeaderBoardItem newItem = new LeaderBoardItem();
                newItem.PlayerName = playerInfo.Name;
                newItem.Score = playerInfo.HighScore;

                flowShowLeaderboard.Controls.Add(newItem);
            }
        }

        public event EventHandler CloseClick
        {
            add
            {
                btnClose.Click += value;
            }
            remove
            {
                btnClose.Click -= value;
            }
        }

    }
}
