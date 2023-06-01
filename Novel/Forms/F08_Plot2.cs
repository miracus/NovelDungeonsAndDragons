using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novel.Code;
using Label = System.Windows.Forms.Label;

namespace Novel.Forms
{
    public partial class F08_Plot2 : Form
    {

        #region ObjectsCreate
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox1 = new PictureBox();
        Label label = new Label();
        private int step;
        #endregion

        public F08_Plot2(F09_ChoiceStory input)
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            ChoiceStory = input;
        }

        public F09_ChoiceStory ChoiceStory { get; }

        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            SoundPlay.Play(Properties.Resources.Plot1);
            Image image = GetImageFromBytes.action(Properties.Resources.board1);
            pictureBox.Image = image;

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

            pictureBox.Image = Properties.Resources.storyPic_7;
            object? text = null;
            text = Properties.Resources.ResourceManager.GetObject("story_11" + Properties.Settings.Default.gGender);
            await LabelAnimated.TextAsync(label, text?.ToString());
            step = 12;
        }

 
      
        private async void pictureBox_Click(object sender, EventArgs e)
        {

            if (!Properties.Settings.Default.gIsRunning)
            {
                if (Properties.Settings.Default.gTest) step = 18; // для тестування
                if (step == 18)
                {
                    SoundPlay.Stop(Properties.Resources.Plot1);
                    ChoiceStory.Show();
                    this.Hide();

                }

                if (step == 11) pictureBox.Image = Properties.Resources.storyPic_7;
                if (step == 12) pictureBox.Image = Properties.Resources.storyPic_8;
                if (step == 13) pictureBox1.Image = Properties.Resources.storyPic_7;
                if (step == 14 || step == 17)
                {
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
                }
                
                if (step == 15) pictureBox.Image = Properties.Resources.storyPic_6;
                if (step == 16) pictureBox.Image = Properties.Resources.storyPic_7;



                if (step == 14 || step == 17)
                {

                    object? part1Text = Properties.Resources.ResourceManager.GetObject("story_" + step + Properties.Settings.Default.gGender);
                    string part2Text = String.Format(part1Text?.ToString() ?? string.Empty, Properties.Settings.Default.gNameOfHero ?? string.Empty);
                    await LabelAnimated.TextAsync(label, part2Text);

                }
                else
                {
                    object? text = null;
                    text = Properties.Resources.ResourceManager.GetObject("story_" + step + Properties.Settings.Default.gGender);
                    await LabelAnimated.TextAsync(label, text?.ToString());
                }

                step++;
            }
        }

    }
}
