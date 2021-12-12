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
//for highscore
using System.IO;
//for sound effect and music
using System.Media;


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
        //--bird
        int SkinIndex = 0;
        Image HoppingImage;
        Image DroppingImage;
        int BirdFallingSpeed = 0;
        int Gravity = 2;
        int Max_BirdFallingSpeed= 20;
        int JumpSpeed = -20;

        //--pillars
        int PillarStartIndexInControlList = 2;
        int PillarsStep = 200;
        int PillarsAboveAmdBelowSpace = 200;
        int ComingPillarIndex = 2;

        //--tips
        int TipsMoveSpeed;
        int TipsMoveHeght;
        int TipsMaxHeight;
        int TipsMinHeight;

        //--game 
        public struct Player
        {
            public string Name;
            public int HighScore;
        }
        List<Player> Top5Player = new List<Player>();
        int ForwardSpeed = 7;
        int Score = 0;
        int HighScore = 0;
        string HighScoreFile = "score.txt";
        // the coming index is sett in "init" function
        string PlayerName = "player";
    

        enum State
        {
            waiting,
            playing,
            gameOver,
            total
        }
        int gameState = 0;

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //if opening setting or leaderboard, the do nothing
            if (gameSettingGeneral.Visible || leaderBoardGeneral.Visible) return;

            //UPDATE
            if (gameState == (int)State.waiting)
            {
                //reset all things to the waiting state
                //reset score
                Score = 0;
                //reset bird
                picBird.Image = DroppingImage;
                picBird.Location = new Point(52, 306);
                //remove all pillar
                while (picDesktop.Controls.Count > PillarStartIndexInControlList)
                {
                    picDesktop.Controls.RemoveAt(PillarStartIndexInControlList);
                }
                //reset coming pillar index
                ComingPillarIndex = PillarStartIndexInControlList;
                //hide the game over info
                gameOverInfoGeneral.Visible = false;

                //show tips
                labTips.Visible = true;
                //make the tips move
                labTips.Top += TipsMoveSpeed;
                if ( labTips.Top >= TipsMaxHeight || labTips.Top <= TipsMinHeight)
                {
                    TipsMoveSpeed = -TipsMoveSpeed;
                }

                //show setting icon
                picSettingIcon.Visible = true;
                picLeaderboard.Visible = true;

            }
            else if (gameState == (int)State.gameOver)
            {

                //hide setting icon 
                picSettingIcon.Visible = false;
                picLeaderboard.Visible = false;

                //hide tips
                labTips.Visible = false;

                //reset the highscore
                if (Score > HighScore)
                {
                    HighScore = Score;
                    StreamWriter sw = new StreamWriter(HighScoreFile);
                    sw.Write(HighScore.ToString());
                    sw.Close();
                }

                //pass score and high score to gameover info
                gameOverInfoGeneral.Visible = true;
                gameOverInfoGeneral.Score = Score.ToString();
                gameOverInfoGeneral.HighScore = HighScore.ToString();

            }
            else if (gameState == (int)State.playing)
            {
                //hide setting icon 
                picSettingIcon.Visible = false;
                picLeaderboard.Visible = false;

                //hide tips
                labTips.Visible = false;

                //calculate falling speed

                //--------------BIRD-------------------
                BirdFallingSpeed += Gravity;
                if (BirdFallingSpeed > Max_BirdFallingSpeed)
                {
                    BirdFallingSpeed = Max_BirdFallingSpeed;
                }

                //check if bird dropped to the ground, then stop falling
                var birdRect = picBird.Bounds;
                int groundHeight = picDesktop.Height + picDesktop.Location.Y;
                if (birdRect.Y + birdRect.Height >= groundHeight)
                {
                    picBird.Location = new Point(birdRect.X, groundHeight - birdRect.Height);
                    BirdFallingSpeed = 0;
                }
                else if (birdRect.Y <= 0)
                {
                    picBird.Location = new Point(birdRect.X, 0);
                }
                //drop down the bird 
                if (BirdFallingSpeed < 0)
                {
                    picBird.Image = HoppingImage;
                }
                else
                {
                    picBird.Image = DroppingImage;
                }
                picBird.Top += BirdFallingSpeed;
                //MovePictureBox(picBird, 0, BirdFallingSpeed);

                //-------------RUN THE PILLARS----------------------
                //run all pillars
                int count = picDesktop.Controls.Count;
                for (int i = PillarStartIndexInControlList; i < count; i++)
                {
                    //var bound = picDesktop.Controls[i].Bounds;
                    //picDesktop.Controls[i].Location = new Point(bound.X - ForwardSpeed, bound.Y);
                    picDesktop.Controls[i].Left -= ForwardSpeed;
                }

                //if the farest pillars reach the enough distance or there is no pillars, make a new couple pillars
                if (count <= PillarStartIndexInControlList)
                {
                    Add2Pillars(picDesktop.Width+300);
                }
                else
                {
                    var bound = picDesktop.Controls[count - 1].Bounds;
                    int lastPillX = bound.X + bound.Width;
                    if (picDesktop.Width - lastPillX > PillarsStep)
                    {
                        Add2Pillars();
                    }
                }
                //if the first pillars is out left, remove it
                var firstBound = picDesktop.Controls[PillarStartIndexInControlList].Bounds;
                int firstPillX = firstBound.X + firstBound.Width;
                if (firstPillX <= 0)
                {
                    picDesktop.Controls.RemoveAt(PillarStartIndexInControlList);
                    picDesktop.Controls.RemoveAt(PillarStartIndexInControlList);
                    ComingPillarIndex -= 2;
                }

                //-------------SCORE----------------------
                //if coming pillar is reached, then increase point, set the "coming pillar" for next pillar
                count = picDesktop.Controls.Count;
                if (ComingPillarIndex < count)
                {
                    var comingPillarBound = picDesktop.Controls[ComingPillarIndex].Bounds;
                    //if coming pillar reach the bird, increase point, set the next coming pillar
                    if (comingPillarBound.X <= picBird.Bounds.X)
                    {
                        Score++;
                        ComingPillarIndex += 2;
                    }
                }
                //if remove first 2-pillars, set the coming pillar for previous pillar [WRITE ABOVE, IN THE PILLAR PART]

                //-------------CHECK GAME OVER----------------------
                count = picDesktop.Controls.Count;
                for (int i = PillarStartIndexInControlList; i < count; i++)
                {
                    if (picDesktop.Controls[i].Bounds.IntersectsWith(picBird.Bounds))
                    {
                        gameState = (int)State.gameOver;
                        //add player to top5 if get the high score
                        AddNewPlayerToTop5(PlayerName, Score);
                    }
                }
            }

            //-------------THINGS THAT ALWAYS ON THE SCREEN----------------------
            //show point
            labPoint.Text = Score.ToString();
            //DEBUGG

        }
        void init()
        {
            //release
            labDebug.Visible = false;

            // made a picture box for bird
            HoppingImage = global::FlappyBird.Properties.Resources.whaleHopingBlue;
            DroppingImage = global::FlappyBird.Properties.Resources.whaleDropingBlue;
            picBird.Image = DroppingImage;
            picBird.Parent = picDesktop;
            picBird.BackColor = Color.Transparent;

            picSettingIcon.Parent = picDesktop;
            picSettingIcon.BackColor = Color.Transparent;

            picLeaderboard.Parent = picDesktop;
            picLeaderboard.BackColor = Color.Transparent;

            // made labels backgroung transparent
            labPoint.Parent = picDesktop;
            labPoint.BackColor = Color.Transparent;
            labTips.Parent = picDesktop;
            labTips.BackColor = Color.Transparent;

            //game setting
            gameSettingGeneral.btnCancelClick += new EventHandler(gameSetting_CancelClick);
            gameSettingGeneral.btnAcceptClick += new EventHandler(gameSetting_AcceptClick);

            //tips movement variable
            TipsMoveSpeed = 1;
            TipsMoveHeght = 10;
            TipsMaxHeight = labTips.Top + TipsMoveHeght;
            TipsMinHeight = labTips.Top - TipsMoveHeght;

            //find Pillar start idnex 
            PillarStartIndexInControlList = picDesktop.Controls.Count;
            ComingPillarIndex = PillarStartIndexInControlList;

            //set the first coming index
            ComingPillarIndex = PillarStartIndexInControlList;

            //set event for game over info control
            gameOverInfoGeneral.ExitClick += new EventHandler(GameOverInfo_ExitClick);

            //read highscore from "score.txt"
            if ( File.Exists(HighScoreFile))
            {
                StreamReader sr = new StreamReader(HighScoreFile);
                HighScore = Convert.ToInt32(sr.ReadToEnd());
            }

            ////play the music
            mediaPlayerMusic.URL = "backgroundMusic.wav";
            mediaPlayerMusic.settings.setMode("loop", true);
            mediaPlayerMusic.Ctlcontrols.play();

            ////load SFX
            mediaPlayerHopSFX.URL = "hopSFX.mp3";
            mediaPlayerHopSFX.settings.volume = 10;

            //load top 5 player for leaderboard
            loadTop5Player();
            leaderBoardGeneral.LoadLeaderboard(Top5Player);
            leaderBoardGeneral.CloseClick += new EventHandler(leaderboard_CloseClick);

        }

        void GameOverInfo_ExitClick( object sender, EventArgs e)
        {
            gameOverInfoGeneral.Visible = false;
            gameState = (int)State.waiting;
        }

        
        void AddNewPlayerToTop5( string playerName, int score)
        {
            if (score == 0) return;
            int index = 0;
            while (index < Top5Player.Count && Top5Player[index].HighScore >= score )
            {
                index++;
            }

            Player p = new Player();
            p.Name = playerName;
            p.HighScore = score;
            Top5Player.Insert(index, p);
            Top5Player.RemoveAt(Top5Player.Count - 1);

            leaderBoardGeneral.LoadLeaderboard(Top5Player);
        }
        void loadTop5Player()
        {
            Top5Player.Clear();
            StreamReader sr = new StreamReader("leaderboard.txt");
            string text = sr.ReadToEnd();
            string[] playersText = text.Split('\n');
            foreach (string player in playersText)
            {
                string[] playerInfo = player.Split(' ');
                Player p = new Player();
                p.Name = playerInfo[0];
                p.HighScore = Convert.ToInt32(playerInfo[playerInfo.Length-1]);

                Top5Player.Add(p);
            }
        }
        void Add2Pillars( )
        {
            Random r = new Random();
            int Hole = r.Next(100, 300);

            int count = picDesktop.Controls.Count;
            int X = picDesktop.Controls[count - 1].Location.X + picDesktop.Controls[count - 1].Width + PillarsStep;

            //above
            PictureBox picAbovePillar = new PictureBox();
            picAbovePillar.Image = global::FlappyBird.Properties.Resources.abovePillar;
            picAbovePillar.BackColor = Color.Transparent;
            picAbovePillar.BringToFront();
            picAbovePillar.Parent = picDesktop;
            picAbovePillar.Size = new Size(picAbovePillar.Image.Width, picAbovePillar.Image.Height);
            picAbovePillar.Location = new Point(X, Hole - picAbovePillar.Height);

            //below
            PictureBox picBelowPillar = new PictureBox();
            picBelowPillar.Image = global::FlappyBird.Properties.Resources.belowPillar;
            picBelowPillar.Location = new Point(X, picAbovePillar.Location.Y + picAbovePillar.Height + PillarsAboveAmdBelowSpace );
            picBelowPillar.BackColor = Color.Transparent;
            picBelowPillar.BringToFront();
            picBelowPillar.Parent = picDesktop;
            picBelowPillar.Size = new Size(picBelowPillar.Image.Width, picBelowPillar.Image.Height);
        }
        void Add2Pillars( int X=100 )
        {
            Random r = new Random();
            int Hole = r.Next(100, 300);

            int count = picDesktop.Controls.Count;

            //above
            PictureBox picAbovePillar = new PictureBox();
            picAbovePillar.Image = global::FlappyBird.Properties.Resources.abovePillar;
            picAbovePillar.BackColor = Color.Transparent;
            picAbovePillar.BringToFront();
            picAbovePillar.Parent = picDesktop;
            picAbovePillar.Size = new Size(picAbovePillar.Image.Width, picAbovePillar.Image.Height);
            picAbovePillar.Location = new Point(X, Hole - picAbovePillar.Height);

            //below
            PictureBox picBelowPillar = new PictureBox();
            picBelowPillar.Image = global::FlappyBird.Properties.Resources.belowPillar;
            picBelowPillar.Location = new Point(X, picAbovePillar.Location.Y + picAbovePillar.Height + PillarsAboveAmdBelowSpace );
            picBelowPillar.BackColor = Color.Transparent;
            picBelowPillar.BringToFront();
            picBelowPillar.Parent = picDesktop;
            picBelowPillar.Size = new Size(picBelowPillar.Image.Width, picBelowPillar.Image.Height);
        }

        void birdJump()
        {
            //  move and set the jump speed 
            picBird.Top -= 1;
            BirdFallingSpeed = JumpSpeed;

            // play sound efect
            mediaPlayerHopSFX.Ctlcontrols.stop();
            mediaPlayerHopSFX.Ctlcontrols.play();
        }
        private void mainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if opening setting or leaderboard, the do nothing
            if (gameSettingGeneral.Visible || leaderBoardGeneral.Visible) return;

            //else 
            if ( gameState == (int)State.waiting)
            {
                gameState = (int)State.playing;
                birdJump();
            }
            else if( gameState == (int)State.playing)
            {
                birdJump();
            }
        }

        private void gameSetting_CancelClick( object sender, EventArgs e)
        {
            //hide the setting
            gameSettingGeneral.Visible = false;
        }

        private void gameSetting_AcceptClick( object sender, EventArgs e)
        {
            //change difficult of gameplay
            switch( gameSettingGeneral.Level)
            {
                case 0:
                    PillarsStep = 400;
                    PillarsAboveAmdBelowSpace = 300;
                    ForwardSpeed = 7;
                    break;
                case 1:
                    PillarsStep = 200;
                    PillarsAboveAmdBelowSpace = 200;
                    ForwardSpeed = 7;
                    break;
                case 2:
                    PillarsStep = 200;
                    PillarsAboveAmdBelowSpace = 200;
                    ForwardSpeed = 10;
                    break;
            }


            //background change
            switch( gameSettingGeneral.BackgroundIndex)
            {
                case 0: picDesktop.Image = global::FlappyBird.Properties.Resources.mountain; break;
                case 1: picDesktop.Image = global::FlappyBird.Properties.Resources.sky1; break;
                case 2: picDesktop.Image = global::FlappyBird.Properties.Resources.galaxy; break;
            }

            //player name
            PlayerName = gameSettingGeneral.PlayerName;

            //hide the settings
            gameSettingGeneral.Visible = false;
            //apply the settings
            //skin
            if ( gameSettingGeneral.SkinIndex != SkinIndex)
            {
                SkinIndex = gameSettingGeneral.SkinIndex;
                switch( SkinIndex)
                {
                    case 0: HoppingImage  = global::FlappyBird.Properties.Resources.whaleHopingBlue;
                            DroppingImage = global::FlappyBird.Properties.Resources.whaleDropingBlue;
                            break;
                    case 1: HoppingImage   = global::FlappyBird.Properties.Resources.whaleHopingRed;
                            DroppingImage = global::FlappyBird.Properties.Resources.whaleDropingRed;
                            break;
                    case 2: HoppingImage   = global::FlappyBird.Properties.Resources.whaleHopingGreen;
                            DroppingImage = global::FlappyBird.Properties.Resources.whaleDropingGreen;
                            break;
                }
            }
            //picBird.Image = DroppingImage;

            //volumns
            mediaPlayerMusic.settings.volume = gameSettingGeneral.MusicVolumn;
            mediaPlayerHopSFX.settings.volume = gameSettingGeneral.SFXVolumn;
        }
        private void picSettingIcon_Click(object sender, EventArgs e)
        {
            //pass current Setting to the setting control
            gameSettingGeneral.SkinIndex = SkinIndex;
            gameSettingGeneral.MusicVolumn = mediaPlayerMusic.settings.volume;
            gameSettingGeneral.SFXVolumn = mediaPlayerHopSFX.settings.volume;

            //show setting part
            gameSettingGeneral.Visible = true;
        }

        private void picLeaderboard_Click(object sender, EventArgs e)
        {
            leaderBoardGeneral.Visible = true;
        }

        void leaderboard_CloseClick( object sender, EventArgs e)
        {
            leaderBoardGeneral.Visible = false;
        }

        // END PHU ZONE

        // TU ZONE  
        // END TU ZONE
    }
}
