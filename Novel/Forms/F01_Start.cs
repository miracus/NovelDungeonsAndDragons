using Novel.Code;
using System.Diagnostics.CodeAnalysis;
using System.Media;
using Label = System.Windows.Forms.Label;

namespace Novel.Forms
{
    public partial class F01_Start : Form
    {

        #region ObjectsCreate
        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        PictureBox pictureBox = new PictureBox();
        Label label = new Label();
        private int step;
        private SoundPlayer player = new SoundPlayer();

        #endregion

        public F01_Start(F02_ChoiceHero input)
        {
            //Properties.Settings.Default.gTest = true; // для тестування
            InitializeComponent();
            Shown += new EventHandler(MyForm_Shown);
            ChoiceHero = input;
            SoundPlay.Play(Properties.Resources.StartSound);
            
        }
        public F02_ChoiceHero ChoiceHero { get; }

        public async void MyForm_Shown([AllowNull] object sender, EventArgs e)
        {
            pictureBox.Image = GetImageFromBytes.action(Properties.Resources.board1);
            await LabelAnimated.TextAsync(label, Properties.Resources.sentenceCommon_0);
            
            step = 1;
        }
 

        private async void pictureBox_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.gIsRunning)
            {
                if (Properties.Settings.Default.gTest) step = 5; // для тестування
                if (step == 5)
                {
                    SoundPlay.Stop(Properties.Resources.StartSound);

                    step = 0;
                    ChoiceHero.Show();
                    this.Hide();
                }
                object? text = Properties.Resources.ResourceManager.GetObject("sentenceCommon_" + step);
                await LabelAnimated.TextAsync(label, text?.ToString());
                step++;
            }
        }

    }
}
