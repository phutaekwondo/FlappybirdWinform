﻿using System;
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
        int BirdFallingSpeed = 0;
        int Gravity = 1;
        int Max_BirdFallingSpeed= 4;
        int JumpSpeed = -10;
        Stopwatch stopwatch = new Stopwatch();

        void init()
        {
            // made a picture box for bird
            picBird.Parent = picDesktop;
            picBird.BackColor = Color.Transparent;

            //set 60fps
            stopwatch.Start();

            //System.Windows.Forms.Application.Idle += new EventHandler(gameTimer_Tick);
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
            int picX = pic.Location.X;
            int picY = pic.Location.Y;

            picX += X;
            picY += Y;

            pic.Location = new Point(picX, picY);
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //sleep to make game run at 60 fps
            //int preFrameTime;
            //preFrameTime = Convert.ToInt32(stopwatch.ElapsedMilliseconds);
            //int FrameTimeDefault = 10;
            //if ( preFrameTime < FrameTimeDefault)
            //{
            //    Thread.Sleep(FrameTimeDefault - preFrameTime);
            //}
            Thread.Sleep(1);
            //preFrameTime = getPreviousFrameTime();

            //UPDATE
            //calculate falling speed
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
            }
            else if ( birdRect.Y <= 0)
            {
                picBird.Location = new Point(birdRect.X, 0);
            }
            else {
                //drop down the bird 
                MovePictureBox(picBird, 0, BirdFallingSpeed);
            }

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
