using System.Windows.Forms;

namespace Novel.Forms
{
    partial class F03_InputName
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
            SuspendLayout();
            // 
            // F03_InputName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "F03_InputName";
            Text = "F03_InputName";
            ResumeLayout(false);

            //this.components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Text = "F03_InputName";

            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;


            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Name = "picture";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Name = "picture1";

            textBox.Text = "Робі Кас";
            textBox.Anchor = AnchorStyles.Bottom;
            textBox.Dock = DockStyle.Fill;
            textBox.TextAlign = HorizontalAlignment.Center;


            button.Text = "ОК";
            button.Dock = DockStyle.Fill;
            button.Click += new EventHandler(button_Click);

            label.Font = new Font("Palatino Linotype", 15);
            label.ForeColor = Color.Sienna;
            label.Size = this.ClientSize;

            System.Drawing.Image image = GetImageFromBytes.action(Properties.Resources.board1);
            pictureBox.Image = image;
            pictureBox1.Image = image;

            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(button, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);

            tableLayoutPanel2.Controls.Add(label, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox, 0, 1);

            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel.Controls.Add(pictureBox, 0, 0);

            this.Controls.Add(tableLayoutPanel);
            this.Hide();

        }

        #endregion
    }
}