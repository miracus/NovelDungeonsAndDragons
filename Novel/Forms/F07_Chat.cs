using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novel.Code;
using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using Label = System.Windows.Forms.Label;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.CodeAnalysis;

namespace Novel.Forms
{
    public partial class F07_Chat : Form
    {
        #region ObjectsCreate
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel5 = new TableLayoutPanel();
        Label label = new Label();
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        PictureBox pictureBox = new PictureBox();
        PictureBox pictureBox1 = new PictureBox();
        TextBox textBox = new TextBox();
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();
        Button button = new Button();
        Button button1 = new Button();
        const string TOKEN = "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";
        OpenAIAPI chatGPT = new OpenAIAPI(TOKEN);
        #endregion

        public F07_Chat(F08_Plot2 input)
        {
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            Plot2 = input;
        }

        public F08_Plot2 Plot2 { get; }


        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            label.Text = Properties.Resources.gameOpponentName;
            pictureBox.Image = Properties.Resources.forest;

            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "k")
            {
                pictureBox1.Image = Properties.Resources.pers1mBig;
                label1.Text = Properties.Resources.heroesKnightMaleName;

            }
            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "m")
            {
                pictureBox1.Image = Properties.Resources.pers2mBig;
                label1.Text = Properties.Resources.heroesMagicianMaleName;
            }
            if (Properties.Settings.Default.gGender == "m" && Properties.Settings.Default.gTypeOfHero == "t")
            {
                pictureBox1.Image = Properties.Resources.pers3mBig;
                label1.Text = Properties.Resources.heroesArcherThiefMaleName;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "k")
            {
                pictureBox1.Image = Properties.Resources.pers1fBig;
                label1.Text = Properties.Resources.heroesKnightFemaleName;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "m")
            {
                pictureBox1.Image = Properties.Resources.pers2fBig;
                label1.Text = Properties.Resources.heroesMagicianFemaleName;
            }
            if (Properties.Settings.Default.gGender == "f" && Properties.Settings.Default.gTypeOfHero == "t")
            {
                pictureBox1.Image = Properties.Resources.pers3fBig;
                label1.Text = Properties.Resources.heroesArcherThiefFemaleName;
            }
            label1.Text += " " + Properties.Settings.Default.gNameOfHero;


            await LabelAnimated.TextAsync(label2, Properties.Resources.chatForest_0);
            await LabelAnimated.TextAsync(label3, Properties.Resources.chatHero_0);
        }


      
        #region Events

        private void EnterSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Request();
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {
                Request();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {
                Plot2.Show();
                Hide();
            }
        }
        #endregion

        async Task GetResponse(CompletionRequest request)
        {
            var response = await chatGPT.Completions.CreateCompletionAsync(request);
            await ShowResponse(response.Completions[0].Text, label2);
        }

        async Task ShowResponse(string text, Label label)
        {
            await LabelAnimated.TextAsync(label, text);

        }

        async void Request()
        {

            string sentence = "Уявіть, що ви стародавній мудрий ліс який все знає в світі " + textBox2.Text;
            CompletionRequest completionRequest = new CompletionRequest();
            completionRequest.Prompt = sentence;
            completionRequest.Model = Model.DavinciText;
            completionRequest.MaxTokens = 500;

            await LabelAnimated.TextAsync(label3, textBox2.Text);
            textBox2.Text = "";

            await GetResponse(completionRequest);

        }

        

    }
}
