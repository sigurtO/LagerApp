namespace LagerApp_final_
{
    partial class LagerMenu
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
            buttonProduktSearch = new Button();
            label1 = new Label();
            buttonAdd = new Button();
            textBoxNavn = new TextBox();
            label2 = new Label();
            textBoxBeskriv = new TextBox();
            textBoxMinLager = new TextBox();
            textBoxDato = new TextBox();
            textBoxMaksLager = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxPris = new TextBox();
            label7 = new Label();
            listBoxProdukt = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(514, 84);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonProduktSearch
            // 
            buttonProduktSearch.Location = new Point(514, 118);
            buttonProduktSearch.Margin = new Padding(3, 2, 3, 2);
            buttonProduktSearch.Name = "buttonProduktSearch";
            buttonProduktSearch.Size = new Size(82, 22);
            buttonProduktSearch.TabIndex = 1;
            buttonProduktSearch.Text = "Søg";
            buttonProduktSearch.UseVisualStyleBackColor = true;
            buttonProduktSearch.Click += buttonProduktSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 58);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Søg i Lager";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(86, 152);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxNavn
            // 
            textBoxNavn.Location = new Point(38, 26);
            textBoxNavn.Margin = new Padding(3, 2, 3, 2);
            textBoxNavn.Name = "textBoxNavn";
            textBoxNavn.Size = new Size(45, 23);
            textBoxNavn.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 7);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Navn";
            // 
            // textBoxBeskriv
            // 
            textBoxBeskriv.Location = new Point(116, 26);
            textBoxBeskriv.Margin = new Padding(3, 2, 3, 2);
            textBoxBeskriv.Name = "textBoxBeskriv";
            textBoxBeskriv.Size = new Size(110, 23);
            textBoxBeskriv.TabIndex = 6;
            // 
            // textBoxMinLager
            // 
            textBoxMinLager.Location = new Point(116, 69);
            textBoxMinLager.Margin = new Padding(3, 2, 3, 2);
            textBoxMinLager.Name = "textBoxMinLager";
            textBoxMinLager.Size = new Size(110, 23);
            textBoxMinLager.TabIndex = 7;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(38, 69);
            textBoxDato.Margin = new Padding(3, 2, 3, 2);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.Size = new Size(45, 23);
            textBoxDato.TabIndex = 8;
            // 
            // textBoxMaksLager
            // 
            textBoxMaksLager.Location = new Point(116, 106);
            textBoxMaksLager.Margin = new Padding(3, 2, 3, 2);
            textBoxMaksLager.Name = "textBoxMaksLager";
            textBoxMaksLager.Size = new Size(110, 23);
            textBoxMaksLager.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 6);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "Beskrivelse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 54);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 11;
            label4.Text = "Dato";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 52);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "MinLager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 92);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 13;
            label6.Text = "MaksLager";
            // 
            // textBoxPris
            // 
            textBoxPris.Location = new Point(29, 106);
            textBoxPris.Margin = new Padding(3, 2, 3, 2);
            textBoxPris.Name = "textBoxPris";
            textBoxPris.Size = new Size(55, 23);
            textBoxPris.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 92);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 15;
            label7.Text = "Pris";
            // 
            // listBoxProdukt
            // 
            listBoxProdukt.FormattingEnabled = true;
            listBoxProdukt.ItemHeight = 15;
            listBoxProdukt.Location = new Point(470, 174);
            listBoxProdukt.Name = "listBoxProdukt";
            listBoxProdukt.Size = new Size(197, 154);
            listBoxProdukt.TabIndex = 16;
            // 
            // LagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(listBoxProdukt);
            Controls.Add(label7);
            Controls.Add(textBoxPris);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxMaksLager);
            Controls.Add(textBoxDato);
            Controls.Add(textBoxMinLager);
            Controls.Add(textBoxBeskriv);
            Controls.Add(label2);
            Controls.Add(textBoxNavn);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(buttonProduktSearch);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LagerMenu";
            Text = "LagerMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonProduktSearch;
        private Label label1;
        private Button buttonAdd;
        private TextBox textBoxNavn;
        private Label label2;
        private TextBox textBoxBeskriv;
        private TextBox textBoxMinLager;
        private TextBox textBoxDato;
        private TextBox textBoxMaksLager;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxPris;
        private Label label7;
        private ListBox listBoxProdukt;
    }
}