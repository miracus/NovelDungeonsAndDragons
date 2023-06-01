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
    public partial class F02_ChoiceHero : Form
    {
        #region ObjectsCreate
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        PictureBox pictureBox5 = new PictureBox();

        System.Windows.Forms.Label label = new System.Windows.Forms.Label();
        ToolTip tooltip = new ToolTip();
        public int step = 0;
        #endregion

        public F02_ChoiceHero(F03_InputName input)
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            InputName = input;
            
        }

        public F03_InputName InputName { get; }

        #region Events
        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            SoundPlay.Play(Properties.Resources.ChoseSound);
            pictureBox.Image = Properties.Resources.pers1mBig;
            pictureBox1.Image = Properties.Resources.pers2mBig;
            pictureBox2.Image = Properties.Resources.pers3mBig;
            pictureBox3.Image = Properties.Resources.pers1fBig;
            pictureBox4.Image = Properties.Resources.pers2fBig;
            pictureBox5.Image = Properties.Resources.pers3fBig;
            await LabelAnimated.TextAsync(label, Properties.Resources.sentenceCommon_8);
            step = 1;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {

                if (sender == pictureBox)
                {
                    Properties.Settings.Default.gTypeOfHero = "k";
                    Properties.Settings.Default.gGender = "m";

                }
                if (sender == pictureBox1)
                {
                    Properties.Settings.Default.gTypeOfHero = "m";
                    Properties.Settings.Default.gGender = "m";
                }
                if (sender == pictureBox2)
                {
                    Properties.Settings.Default.gTypeOfHero = "t";
                    Properties.Settings.Default.gGender = "m";
                }
                if (sender == pictureBox3)
                {
                    Properties.Settings.Default.gTypeOfHero = "k";
                    Properties.Settings.Default.gGender = "f";
                }
                if (sender == pictureBox4)
                {
                    Properties.Settings.Default.gTypeOfHero = "m";
                    Properties.Settings.Default.gGender = "f";
                }
                if (sender == pictureBox5)
                {
                    Properties.Settings.Default.gTypeOfHero = "t";
                    Properties.Settings.Default.gGender = "f";
                }
                
                InputName.Show();
                this.Hide();
            }

        }
        #endregion



    }
}
