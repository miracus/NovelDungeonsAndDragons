using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novel.Code;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Label = System.Windows.Forms.Label;
using Timer = System.Windows.Forms.Timer;

namespace Novel.Forms
{
    public partial class F06_Game2 : Form
    {
        #region MainFormElement
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel();
        Button button1 = new Button();
        Label label = new Label();
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        Label scorePlayerLabel = new Label();
        Label scoreOppositeLabel = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        Label label8 = new Label();
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        #endregion

        #region GameLayoutElements
        Timer timer1 = new Timer();
        Panel gameField = new Panel();
        Panel lineOpposite = new Panel();
        Panel linePlayer = new Panel();
        PictureBox robot = new PictureBox();
        PictureBox player = new PictureBox();
        Button ball = new Button();
        TableLayoutPanel scoreTable = new TableLayoutPanel();
        Random rand = new Random();
        #endregion

        #region GameVariables
        int ballSize = 30;
        int platformSizeX = 15;
        int platformSizeY = 80;

        int directionBallX = 13;
        int directionBallY = 13;
        int platformSpeed = 8;

        bool platformMoveUp = false;
        bool platformMoveDown = false;

        int scorePlayer = 0;
        int scoreOpposite = 0;
        int scoreTime = 0;
        #endregion

        public F06_Game2(F07_Chat input)
        {
            InitializeComponent();

            Shown += MyForm_Shown;
            Load += MyForm_Load;
            KeyDown += MyForm_KeyDown;
            KeyUp += MyForm_KeyUp;
            Resize += MyForm_Resize;
            Chat = input;
            Focus();
            KeyPreview = true;
        }

        public F07_Chat Chat { get; }

        public void StartGame()
        {
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        public void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            

            label1.Text = Properties.Resources.gameOpponentName;
            pictureBox1.Image = Properties.Resources.forest;
            label3.Dock = DockStyle.Fill;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Text = Properties.Resources.game2;

            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "k")
            {
                pictureBox2.Image = Properties.Resources.pers1mBig;
                label2.Text = Properties.Resources.heroesKnightMaleName + " " + Properties.Settings.Default.gNameOfHero;
                player.Image = Properties.Resources.sword;
            }
            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "m")
            {
                pictureBox2.Image = Properties.Resources.pers2mBig;
                label2.Text = Properties.Resources.heroesMagicianMaleName + " " + Properties.Settings.Default.gNameOfHero;
                player.Image = Properties.Resources.rod;
            }
            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "t")
            {
                pictureBox2.Image = Properties.Resources.pers3mBig;
                label2.Text = Properties.Resources.heroesArcherThiefMaleName + " " + Properties.Settings.Default.gNameOfHero;
                player.Image = Properties.Resources.arrows;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "k")
            {
                pictureBox2.Image = Properties.Resources.pers1fBig;
                label2.Text = Properties.Resources.heroesKnightFemaleName + " " + Properties.Settings.Default.gNameOfHero;
                player.Image = Properties.Resources.sword;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "m")
            {
                pictureBox2.Image = Properties.Resources.pers2fBig;
                label2.Text = Properties.Resources.heroesMagicianFemaleName + " " + Properties.Settings.Default.gNameOfHero;
                player.Image = Properties.Resources.rod;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "t")
            {
                pictureBox2.Image = Properties.Resources.pers3fBig;
                label2.Text = Properties.Resources.heroesArcherThiefFemaleName + " " + Properties.Settings.Default.gNameOfHero;
                player.Image = Properties.Resources.arrows;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            timer1.Tick -= new System.EventHandler(timer1_Tick);
            scorePlayer = 0;
            scoreOpposite = 0;
            Chat.Show();
            this.Hide();
        }

        //----------------------------------------------------------------------------------------

        #region InitGame
        void InitGame()
        {
            

            const int indent = 5;
            int posScoreX = scoreTable.Width;
            int formX = gameField.Width;

            ball.Size = new Size(ballSize, ballSize);
            player.Size = new Size(platformSizeX, platformSizeY);
            robot.Size = new Size(platformSizeX, platformSizeY);

            scoreTable.Left = formX / 2 - posScoreX / 2;

            player.Left = indent;
            robot.Left = formX - platformSizeX - indent;

            
        }
        private void MyForm_Load([AllowNull] object sender, EventArgs e)
        {
            InitGame();
        }

        private void MyForm_Resize([AllowNull] object sender, EventArgs e)
        {
            InitGame();
        }
        #endregion

        #region MoveRobotPlatform
        void MoveRobotPlatform()
        {
            int reaction = platformSizeY / 2;

            int platformY = robot.Location.Y;
            int platformPosition = (platformY + platformSizeY / 2);

            int ballY = ball.Location.Y;
            int ballPosition = (ballY + ballSize / 2);


            if (Math.Abs(ballPosition - platformPosition) > reaction)
            {
                if (ballPosition < platformPosition)
                {
                    robot.Top = platformY - platformSpeed;
                }
                else
                {
                    robot.Top = platformY + platformSpeed;
                }
            }
        }

        #endregion
        #region MovePlayerPlatform
        private void MyForm_KeyDown([AllowNull] object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                platformMoveUp = true;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                platformMoveDown = true;
            }

        }
        private void MyForm_KeyUp([AllowNull] object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                platformMoveUp = false;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                platformMoveDown = false;
            }
        }

        void MovePlayerPlatform()
        {
            int tableLayoutTop = tableLayoutPanel2.Location.Y;
            int tableLayoutBottom = tableLayoutPanel2.Location.Y + tableLayoutPanel2.Height;

            if (platformMoveUp && player.Top > tableLayoutTop)
            {
                player.Top -= platformSpeed;
            }
            else if (platformMoveDown && player.Bottom < tableLayoutBottom)
            {
                player.Top += platformSpeed;
            }
        }


        #endregion
        #region MoveBall

        void MoveBall()
        {
            int x = ball.Left;
            int y = ball.Top;

            BlocksTest();

            if (IsWallY(y))
            {
                directionBallY *= -1;
            }
            if (IsWallX(x))
            {
                directionBallX *= -1;
            }
            ball.Left = x + directionBallX;
            ball.Top = y + directionBallY;
        }

        bool IsWallY(int y)
        {
            if (y < 0 || y > gameField.Height - ball.Height)
            {
                return true;
            }
            return false;
        }
        bool IsWallX(int x)
        {
            if (x < 0 || x > gameField.Width - ball.Width)
            {
                if (x < 0)
                {
                    scoreOpposite++;
                    scoreOppositeLabel.ForeColor = Color.Brown;
                    linePlayer.Visible = true;
                }
                else
                {
                    scorePlayer++;
                    scorePlayerLabel.ForeColor = Color.Brown;
                    lineOpposite.Visible = true;
                }
                scoreTime = 30;
                UpdateScoreTable();
                GenerateBlocks();

                return true;
            }
            return false;
        }


        void UpdateScoreTable()
        {
            scorePlayerLabel.Text = scorePlayer.ToString();
            scoreOppositeLabel.Text = scoreOpposite.ToString();
        }

        void UpdateLinesScroes()
        {
            if (scoreTime >= 0)
            {
                if (scoreTime == 0)
                {
                    lineOpposite.Visible = false;
                    linePlayer.Visible = false;
                    scoreOppositeLabel.ForeColor = Color.DarkGray;
                    scorePlayerLabel.ForeColor = Color.DarkGray;
                }
                scoreTime--;
            }
        }


        void GenerateBlocks()
        {
            int blocks = rand.Next(0, 3) + 1;
            for (int i = 0; i < blocks; i++)
            {
                int border = ballSize * 3;
                int x = rand.Next(border, gameField.Width - border);
                int y = rand.Next(border, gameField.Height - border);

                PictureBox block = new PictureBox();
                block.Width = rand.Next(10, 50);
                block.Height = rand.Next(10, 50);
                block.Location = new Point(x, y);
                block.Image = Properties.Resources.wood;
                gameField.Controls.Add(block);
            }
        }

        void BlocksTest()
        {
            foreach (Control element in gameField.Controls)
            {
                if (element is PictureBox)
                {
                    if (BlockIntersectY(element) || BlockIntersectX(element))
                    {
                        if (element != player && element != robot)
                        {
                            gameField.Controls.Remove(element);
                        }
                    }
                }
            }
        }

        bool BlockIntersectY(Control element)
        {
            Rectangle ballRectangle = ball.Bounds;

            Rectangle intersectionY = Rectangle.Intersect(ballRectangle, element.Bounds);
            if (!intersectionY.IsEmpty)
            {
                if (intersectionY.Height < ballSize / 2)
                {
                    if (ballRectangle.Top == intersectionY.Top)
                    {
                        ball.Top += intersectionY.Height + 1;
                        directionBallY = Math.Abs(directionBallY);
                        return true;
                    }
                    else if (ballRectangle.Bottom == intersectionY.Bottom)
                    {
                        ball.Top -= intersectionY.Height + 1;
                        directionBallY = Math.Abs(directionBallY) * -1;
                        return true;
                    }
                }
            }
            return false;
        }

        bool BlockIntersectX(Control element)
        {
            Rectangle ballRectangle = ball.Bounds;

            Rectangle intersectionX = Rectangle.Intersect(ballRectangle, element.Bounds);
            if (!intersectionX.IsEmpty)
            {
                if (intersectionX.Width < ballSize / 2)
                {
                    if (ballRectangle.Left == intersectionX.Left)
                    {
                        ball.Left += intersectionX.Width + 1;
                        directionBallX = Math.Abs(directionBallX);
                        return true;
                    }
                    else if (ballRectangle.Right == intersectionX.Right)
                    {
                        ball.Left -= intersectionX.Width + 1;
                        directionBallX = Math.Abs(directionBallX) * -1;
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        bool IsWinPlayer()
        {
            if (scorePlayer >= 15)
            {
                return true;
            }
            return false;
        }

        bool IsWinOpposite()
        {
            if (scoreOpposite >= 15)
            {
                return true;
            }
            return false;
        }

        private void timer1_Tick([AllowNull] object sender, EventArgs e)
        {
            if (!IsWinPlayer() && !IsWinOpposite())
            {
                MoveBall();
                MoveRobotPlatform();
                MovePlayerPlatform();
                UpdateLinesScroes();
            }
            else
            {
                if (IsWinPlayer())
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer1.Tick -= new System.EventHandler(timer1_Tick);
                    scorePlayer = 0;
                    scoreOpposite = 0;
                    MessageBox.Show(Properties.Resources.game2Win);
                    Chat.Show();
                    this.Hide();
                } else
                {
                    timer1.Enabled = false;
                    timer1.Tick -= new System.EventHandler(timer1_Tick);
                    scorePlayer = 0;
                    scoreOpposite = 0;
                    MessageBox.Show(Properties.Resources.gameLose);
                    StartGame();
                }
            }
        }
    }
}
