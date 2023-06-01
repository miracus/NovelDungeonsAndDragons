using System.Windows.Forms;

namespace Novel.Forms
{
    partial class F02_ChoiceHero
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
            // F02_ChoiceHero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "F02_ChoiceHero";
            Text = "F02_ChoiceHero";
            ResumeLayout(false);

            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Name = "picture";
            pictureBox.Click += new EventHandler(pictureBox_Click);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Name = "picture1";
            pictureBox1.Click += new EventHandler(pictureBox_Click);

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Name = "picture2";
            pictureBox2.Click += new EventHandler(pictureBox_Click);

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Name = "picture3";
            pictureBox3.Click += new EventHandler(pictureBox_Click);

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Name = "picture4";
            pictureBox4.Click += new EventHandler(pictureBox_Click);

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Name = "picture5";
            pictureBox5.Click += new EventHandler(pictureBox_Click);

            label.Font = new Font("Palatino Linotype", 15);
            label.ForeColor = Color.Sienna;
            label.Name = "label";
            label.Size = this.ClientSize;
            Size size = pictureBox1.Size;

            tooltip.SetToolTip(pictureBox, Properties.Resources.heroesKnightMaleDescription);
            tooltip.SetToolTip(pictureBox1, Properties.Resources.heroesMagicianMaleDescription);
            tooltip.SetToolTip(pictureBox2, Properties.Resources.heroesArcherThiefMaleDescription);
            tooltip.SetToolTip(pictureBox3, Properties.Resources.heroesKnightFemaleDescription);
            tooltip.SetToolTip(pictureBox4, Properties.Resources.heroesMagicianFemaleDescription);
            tooltip.SetToolTip(pictureBox5, Properties.Resources.heroesArcherThiefFemaleDescription);

            tableLayoutPanel1.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox5, 2, 1);

            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel.Controls.Add(label, 1, 0);

            this.Controls.Add(tableLayoutPanel);
            this.Hide();

        }

        #endregion
    }
}