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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Novel.Forms
{
    public partial class F04_Plot1 : Form
    {

        #region ObjectsCreate
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox1 = new PictureBox();
        Label label = new Label();
        private int step;
        #endregion

        public F04_Plot1(F05_Game1 input)
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            Game1 = input;
        }

        public F05_Game1 Game1 { get; }


        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            SoundPlay.Play(Properties.Resources.Plot1);
            if (Properties.Settings.Default.gGender == "m")
            {
                if (Properties.Settings.Default.gTypeOfHero == "k") pictureBox1.Image = Properties.Resources.pers1mBig;
                if (Properties.Settings.Default.gTypeOfHero == "m") pictureBox1.Image = Properties.Resources.pers2mBig;
                if (Properties.Settings.Default.gTypeOfHero == "t") pictureBox1.Image = Properties.Resources.pers3mBig;
            }

            if (Properties.Settings.Default.gGender == "f")
            {
                if (Properties.Settings.Default.gTypeOfHero == "k") pictureBox1.Image = Properties.Resources.pers1fBig;
                if (Properties.Settings.Default.gTypeOfHero == "m") pictureBox1.Image = Properties.Resources.pers2fBig;
                if (Properties.Settings.Default.gTypeOfHero == "t") pictureBox1.Image = Properties.Resources.pers3fBig;
            }
            pictureBox.Image = Properties.Resources.storyPic_1;

            object? text = null;
            text = Properties.Resources.ResourceManager.GetObject("story_1" + Properties.Settings.Default.gGender);
            await LabelAnimated.TextAsync(label, text?.ToString());
            step = 2;
        }

        private async void pictureBox_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {
                if (Properties.Settings.Default.gTest) step = 10; // для тестування
                if (step == 10)
                {
                    SoundPlay.Stop(Properties.Resources.Plot1);
                    Game1.Show();
                    this.Hide();
                    
                }

                if (step == 2) pictureBox.Image = Properties.Resources.storyPic_2;
                if (step == 3) pictureBox.Image = Properties.Resources.storyPic_3;
                if (step == 4) pictureBox.Image = Properties.Resources.storyPic_4;
                if (step == 5) pictureBox.Image = Properties.Resources.storyPic_5;
                if (step == 6) pictureBox.Image = Properties.Resources.storyPic_6;
                if (step == 7) pictureBox.Image = Properties.Resources.forest;
                if (step == 8) pictureBox.Image = Properties.Resources.forest;
                if (step == 9) pictureBox.Image = Properties.Resources.forest;
                if (step == 10) pictureBox.Image = Properties.Resources.forest;

                object? text = null;
                text = Properties.Resources.ResourceManager.GetObject("story_" + step + Properties.Settings.Default.gGender);
                await LabelAnimated.TextAsync(label, text?.ToString());

                step++;
            }
        }
    }
}
