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
            buttonOrdreSearch = new Button();
            dataGridViewOrdre = new DataGridView();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            buttonUpdate = new Button();
            textBoxInfo = new TextBox();
            textBoxDato = new TextBox();
            textBoxLev = new TextBox();
            Info = new Label();
            Dato = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 129);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Søg Kunde";
            // 
            // buttonOrdreSearch
            // 
            buttonOrdreSearch.BackColor = Color.FromArgb(255, 161, 0);
            buttonOrdreSearch.Location = new Point(32, 178);
            buttonOrdreSearch.Margin = new Padding(4, 2, 4, 2);
            buttonOrdreSearch.Name = "buttonOrdreSearch";
            buttonOrdreSearch.Size = new Size(118, 38);
            buttonOrdreSearch.TabIndex = 2;
            buttonOrdreSearch.Text = "Søg";
            buttonOrdreSearch.UseVisualStyleBackColor = false;
            buttonOrdreSearch.Click += buttonOrdreSearch_Click;
            // 
            // dataGridViewOrdre
            // 
            dataGridViewOrdre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrdre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrdre.Location = new Point(341, 178);
            dataGridViewOrdre.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOrdre.Name = "dataGridViewOrdre";
            dataGridViewOrdre.RowHeadersWidth = 62;
            dataGridViewOrdre.Size = new Size(648, 426);
            dataGridViewOrdre.TabIndex = 4;
            dataGridViewOrdre.CellContentClick += dataGridViewOrdre_CellContentClick;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Location = new Point(61, 548);
            buttonBack.Margin = new Padding(2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(160, 56);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(916, 13);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(255, 161, 0);
            buttonUpdate.Location = new Point(182, 178);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(118, 38);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(34, 275);
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(69, 23);
            textBoxInfo.TabIndex = 7;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(213, 275);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.Size = new Size(69, 23);
            textBoxDato.TabIndex = 8;
            // 
            // textBoxLev
            // 
            textBoxLev.Location = new Point(122, 275);
            textBoxLev.Name = "textBoxLev";
            textBoxLev.Size = new Size(69, 23);
            textBoxLev.TabIndex = 9;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Location = new Point(42, 251);
            Info.Name = "Info";
            Info.Size = new Size(28, 15);
            Info.TabIndex = 10;
            Info.Text = "Info";
            // 
            // Dato
            // 
            Dato.AutoSize = true;
            Dato.Location = new Point(135, 251);
            Dato.Name = "Dato";
            Dato.Size = new Size(32, 15);
            Dato.TabIndex = 11;
            Dato.Text = "Dato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 251);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 12;
            label4.Text = "Leverandør";
            // 
            // OrdreMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 661);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(Dato);
            Controls.Add(Info);
            Controls.Add(textBoxLev);
            Controls.Add(textBoxDato);
            Controls.Add(textBoxInfo);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewOrdre);
            Controls.Add(buttonOrdreSearch);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(1050, 700);
            Name = "OrdreMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OrdreMenu";
            Load += OrdreMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonOrdreSearch;
        private DataGridView dataGridViewOrdre;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private Button buttonUpdate;
        private TextBox textBoxInfo;
        private TextBox textBoxDato;
        private TextBox textBoxLev;
        private Label Info;
        private Label Dato;
        private Label label4;
    }
}