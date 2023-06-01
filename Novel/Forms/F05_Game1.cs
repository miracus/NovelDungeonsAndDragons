using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novel.Code;

namespace Novel.Forms
{
    public partial class F05_Game1 : Form
    {
        #region ObjectsCreate
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel5 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel6 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel7 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel8 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel9 = new TableLayoutPanel();

        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();

        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        Label label4 = new Label();
        Label label5 = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        Label label8 = new Label();

        Button c1r1 = new Button();
        Button c2r1 = new Button();
        Button c3r1 = new Button();
        Button c1r2 = new Button();
        Button c2r2 = new Button();
        Button c3r2 = new Button();
        Button c1r3 = new Button();
        Button c2r3 = new Button();
        Button c3r3 = new Button();
        Label label = new Label();

        private Game1Logic? game1Logic;
        private string player = "0";
        #endregion

        public F05_Game1(F06_Game2 input)
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            Game2 = input;
        }

        public F06_Game2 Game2 { get; }

        public void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {


            label1.Text = Properties.Resources.gameOpponentName;
            pictureBox1.Image = Properties.Resources.forest;

            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "k")
            {
                pictureBox2.Image = Properties.Resources.pers1mBig;
                pictureBox3.Image = Properties.Resources.pers2mBig;
                pictureBox4.Image = Properties.Resources.pers3mBig;
                label2.Text = Properties.Resources.heroesKnightMaleName;
                label3.Text = Properties.Resources.heroesMagicianMaleName;
                label4.Text = Properties.Resources.heroesArcherThiefMaleName;
            }
            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "m")
            {
                pictureBox2.Image = Properties.Resources.pers2mBig;
                pictureBox3.Image = Properties.Resources.pers1mBig;
                pictureBox4.Image = Properties.Resources.pers3mBig;
                label2.Text = Properties.Resources.heroesMagicianMaleName;
                label3.Text = Properties.Resources.heroesKnightMaleName;
                label4.Text = Properties.Resources.heroesArcherThiefMaleName;
            }
            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "t")
            {
                pictureBox2.Image = Properties.Resources.pers3mBig;
                pictureBox3.Image = Properties.Resources.pers1mBig;
                pictureBox4.Image = Properties.Resources.pers2mBig;
                label2.Text = Properties.Resources.heroesArcherThiefMaleName;
                label3.Text = Properties.Resources.heroesKnightMaleName;
                label4.Text = Properties.Resources.heroesMagicianMaleName;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "k")
            {
                pictureBox2.Image = Properties.Resources.pers1fBig;
                pictureBox3.Image = Properties.Resources.pers2fBig;
                pictureBox4.Image = Properties.Resources.pers3fBig;
                label2.Text = Properties.Resources.heroesKnightFemaleName;
                label3.Text = Properties.Resources.heroesMagicianFemaleName;
                label4.Text = Properties.Resources.heroesArcherThiefFemaleName;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "m")
            {
                pictureBox2.Image = Properties.Resources.pers2fBig;
                pictureBox3.Image = Properties.Resources.pers1fBig;
                pictureBox4.Image = Properties.Resources.pers3fBig;
                label2.Text = Properties.Resources.heroesMagicianFemaleName;
                label3.Text = Properties.Resources.heroesKnightFemaleName;
                label4.Text = Properties.Resources.heroesArcherThiefFemaleName;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "t")
            {
                pictureBox2.Image = Properties.Resources.pers3fBig;
                pictureBox3.Image = Properties.Resources.pers1fBig;
                pictureBox4.Image = Properties.Resources.pers2fBig;
                label2.Text = Properties.Resources.heroesArcherThiefFemaleName;
                label3.Text = Properties.Resources.heroesKnightFemaleName;
                label4.Text = Properties.Resources.heroesMagicianFemaleName;
            }

            Properties.Settings.Default.gIsRunning = true;
            label5.Text = Properties.Resources.game_1;
            label6.Text = Properties.Resources.game_2;
            label7.Text = Properties.Resources.game_3;
            label8.Text = Properties.Resources.game_4;


            game1Logic = new Game1Logic(this);
            var buttonsCoordinates = new[]
            {
                c1r1, c1r2, c1r3, c2r1, c2r2, c2r3, c3r1, c3r2, c3r3
            };

            var labels = new[]
            {
                label5, label6, label7, label8
            };

            game1Logic.MoveRobot(buttonsCoordinates, labels);

        }


        private void button_Click(object sender, EventArgs e)
        {
            SoundPlay.Play(Properties.Resources.Button);
            Button buttonGame = (Button)sender;
            if (buttonGame.Text == string.Empty)
            {

                buttonGame.Text = player;
                if (buttonGame.Text == player) buttonGame.ForeColor = Color.Black;

                var buttonsCoordinates1 = new[]
                {c1r1, c1r2, c1r3, c2r1, c2r2, c2r3, c3r1, c3r2, c3r3};

                var labels1 = new[] { label5, label6, label7, label8 };

                if (game1Logic != null)
                {
                    game1Logic.PlayGame(buttonGame, buttonsCoordinates1, labels1);
                }

                if (Properties.Settings.Default.gGameWin)
                {
                    Game2.StartGame();
                    Game2.Show();
                    this.Hide();
                }

                int i = 0;
                while (true)
                {
                    i++;
                    if (i >= 10000) break;

                }

                var buttonsCoordinates = new[] { c1r1, c1r2, c1r3, c2r1, c2r2, c2r3, c3r1, c3r2, c3r3 };

                var labels = new[] { label5, label6, label7, label8 };

                if (game1Logic != null)
                {
                    game1Logic.MoveRobot(buttonsCoordinates, labels);
                }

                if (Properties.Settings.Default.gGameWin)
                {
                    Game2.StartGame();
                    Game2.Show();
                    this.Hide();
                    Properties.Settings.Default.gGameWin = false;
                }
            }
            

        }

    }
}
