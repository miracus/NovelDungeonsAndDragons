using Novel.Forms;

namespace Novel
{
    public partial class Main : Form
    {
        # region ObjectsCreate
        private F01_Start? eStart;
        private F02_ChoiceHero? eChoiceHero;
        private F03_InputName? eInputName;
        private F04_Plot1? ePlot1;
        private F05_Game1? eGame1;
        private F06_Game2? eGame2;
        private F07_Chat? eChat;
        private F08_Plot2? ePlot2;
        private F09_ChoiceStory? eChoiceStory;
        private F10_MainPlot? eMainPlot;
        #endregion

        public Main()
        {
            InitializeComponent();

            var vMainPlot = F10_mMainPlot();
            var vChoiceStory =  F09_mChoiceStory(vMainPlot);
            var vPlot2 = F08_mPlot2(vChoiceStory);
            var vChat =  F07_mChat(vPlot2);
            var vGame2 = F06_mGame2(vChat);
            var vGame1 = F05_mGame1(vGame2);
            var vPlot1 = F04_mPlot1(vGame1);
            var vInputName = F03_mInputName(vPlot1);
            var vChoiceHero = F02_mChoiceHero(vInputName);
            F01_mStart(vChoiceHero);
            this.KeyPreview = true;



        }
        #region MethodCreate
        private void F01_mStart(F02_ChoiceHero input)
        {
            eStart = new F01_Start(input);
            eStart.TopLevel = false;
            eStart.FormBorderStyle = FormBorderStyle.None;
            eStart.Dock = DockStyle.Fill;
            eStart.Opacity = 0;
            this.Controls.Add(eStart);
            eStart.Show();

        }

        private F02_ChoiceHero F02_mChoiceHero(F03_InputName input)
        {
            eChoiceHero = new F02_ChoiceHero(input);
            eChoiceHero.TopLevel = false;
            eChoiceHero.FormBorderStyle = FormBorderStyle.None;
            eChoiceHero.Dock = DockStyle.Fill;
            eChoiceHero.Opacity = 0;
            this.Controls.Add(eChoiceHero);
            return eChoiceHero;
        }


        private F03_InputName F03_mInputName(F04_Plot1 input)
        {
            eInputName = new F03_InputName(input);
            eInputName.TopLevel = false;
            eInputName.FormBorderStyle = FormBorderStyle.None;
            eInputName.Dock = DockStyle.Fill;
            eInputName.Opacity = 0;
            this.Controls.Add(eInputName);
            return eInputName;
        }

        private F04_Plot1 F04_mPlot1(F05_Game1 input)
        {
            ePlot1 = new F04_Plot1(input);
            ePlot1.TopLevel = false;
            ePlot1.FormBorderStyle = FormBorderStyle.None;
            ePlot1.Dock = DockStyle.Fill;
            ePlot1.Opacity = 0;
            this.Controls.Add(ePlot1);
            return ePlot1;
        }

        private F05_Game1 F05_mGame1(F06_Game2 input)
        {
            eGame1 = new F05_Game1(input);
            eGame1.TopLevel = false;
            eGame1.FormBorderStyle = FormBorderStyle.None;
            eGame1.Dock = DockStyle.Fill;
            eGame1.Opacity = 0;
            this.Controls.Add(eGame1);
            return eGame1;
        }

        private F06_Game2 F06_mGame2(F07_Chat input)
        {
            eGame2 = new F06_Game2(input);
            eGame2.TopLevel = false;
            eGame2.FormBorderStyle = FormBorderStyle.None;
            eGame2.Dock = DockStyle.Fill;
            eGame2.Opacity = 0;
            this.Controls.Add(eGame2);
            return eGame2;
        }


        private F07_Chat F07_mChat(F08_Plot2 input)
        {
            eChat = new F07_Chat(input);
            eChat.TopLevel = false;
            eChat.FormBorderStyle = FormBorderStyle.None;
            eChat.Dock = DockStyle.Fill;
            eChat.Opacity = 0;
            this.Controls.Add(eChat);
            return eChat;
        }


        private F08_Plot2 F08_mPlot2(F09_ChoiceStory input)
        {
            ePlot2 = new F08_Plot2(input);
            ePlot2.TopLevel = false;
            ePlot2.FormBorderStyle = FormBorderStyle.None;
            ePlot2.Dock = DockStyle.Fill;
            ePlot2.Opacity = 0;
            this.Controls.Add(ePlot2);
            return ePlot2;
        }

        private F09_ChoiceStory F09_mChoiceStory(F10_MainPlot input)
        {
            eChoiceStory = new F09_ChoiceStory(input);
            eChoiceStory.TopLevel = false;
            eChoiceStory.FormBorderStyle = FormBorderStyle.None;
            eChoiceStory.Dock = DockStyle.Fill;
            eChoiceStory.Opacity = 0;
            this.Controls.Add(eChoiceStory);
            return eChoiceStory;
        }

        private F10_MainPlot F10_mMainPlot()
        {
            eMainPlot = new F10_MainPlot();
            eMainPlot.TopLevel = false;
            eMainPlot.FormBorderStyle = FormBorderStyle.None;
            eMainPlot.Dock = DockStyle.Fill;
            eMainPlot.Opacity = 0;
            this.Controls.Add(eMainPlot);
            return eMainPlot;
        }
        #endregion

    }
}