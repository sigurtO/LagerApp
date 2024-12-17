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
            textBox1 = new TextBox();
            label1 = new Label();
            buttonOrdreSearch = new Button();
            dataGridViewOrdre = new DataGridView();
            buttonBack = new Button();
            buttonUpdate = new Button();
            textBoxInfo = new TextBox();
            textBoxDato = new TextBox();
            textBoxLev = new TextBox();
            Info = new Label();
            Dato = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 80);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 63);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Søg Kunde";
            // 
            // buttonOrdreSearch
            // 
            buttonOrdreSearch.Location = new Point(43, 106);
            buttonOrdreSearch.Margin = new Padding(3, 2, 3, 2);
            buttonOrdreSearch.Name = "buttonOrdreSearch";
            buttonOrdreSearch.Size = new Size(82, 22);
            buttonOrdreSearch.TabIndex = 2;
            buttonOrdreSearch.Text = "Søg";
            buttonOrdreSearch.UseVisualStyleBackColor = true;
            buttonOrdreSearch.Click += buttonOrdreSearch_Click;
            // 
            // dataGridViewOrdre
            // 
            dataGridViewOrdre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrdre.Location = new Point(340, 16);
            dataGridViewOrdre.Name = "dataGridViewOrdre";
            dataGridViewOrdre.RowHeadersWidth = 62;
            dataGridViewOrdre.Size = new Size(498, 284);
            dataGridViewOrdre.TabIndex = 4;
            dataGridViewOrdre.CellContentClick += dataGridViewOrdre_CellContentClick;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(43, 300);
            buttonBack.Margin = new Padding(2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(79, 20);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(183, 106);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(82, 22);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(35, 175);
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(69, 23);
            textBoxInfo.TabIndex = 7;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(223, 175);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.Size = new Size(69, 23);
            textBoxDato.TabIndex = 8;
            // 
            // textBoxLev
            // 
            textBoxLev.Location = new Point(128, 175);
            textBoxLev.Name = "textBoxLev";
            textBoxLev.Size = new Size(69, 23);
            textBoxLev.TabIndex = 9;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Location = new Point(43, 151);
            Info.Name = "Info";
            Info.Size = new Size(28, 15);
            Info.TabIndex = 10;
            Info.Text = "Info";
            // 
            // Dato
            // 
            Dato.AutoSize = true;
            Dato.Location = new Point(141, 151);
            Dato.Name = "Dato";
            Dato.Size = new Size(32, 15);
            Dato.TabIndex = 11;
            Dato.Text = "Dato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 151);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 12;
            label4.Text = "Leverandør";
            // 
            // OrdreMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 346);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 385);
            Name = "OrdreMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OrdreMenu";
            Load += OrdreMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonOrdreSearch;
        private DataGridView dataGridViewOrdre;
        private Button buttonBack;
        private Button buttonUpdate;
        private TextBox textBoxInfo;
        private TextBox textBoxDato;
        private TextBox textBoxLev;
        private Label Info;
        private Label Dato;
        private Label label4;
    }
}