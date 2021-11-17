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
        int BirdFallingSpeed= 0;
        int Gravity = 1;
        int Max_BirdFallingSpeed= 10;


        void init()
        {
            // made a picture box for bird
            picBird.Parent = picDesktop;
            picBird.BackColor = Color.Transparent;

            //set 60fps

        }

        void MovePictureBox( PictureBox pic, int X, int Y)
        {
            int picX = pic.Location.X;
            int picY = pic.Location.Y;

            picX += X;
            picY += Y;

            pic.Location = new Point(picX, picY);
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            BirdFallingSpeed += Gravity;
            if ( BirdFallingSpeed > Max_BirdFallingSpeed)
            {
                BirdFallingSpeed = Max_BirdFallingSpeed;
            }

            //drop down the bird 
            MovePictureBox(picBird, 0, BirdFallingSpeed);
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
