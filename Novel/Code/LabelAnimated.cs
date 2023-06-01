using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novel.Code
{
    internal class LabelAnimated
    {
        public static async Task TextAsync(Label label, string? text)
        {
            Properties.Settings.Default.gIsRunning = true;
            textClear(label);


            if (text != null)
            {
                foreach (char c in text)
                {
                    label.Text += c;
                    await Task.Delay(30); // Затримка між символами
                    Application.DoEvents(); // Оновлення форми для відображення нового символу
                }
            }
            Properties.Settings.Default.gIsRunning = false;
        }

        public static async Task TextAsync(TextBox textBox, string? text)
        {
            Properties.Settings.Default.gIsRunning = true;
            textClear(textBox);
            if (text != null)
            {
                foreach (char c in text)
                {
                    textBox.Text += c;
                    await Task.Delay(30); // Затримка між символами
                    Application.DoEvents(); // Оновлення форми для відображення нового символу

                }
            }
            Properties.Settings.Default.gIsRunning = false;
        }



        public static TextBox textClear(TextBox textBox)
        {
            textBox.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleCenter;
            textBox.Text = "";
            textBox.Padding = Padding.Empty;
            return textBox;
        }

        public static Label textClear(Label label)
        {
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "";
            label.Padding = Padding.Empty;
            return label;
        }

    }
}
