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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace Novel.Forms
{
    public partial class F03_InputName : Form
    {

        #region ObjectsCreate
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox1 = new PictureBox();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button button = new Button();
        #endregion

        public F03_InputName(F04_Plot1 input)
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            Plot1 = input;
        }

        public F04_Plot1 Plot1 { get; }

        #region Events
        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
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
            await LabelAnimated.TextAsync(label, Properties.Resources.sentenceCommon_9);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {
                Properties.Settings.Default.gNameOfHero = textBox.Text;
                SoundPlay.Stop(Properties.Resources.ChoseSound);
                Plot1.Show();
                this.Hide();
            }
        }
        #endregion
    }
}
