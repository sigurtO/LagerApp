namespace LagerApp_final_
{
    partial class OrdreMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdreMenu));
            textBox1 = new TextBox();
            label1 = new Label();
<<<<<<< Updated upstream
            buttonLagerSearch = new Button();
=======
            buttonOrdreSearch = new Button();
            dataGridViewOrdre = new DataGridView();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // textBox1
            // 
<<<<<<< Updated upstream
            textBox1.Location = new Point(314, 190);
=======
            textBox1.Location = new Point(61, 132);
            textBox1.Margin = new Padding(4, 2, 4, 2);
>>>>>>> Stashed changes
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< Updated upstream
            label1.Location = new Point(314, 167);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Søg i Ordre";
=======
            label1.Location = new Point(61, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "Søg Kunde";
            label1.Click += label1_Click;
>>>>>>> Stashed changes
            // 
            // buttonLagerSearch
            // 
<<<<<<< Updated upstream
            buttonLagerSearch.Location = new Point(314, 236);
            buttonLagerSearch.Name = "buttonLagerSearch";
            buttonLagerSearch.Size = new Size(94, 29);
            buttonLagerSearch.TabIndex = 2;
            buttonLagerSearch.Text = "Søg";
            buttonLagerSearch.UseVisualStyleBackColor = true;
=======
            buttonOrdreSearch.BackColor = Color.FromArgb(255, 161, 0);
            buttonOrdreSearch.Location = new Point(61, 178);
            buttonOrdreSearch.Margin = new Padding(4, 2, 4, 2);
            buttonOrdreSearch.Name = "buttonOrdreSearch";
            buttonOrdreSearch.Size = new Size(130, 37);
            buttonOrdreSearch.TabIndex = 2;
            buttonOrdreSearch.Text = "Søg";
            buttonOrdreSearch.UseVisualStyleBackColor = false;
            buttonOrdreSearch.Click += buttonOrdreSearch_Click;
            // 
            // dataGridViewOrdre
            // 
            dataGridViewOrdre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrdre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrdre.Location = new Point(480, 150);
            dataGridViewOrdre.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOrdre.Name = "dataGridViewOrdre";
            dataGridViewOrdre.RowHeadersWidth = 62;
            dataGridViewOrdre.Size = new Size(490, 472);
            dataGridViewOrdre.TabIndex = 4;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = Color.White;
            buttonBack.Location = new Point(32, 577);
            buttonBack.Margin = new Padding(2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(128, 45);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
>>>>>>> Stashed changes
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(896, 13);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // OrdreMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLagerSearch);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "OrdreMenu";
            Text = "OrdreMenu";
=======
            ClientSize = new Size(1008, 663);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewOrdre);
            Controls.Add(buttonOrdreSearch);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "OrdreMenu";
            Text = "OrdreMenu";
            Load += OrdreMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
>>>>>>> Stashed changes
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
<<<<<<< Updated upstream
        private Button buttonLagerSearch;
=======
        private Button buttonOrdreSearch;
        private DataGridView dataGridViewOrdre;
        private Button buttonBack;
        private PictureBox pictureBox1;
>>>>>>> Stashed changes
    }
}