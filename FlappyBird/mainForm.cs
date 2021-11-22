using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for stopwatch
using System.Diagnostics;
using System.Threading;
//for keystate
using System.Windows.Input;

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
        //--game 
        int ForwardSpeed = 5;

        //--bird
        int BirdFallingSpeed = 0;
        int Gravity = 2;
        int Max_BirdFallingSpeed= 15;
        int JumpSpeed = -20;
        Stopwatch stopwatch = new Stopwatch();

        void init()
        {
            // made a picture box for bird
            picBird.Parent = picDesktop;
            picBird.BackColor = Color.Transparent;

            //set 60fps
            stopwatch.Start();

            //DEBUG
            updatePicNextGroundLocation();
        }

        int getPreviousFrameTime()
        {
            //stopwatch.Stop();
            int res = Convert.ToInt32(stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();
            stopwatch.Start();
            return res;
        }

        void MovePictureBox( PictureBox pic, int X, int Y)
        {
            if (X == 0 && Y == 0) return;
            int picX = pic.Location.X;
            int picY = pic.Location.Y;

            picX += X;
            picY += Y;

            pic.Location = new Point(picX, picY);
        }

        void updatePicNextGroundLocation()
        {
            picNextGround.Location = new Point(picGround.Location.X + picNextGround.Bounds.Width -1 , picGround.Location.Y);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //preFrameTime = getPreviousFrameTime();

            //UPDATE
            //calculate falling speed

            //--------------BIRD-------------------
            BirdFallingSpeed += Gravity;
            if ( BirdFallingSpeed > Max_BirdFallingSpeed)
            {
                BirdFallingSpeed = Max_BirdFallingSpeed;
            }
            //BirdFallingSpeed = Convert.ToInt32( Convert.ToDouble(BirdFallingSpeed) * Convert.ToDouble(preFrameTime) / 15.0d );

            //check if bird dropped to the ground, then stop falling
            var birdRect = picBird.Bounds;
            int groundHeight = picGround.Location.Y;
            if ( birdRect.Y+birdRect.Height >= groundHeight)
            {
                picBird.Location = new Point(birdRect.X, groundHeight - birdRect.Height);
                BirdFallingSpeed = 0;
            }
            else if ( birdRect.Y <= 0)
            {
                picBird.Location = new Point(birdRect.X, 0);
            }
            //drop down the bird 
            MovePictureBox(picBird, 0, BirdFallingSpeed);


            //-------------RUN THE GROUND----------------------
            //move ground with Forward game speed 
            int groundX = picGround.Location.X;
            int groundY = picGround.Location.Y;

            groundX -= ForwardSpeed;
            if (groundX + picGround.Bounds.Width <= 0 )
            {
                groundX += picGround.Bounds.Width;
            }

            picGround.Location = new Point(groundX , groundY);
            updatePicNextGroundLocation();

        }

        private void mainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            BirdFallingSpeed = JumpSpeed;
        }

        //private void mainForm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //move the bird 
        //    if ( e.KeyCode == Keys.Up)
        //    {
        //        //move up
        //        BirdFallingSpeed = -20;
        //    }
        //}



        // END PHU ZONE

        // TU ZONE  
        // END TU ZONE
    }
}
