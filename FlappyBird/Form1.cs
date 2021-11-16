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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PictureBox newbird = new PictureBox();
            newbird.Image =  global::FlappyBird.Properties.Resources.birdscaled;
            picDesktop.Controls.Add(newbird);
            newbird.Location = new Point(0, 0);
            newbird.BackColor = Color.Transparent;
            
        }
    }
}
