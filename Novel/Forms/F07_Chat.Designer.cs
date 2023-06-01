namespace Novel.Forms
{
    partial class F07_Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "F07_Chat";

            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            label.Dock = DockStyle.Fill;
            label1.Dock = DockStyle.Fill;
            label.Size = this.ClientSize;
            label1.Size = this.ClientSize;

            label2.Dock = DockStyle.Fill;
            label2.BackColor = Color.White;
            label2.Size = this.ClientSize;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;



            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);


            label3.Dock = DockStyle.Fill;
            label3.BackColor = Color.White;
            label3.Size = this.ClientSize;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            tableLayoutPanel4.Controls.Add(label, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox, 1, 0);

            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(pictureBox1, 1, 0);

            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);

            button.Name = "Send";
            button.Text = "Send";
            button.UseVisualStyleBackColor = true;
            button.Dock = DockStyle.Fill;
            button.Click += new EventHandler(buttonSend_Click);

            button1.Name = "Exit";
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Dock = DockStyle.Fill;
            button1.Click += new EventHandler(buttonExit_Click);

            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font(textBox2.Font.FontFamily, 12);
            textBox2.KeyUp += EnterSend_KeyUp;

            tableLayoutPanel3.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(button, 1, 0);
            tableLayoutPanel3.Controls.Add(button1, 2, 0);

            tableLayoutPanel.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            this.Controls.Add(tableLayoutPanel);

        }


        #endregion
    }
}