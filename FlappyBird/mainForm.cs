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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            init();
        }

        // PHU ZONE
        void init()
        {
            // made a picture box for bird
            picBird.Parent = picDesktop;
            picBird.BackColor = Color.Transparent;
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //move the bird 
            if ( e.KeyCode == Keys.Up)
            {
                //move up
                int bird_x = picBird.Location.X;
                int bird_y = picBird.Location.Y;

                bird_y -= 10;

                picBird.Location = new Point(bird_x, bird_y);
            }
            else if ( e.KeyCode == Keys.Down)
            {
                //move down 
                int bird_x = picBird.Location.X;
                int bird_y = picBird.Location.Y;

                bird_y += 10;

                picBird.Location = new Point(bird_x, bird_y);
            }
        }

        private void mainForm_KeyUp(object sender, KeyEventArgs e)
        {
        }

        // END PHU ZONE

        // TU ZONE  
        // END TU ZONE
    }
}
