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
            buttonProductSearch = new Button();
            label1 = new Label();
            buttonAdd = new Button();
            textBoxProID = new TextBox();
            label2 = new Label();
            textBoxNavn = new TextBox();
            textBoxAntal = new TextBox();
            textBoxSalgsID = new TextBox();
            textBoxMaal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxVaegt = new TextBox();
            textBoxBeskriv = new TextBox();
            textBoxDato = new TextBox();
            textBoxMinbehold = new TextBox();
            textBoxMaxbehold = new TextBox();
            textBoxMoebeltype = new TextBox();
            textBoxMaterialer = new TextBox();
            textBoxKostpris = new TextBox();
            textBoxSalgspris = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBoxProduktsøgning = new TextBox();
            dataGridViewProdukter = new DataGridView();
            button1Update = new Button();
            buttonExportToCVS = new Button();
            buttonBack = new Button();
            buttonFjernProdukt = new Button();
            textBoxFjernProdukt = new TextBox();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukter).BeginInit();
            SuspendLayout();
            // 
            // buttonProductSearch
            // 
            buttonProductSearch.Location = new Point(407, 123);
            buttonProductSearch.Margin = new Padding(3, 2, 3, 2);
            buttonProductSearch.Name = "buttonProductSearch";
            buttonProductSearch.Size = new Size(83, 22);
            buttonProductSearch.TabIndex = 1;
            buttonProductSearch.Text = "Søg";
            buttonProductSearch.UseVisualStyleBackColor = true;
            buttonProductSearch.Click += buttonProductSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 58);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Søg i Lager";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(109, 304);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(83, 22);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Tilføj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxProID
            // 
            textBoxProID.Location = new Point(32, 26);
            textBoxProID.Margin = new Padding(3, 2, 3, 2);
            textBoxProID.Name = "textBoxProID";
            textBoxProID.Size = new Size(52, 23);
            textBoxProID.TabIndex = 4;
            textBoxProID.TextChanged += textBoxNavn_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 7);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "ProduktID";
            label2.Click += label2_Click;
            // 
            // textBoxNavn
            // 
            textBoxNavn.Location = new Point(116, 26);
            textBoxNavn.Margin = new Padding(3, 2, 3, 2);
            textBoxNavn.Name = "textBoxNavn";
            textBoxNavn.Size = new Size(110, 23);
            textBoxNavn.TabIndex = 6;
            // 
            // textBoxAntal
            // 
            textBoxAntal.Location = new Point(32, 150);
            textBoxAntal.Margin = new Padding(3, 2, 3, 2);
            textBoxAntal.Name = "textBoxAntal";
            textBoxAntal.Size = new Size(50, 23);
            textBoxAntal.TabIndex = 7;
            // 
            // textBoxSalgsID
            // 
            textBoxSalgsID.Location = new Point(32, 69);
            textBoxSalgsID.Margin = new Padding(3, 2, 3, 2);
            textBoxSalgsID.Name = "textBoxSalgsID";
            textBoxSalgsID.Size = new Size(52, 23);
            textBoxSalgsID.TabIndex = 8;
            // 
            // textBoxMaal
            // 
            textBoxMaal.Location = new Point(141, 150);
            textBoxMaal.Margin = new Padding(3, 2, 3, 2);
            textBoxMaal.Name = "textBoxMaal";
            textBoxMaal.Size = new Size(52, 23);
            textBoxMaal.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 6);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 10;
            label3.Text = "Navn";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 54);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "SalgsID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 133);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Antal";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 131);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 13;
            label6.Text = "Mål";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 92);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 14;
            label7.Text = "Vægt";
            // 
            // textBoxVaegt
            // 
            textBoxVaegt.Location = new Point(32, 109);
            textBoxVaegt.Margin = new Padding(3, 2, 3, 2);
            textBoxVaegt.Name = "textBoxVaegt";
            textBoxVaegt.Size = new Size(52, 23);
            textBoxVaegt.TabIndex = 15;
            textBoxVaegt.TextChanged += textBox2_TextChanged;
            // 
            // textBoxBeskriv
            // 
            textBoxBeskriv.Location = new Point(116, 69);
            textBoxBeskriv.Margin = new Padding(3, 2, 3, 2);
            textBoxBeskriv.Name = "textBoxBeskriv";
            textBoxBeskriv.Size = new Size(110, 23);
            textBoxBeskriv.TabIndex = 16;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(141, 190);
            textBoxDato.Margin = new Padding(3, 2, 3, 2);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.Size = new Size(52, 23);
            textBoxDato.TabIndex = 17;
            // 
            // textBoxMinbehold
            // 
            textBoxMinbehold.Location = new Point(32, 190);
            textBoxMinbehold.Margin = new Padding(3, 2, 3, 2);
            textBoxMinbehold.Name = "textBoxMinbehold";
            textBoxMinbehold.Size = new Size(50, 23);
            textBoxMinbehold.TabIndex = 18;
            // 
            // textBoxMaxbehold
            // 
            textBoxMaxbehold.Location = new Point(146, 228);
            textBoxMaxbehold.Margin = new Padding(3, 2, 3, 2);
            textBoxMaxbehold.Name = "textBoxMaxbehold";
            textBoxMaxbehold.Size = new Size(45, 23);
            textBoxMaxbehold.TabIndex = 19;
            // 
            // textBoxMoebeltype
            // 
            textBoxMoebeltype.Location = new Point(32, 228);
            textBoxMoebeltype.Margin = new Padding(3, 2, 3, 2);
            textBoxMoebeltype.Name = "textBoxMoebeltype";
            textBoxMoebeltype.Size = new Size(50, 23);
            textBoxMoebeltype.TabIndex = 20;
            // 
            // textBoxMaterialer
            // 
            textBoxMaterialer.Location = new Point(116, 109);
            textBoxMaterialer.Margin = new Padding(3, 2, 3, 2);
            textBoxMaterialer.Name = "textBoxMaterialer";
            textBoxMaterialer.Size = new Size(110, 23);
            textBoxMaterialer.TabIndex = 21;
            // 
            // textBoxKostpris
            // 
            textBoxKostpris.Location = new Point(32, 266);
            textBoxKostpris.Margin = new Padding(3, 2, 3, 2);
            textBoxKostpris.Name = "textBoxKostpris";
            textBoxKostpris.Size = new Size(45, 23);
            textBoxKostpris.TabIndex = 22;
            // 
            // textBoxSalgspris
            // 
            textBoxSalgspris.Location = new Point(148, 266);
            textBoxSalgspris.Margin = new Padding(3, 2, 3, 2);
            textBoxSalgspris.Name = "textBoxSalgspris";
            textBoxSalgspris.Size = new Size(45, 23);
            textBoxSalgspris.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 54);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 24;
            label8.Text = "Beskrivelse";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 172);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 25;
            label9.Text = "Dato";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 172);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 26;
            label10.Text = "Minbeholdning";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(116, 211);
            label11.Name = "label11";
            label11.Size = new Size(96, 15);
            label11.TabIndex = 27;
            label11.Text = "Maksbeholdning";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 211);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 28;
            label12.Text = "Moebeltype";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(130, 92);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 29;
            label13.Text = "Materialer";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 250);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 30;
            label14.Text = "Kostpris";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(139, 249);
            label15.Name = "label15";
            label15.Size = new Size(53, 15);
            label15.TabIndex = 31;
            label15.Text = "Salgspris";
            // 
            // textBoxProduktsøgning
            // 
            textBoxProduktsøgning.Location = new Point(496, 84);
            textBoxProduktsøgning.Name = "textBoxProduktsøgning";
            textBoxProduktsøgning.Size = new Size(101, 23);
            textBoxProduktsøgning.TabIndex = 33;
            // 
            // dataGridViewProdukter
            // 
            dataGridViewProdukter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdukter.Location = new Point(310, 173);
            dataGridViewProdukter.Name = "dataGridViewProdukter";
            dataGridViewProdukter.RowHeadersWidth = 51;
            dataGridViewProdukter.Size = new Size(286, 160);
            dataGridViewProdukter.TabIndex = 34;
            // 
            // button1Update
            // 
            button1Update.Location = new Point(206, 304);
            button1Update.Margin = new Padding(3, 2, 3, 2);
            button1Update.Name = "button1Update";
            button1Update.Size = new Size(83, 22);
            button1Update.TabIndex = 35;
            button1Update.Text = "Opdater";
            button1Update.UseVisualStyleBackColor = true;
            button1Update.Click += button1Update_Click;
            // 
            // buttonExportToCVS
            // 
            buttonExportToCVS.Location = new Point(514, 123);
            buttonExportToCVS.Margin = new Padding(3, 2, 3, 2);
            buttonExportToCVS.Name = "buttonExportToCVS";
            buttonExportToCVS.Size = new Size(83, 22);
            buttonExportToCVS.TabIndex = 36;
            buttonExportToCVS.Text = "Export CVS";
            buttonExportToCVS.UseVisualStyleBackColor = true;
            buttonExportToCVS.Click += buttonExportToCVS_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(18, 305);
            buttonBack.Margin = new Padding(2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(78, 20);
            buttonBack.TabIndex = 37;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonFjernProdukt
            // 
            buttonFjernProdukt.Location = new Point(310, 122);
            buttonFjernProdukt.Name = "buttonFjernProdukt";
            buttonFjernProdukt.Size = new Size(75, 23);
            buttonFjernProdukt.TabIndex = 38;
            buttonFjernProdukt.Text = "Fjern";
            buttonFjernProdukt.UseVisualStyleBackColor = true;
            buttonFjernProdukt.Click += buttonFjernProdukt_Click;
            // 
            // textBoxFjernProdukt
            // 
            textBoxFjernProdukt.Location = new Point(311, 88);
            textBoxFjernProdukt.Name = "textBoxFjernProdukt";
            textBoxFjernProdukt.Size = new Size(100, 23);
            textBoxFjernProdukt.TabIndex = 39;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(310, 58);
            label16.Name = "label16";
            label16.Size = new Size(82, 15);
            label16.TabIndex = 40;
            label16.Text = "Fjern fra Lager";
            // 
            // LagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 339);
            Controls.Add(label16);
            Controls.Add(textBoxFjernProdukt);
            Controls.Add(buttonFjernProdukt);
            Controls.Add(buttonBack);
            Controls.Add(buttonExportToCVS);
            Controls.Add(button1Update);
            Controls.Add(dataGridViewProdukter);
            Controls.Add(textBoxProduktsøgning);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxSalgspris);
            Controls.Add(textBoxKostpris);
            Controls.Add(textBoxMaterialer);
            Controls.Add(textBoxMoebeltype);
            Controls.Add(textBoxMaxbehold);
            Controls.Add(textBoxMinbehold);
            Controls.Add(textBoxDato);
            Controls.Add(textBoxBeskriv);
            Controls.Add(textBoxVaegt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxMaal);
            Controls.Add(textBoxSalgsID);
            Controls.Add(textBoxAntal);
            Controls.Add(textBoxNavn);
            Controls.Add(label2);
            Controls.Add(textBoxProID);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(buttonProductSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LagerMenu";
            Text = "Antal";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProduktsøgning;
        private Button buttonProductSearch;
        private Button buttonProduktSearch;
        private Label label1;
        private Button buttonAdd;
        private TextBox textBoxProID;
        private Label label2;
        private TextBox textBoxNavn;
        private TextBox textBoxAntal;
        private TextBox textBoxSalgsID;
        private TextBox textBoxMaal;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
		private Label label7;
		private TextBox textBoxVaegt;
		private TextBox textBoxBeskriv;
		private TextBox textBoxDato;
		private TextBox textBoxMinbehold;
		private TextBox textBoxMaxbehold;
		private TextBox textBoxMoebeltype;
		private TextBox textBoxMaterialer;
		private TextBox textBoxKostpris;
		private TextBox textBoxSalgspris;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private Button buttonUpdate;
        private DataGridView dataGridViewProdukter;
        private Button button1Update;
        private Button buttonExportToCVS;
        private Button buttonBack;
        private Button buttonFjernProdukt;
        private TextBox textBoxFjernProdukt;
        private Label label16;
    }

}