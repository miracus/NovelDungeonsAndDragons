namespace Novel.Forms
{
    partial class F09_ChoiceStory
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
            this.Text = "F09_ChoiceStory";

            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Name = "picture";

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

            tooltip.SetToolTip(pictureBox1, "");
            tooltip.SetToolTip(pictureBox2, "");
            tooltip.SetToolTip(pictureBox3, "");

            label.Dock = DockStyle.Fill;
            label.Font = new Font("Palatino Linotype", 15);
            label.ForeColor = Color.Sienna;
            label.Name = "label";
            label.Size = this.ClientSize;

            //System.Drawing.Image image = GetImageFromBytes.action(Properties.Resources.board1);
            //System.Drawing.Image image1 = Properties.Resources.storyPic_1;
            //pictureBox.Image = image1;
            //pictureBox1.Image = image;
            //pictureBox2.Image = image;
            //pictureBox3.Image = image;

            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox3, 2, 0);

            tableLayoutPanel1.Controls.Add(label, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox, 0, 0);

            tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 0);
            this.Controls.Add(tableLayoutPanel);
            this.Hide();
        }

        #endregion
    }
}