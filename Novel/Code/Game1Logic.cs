using Novel.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel
{
    public class Game1Logic
    {

        private string robot = "X";
        private string player = "0";
        private Form mainForm;
        public Game1Logic(Form form)
        {
            mainForm = form;
        }

        public bool PlayGame(Button buttonGame, Button[] buttons, Label[] labels)
        {
            if (CheckWin(buttonGame.Text, buttons, labels))
            {
                if (buttonGame.Text == robot && !Properties.Settings.Default.gGameWin)
                {
                    labels[0].Text = Properties.Resources.game_5;
                    labels[1].Text = Properties.Resources.game_6;
                    labels[2].Text = Properties.Resources.game_7;
                    labels[3].Text = Properties.Resources.game_8;

                    MessageBox.Show(Properties.Resources.gameLose);
                    Properties.Settings.Default.gGameWin = false;
                    ClearField(buttons);
                    return true;
                }
                if (buttonGame.Text == player && !Properties.Settings.Default.gGameWin)
                {
                    labels[0].Text = Properties.Resources.game_9;
                    labels[1].Text = Properties.Resources.game_10;
                    labels[2].Text = Properties.Resources.game_11;
                    labels[3].Text = Properties.Resources.game_12;

                    MessageBox.Show(Properties.Resources.game1Win);
                    Properties.Settings.Default.gGameWin = true;
                    return true;
                }
            }

            if (FullField(buttons) && !Properties.Settings.Default.gGameWin)
            {
                labels[0].Text = Properties.Resources.game_13;
                labels[1].Text = Properties.Resources.game_14;
                labels[2].Text = Properties.Resources.game_15;
                labels[3].Text = Properties.Resources.game_16;

                MessageBox.Show(Properties.Resources.gameDraw);
                Properties.Settings.Default.gGameWin = false;
                ClearField(buttons);
            }

            return true;
        }


        public void MoveRobot(Button[] buttons, Label[] labels)
        {
            List<Button> emptyButtons = new List<Button>();

            foreach (Button button in buttons)
            {
                if (button.Text == string.Empty)
                {
                    emptyButtons.Add(button);
                }
            }

            // Перевірити, чи є порожні кнопки
            if (emptyButtons.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, emptyButtons.Count);
                Button randomButton = emptyButtons[randomIndex];
                randomButton.Text = robot;
                if (randomButton.Text == robot) randomButton.ForeColor = Color.Green;
                PlayGame(randomButton, buttons, labels);
            }
            SoundPlay.Play(Properties.Resources.Button);
        }

        public void ClearField(Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.BackColor = Color.Transparent;
            }
        }

        public bool FullField(Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                if (button.Text == string.Empty)
                {
                    return false;
                }
            }

            return true;
        }


        bool CheckWin(string symbol, Button[] buttons, Label[] labels)
        {
            int[,] winConditions = new int[,]
            {
                { 0, 1, 2 }, // Перевірка рядків
                { 3, 4, 5 },
                { 6, 7, 8 },
                { 0, 3, 6 }, // Перевірка стовпців
                { 1, 4, 7 },
                { 2, 5, 8 },
                { 0, 4, 8 }, // Перевірка діагоналей
                { 2, 4, 6 }
            };

            foreach (int i in Enumerable.Range(0, winConditions.GetLength(0)))
            {
                int pos1 = winConditions[i, 0];
                int pos2 = winConditions[i, 1];
                int pos3 = winConditions[i, 2];

                if (buttons[pos1].Text == symbol && buttons[pos2].Text == symbol && buttons[pos3].Text == symbol)
                {
                    buttons[pos1].BackColor = Color.Orange;
                    buttons[pos2].BackColor = Color.Orange;
                    buttons[pos3].BackColor = Color.Orange;

                    return true;
                }
            }
            return false;
        }
    }
}
