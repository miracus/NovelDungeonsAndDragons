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
    public partial class F09_ChoiceStory : Form
    {

        #region ObjectsCreate
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        ToolTip tooltip = new ToolTip();
        Label label = new Label();
        #endregion

        public F09_ChoiceStory(F10_MainPlot input)
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            MainPlot = input;
        }

        public F10_MainPlot MainPlot { get; }

        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            SoundPlay.Play(Properties.Resources.ChoseSound);
            if (Properties.Settings.Default.gGender == "m")
            {
                if (Properties.Settings.Default.gTypeOfHero == "k") pictureBox.Image = Properties.Resources.pers1mBig;
                if (Properties.Settings.Default.gTypeOfHero == "m") pictureBox.Image = Properties.Resources.pers2mBig;
                if (Properties.Settings.Default.gTypeOfHero == "t") pictureBox.Image = Properties.Resources.pers3mBig;
                tooltip.SetToolTip(pictureBox1, String.Format(Properties.Resources.choice1_1m, Properties.Settings.Default.gNameOfHero));
                tooltip.SetToolTip(pictureBox2, String.Format(Properties.Resources.choice1_2m, Properties.Settings.Default.gNameOfHero));
                tooltip.SetToolTip(pictureBox3, String.Format(Properties.Resources.choice1_3m, Properties.Settings.Default.gNameOfHero));
            }

            if (Properties.Settings.Default.gGender == "f")
            {
                if (Properties.Settings.Default.gTypeOfHero == "k") pictureBox.Image = Properties.Resources.pers1fBig;
                if (Properties.Settings.Default.gTypeOfHero == "m") pictureBox.Image = Properties.Resources.pers2fBig;
                if (Properties.Settings.Default.gTypeOfHero == "t") pictureBox.Image = Properties.Resources.pers3fBig;
                tooltip.SetToolTip(pictureBox1, String.Format(Properties.Resources.choice1_1f, Properties.Settings.Default.gNameOfHero));
                tooltip.SetToolTip(pictureBox2, String.Format(Properties.Resources.choice1_2f, Properties.Settings.Default.gNameOfHero));
                tooltip.SetToolTip(pictureBox3, String.Format(Properties.Resources.choice1_3f, Properties.Settings.Default.gNameOfHero));
            }
            pictureBox1.Image = Properties.Resources.choicePic1_1;
            pictureBox2.Image = Properties.Resources.choicePic1_2;
            pictureBox3.Image = Properties.Resources.choicePic1_3;

            object? text = Properties.Resources.ResourceManager.GetObject("story_18" + Properties.Settings.Default.gGender);
            await LabelAnimated.TextAsync(label, text?.ToString());

        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {
                if (sender == pictureBox1)
                {
                    Properties.Settings.Default.gChoiceStory1 = "r";//respect
                }
                if (sender == pictureBox2)
                {
                    Properties.Settings.Default.gChoiceStory1 = "c";//contract
                }
                if (sender == pictureBox3)
                {
                    Properties.Settings.Default.gChoiceStory1 = "a";//attack
                }
                SoundPlay.Stop(Properties.Resources.ChoseSound);
                MainPlot.Show();
                this.Hide();
            }
        }



    }
}
