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
    public partial class F10_MainPlot : Form
    {

        #region ObjectsCreate
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        PictureBox pictureBox = new PictureBox();
        System.Windows.Forms.Label label = new System.Windows.Forms.Label();
        private int step;
        #endregion

        public F10_MainPlot()
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);

        }

        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            SoundPlay.Play(Properties.Resources.Plot1);
            pictureBox.Image = Properties.Resources.mainStoryPic_0;
            await LabelAnimated.TextAsync(label, Properties.Resources.mainStory_0);
            step = 1;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            if (!Properties.Settings.Default.gIsRunning)
            {
                string? sex = Properties.Settings.Default.gGender;
                if (Properties.Settings.Default.gChoiceStory1 == "a")
                {
                    _ = MainPlotBranchA();
                }

                if (Properties.Settings.Default.gChoiceStory1 == "c")
                {
                    _ = MainPlotBranchC();
                }

                if (Properties.Settings.Default.gChoiceStory1 == "r")
                {
                    _ = MainPlotBranchR();
                }

            }
            step++;
        }

        private async Task MainPlotBranchA()
        {
            pictureBox.Image = Properties.Resources.choicePic1_3;
            if (step == 23)
            {
                SoundPlay.Stop(Properties.Resources.Plot1);
                Application.Exit();
                Hide();
            }
            object? text = null;
            text = Properties.Resources.ResourceManager.GetObject("mainStory_a_" + step + Properties.Settings.Default.gGender);
            await LabelAnimated.TextAsync(label, text?.ToString());
        }

        private async Task MainPlotBranchC()
        {
            pictureBox.Image = Properties.Resources.choicePic1_2;
            if (step == 33)
            {
                SoundPlay.Stop(Properties.Resources.Plot1);
                Application.Exit();
                Hide();
            }
            object? text = null;
            text = Properties.Resources.ResourceManager.GetObject("mainStory_c_" + step + Properties.Settings.Default.gGender);
            await LabelAnimated.TextAsync(label, text?.ToString());
        }

        private async Task MainPlotBranchR()
        {
            pictureBox.Image = Properties.Resources.choicePic1_1;

            if (step == 28)
            {
                SoundPlay.Stop(Properties.Resources.Plot1);
                Application.Exit();
                Hide();
            }

                object? text = null;
                text = Properties.Resources.ResourceManager.GetObject("mainStory_r_" + step + Properties.Settings.Default.gGender);
                await LabelAnimated.TextAsync(label, text?.ToString());
        }
    }
}
