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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LagerMenu));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonProductSearch
            // 
            buttonProductSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonProductSearch.BackColor = Color.FromArgb(255, 161, 0);
            buttonProductSearch.Location = new Point(581, 251);
            buttonProductSearch.Margin = new Padding(4);
            buttonProductSearch.Name = "buttonProductSearch";
            buttonProductSearch.Size = new Size(108, 39);
            buttonProductSearch.TabIndex = 1;
            buttonProductSearch.Text = "Søg";
            buttonProductSearch.UseVisualStyleBackColor = false;
            buttonProductSearch.Click += buttonProductSearch_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(581, 175);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Søg i Lager";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(255, 161, 0);
            buttonAdd.Location = new Point(45, 359);
            buttonAdd.Margin = new Padding(4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 36);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Tilføj";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxProID
            // 
            textBoxProID.Location = new Point(46, 44);
            textBoxProID.Margin = new Padding(4);
            textBoxProID.Name = "textBoxProID";
            textBoxProID.Size = new Size(120, 31);
            textBoxProID.TabIndex = 4;
            textBoxProID.TextChanged += textBoxNavn_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 5;
            label2.Text = "ProduktID";
            label2.Click += label2_Click;
            // 
            // textBoxNavn
            // 
            textBoxNavn.Location = new Point(219, 44);
            textBoxNavn.Margin = new Padding(4);
            textBoxNavn.Name = "textBoxNavn";
            textBoxNavn.Size = new Size(120, 31);
            textBoxNavn.TabIndex = 6;
            // 
            // textBoxAntal
            // 
            textBoxAntal.Location = new Point(385, 104);
            textBoxAntal.Margin = new Padding(4);
            textBoxAntal.Name = "textBoxAntal";
            textBoxAntal.Size = new Size(120, 31);
            textBoxAntal.TabIndex = 7;
            // 
            // textBoxSalgsID
            // 
            textBoxSalgsID.Location = new Point(385, 44);
            textBoxSalgsID.Margin = new Padding(4);
            textBoxSalgsID.Name = "textBoxSalgsID";
            textBoxSalgsID.Size = new Size(120, 31);
            textBoxSalgsID.TabIndex = 8;
            // 
            // textBoxMaal
            // 
            textBoxMaal.Location = new Point(45, 303);
            textBoxMaal.Margin = new Padding(4);
            textBoxMaal.Name = "textBoxMaal";
            textBoxMaal.Size = new Size(120, 31);
            textBoxMaal.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 10;
            label3.Text = "Navn";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 11;
            label4.Text = "SalgsID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 12;
            label5.Text = "Antal";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 278);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 25);
            label6.TabIndex = 13;
            label6.Text = "Mål";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 77);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 14;
            label7.Text = "Vægt";
            // 
            // textBoxVaegt
            // 
            textBoxVaegt.Location = new Point(46, 104);
            textBoxVaegt.Margin = new Padding(4);
            textBoxVaegt.Name = "textBoxVaegt";
            textBoxVaegt.Size = new Size(120, 31);
            textBoxVaegt.TabIndex = 15;
            textBoxVaegt.TextChanged += textBox2_TextChanged;
            // 
            // textBoxBeskriv
            // 
            textBoxBeskriv.Location = new Point(219, 303);
            textBoxBeskriv.Margin = new Padding(4);
            textBoxBeskriv.Name = "textBoxBeskriv";
            textBoxBeskriv.Size = new Size(120, 31);
            textBoxBeskriv.TabIndex = 16;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(219, 172);
            textBoxDato.Margin = new Padding(4);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.Size = new Size(120, 31);
            textBoxDato.TabIndex = 17;
            // 
            // textBoxMinbehold
            // 
            textBoxMinbehold.Location = new Point(45, 172);
            textBoxMinbehold.Margin = new Padding(4);
            textBoxMinbehold.Name = "textBoxMinbehold";
            textBoxMinbehold.Size = new Size(120, 31);
            textBoxMinbehold.TabIndex = 18;
            // 
            // textBoxMaxbehold
            // 
            textBoxMaxbehold.Location = new Point(45, 239);
            textBoxMaxbehold.Margin = new Padding(4);
            textBoxMaxbehold.Name = "textBoxMaxbehold";
            textBoxMaxbehold.Size = new Size(120, 31);
            textBoxMaxbehold.TabIndex = 19;
            // 
            // textBoxMoebeltype
            // 
            textBoxMoebeltype.Location = new Point(385, 172);
            textBoxMoebeltype.Margin = new Padding(4);
            textBoxMoebeltype.Name = "textBoxMoebeltype";
            textBoxMoebeltype.Size = new Size(120, 31);
            textBoxMoebeltype.TabIndex = 20;
            // 
            // textBoxMaterialer
            // 
            textBoxMaterialer.Location = new Point(219, 104);
            textBoxMaterialer.Margin = new Padding(4);
            textBoxMaterialer.Name = "textBoxMaterialer";
            textBoxMaterialer.Size = new Size(120, 31);
            textBoxMaterialer.TabIndex = 21;
            // 
            // textBoxKostpris
            // 
            textBoxKostpris.Location = new Point(219, 239);
            textBoxKostpris.Margin = new Padding(4);
            textBoxKostpris.Name = "textBoxKostpris";
            textBoxKostpris.Size = new Size(120, 31);
            textBoxKostpris.TabIndex = 22;
            // 
            // textBoxSalgspris
            // 
            textBoxSalgspris.Location = new Point(385, 239);
            textBoxSalgspris.Margin = new Padding(4);
            textBoxSalgspris.Name = "textBoxSalgspris";
            textBoxSalgspris.Size = new Size(120, 31);
            textBoxSalgspris.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 278);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 24;
            label8.Text = "Beskrivelse";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(219, 143);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 25;
            label9.Text = "Dato";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 143);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(133, 25);
            label10.TabIndex = 26;
            label10.Text = "Minbeholdning";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 212);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(145, 25);
            label11.TabIndex = 27;
            label11.Text = "Maksbeholdning";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(385, 143);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(98, 25);
            label12.TabIndex = 28;
            label12.Text = "Møbeltype";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(219, 77);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(90, 25);
            label13.TabIndex = 29;
            label13.Text = "Materialer";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(214, 211);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(76, 25);
            label14.TabIndex = 30;
            label14.Text = "Kostpris";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(385, 213);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(83, 25);
            label15.TabIndex = 31;
            label15.Text = "Salgspris";
            // 
            // textBoxProduktsøgning
            // 
            textBoxProduktsøgning.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxProduktsøgning.Location = new Point(847, 201);
            textBoxProduktsøgning.Margin = new Padding(4, 5, 4, 5);
            textBoxProduktsøgning.Name = "textBoxProduktsøgning";
            textBoxProduktsøgning.Size = new Size(143, 31);
            textBoxProduktsøgning.TabIndex = 33;
            // 
            // dataGridViewProdukter
            // 
            dataGridViewProdukter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProdukter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdukter.Location = new Point(581, 299);
            dataGridViewProdukter.Margin = new Padding(4, 5, 4, 5);
            dataGridViewProdukter.Name = "dataGridViewProdukter";
            dataGridViewProdukter.RowHeadersWidth = 51;
            dataGridViewProdukter.Size = new Size(409, 266);
            dataGridViewProdukter.TabIndex = 34;
            // 
            // button1Update
            // 
            button1Update.BackColor = Color.FromArgb(255, 161, 0);
            button1Update.Location = new Point(183, 359);
            button1Update.Margin = new Padding(4);
            button1Update.Name = "button1Update";
            button1Update.Size = new Size(119, 36);
            button1Update.TabIndex = 35;
            button1Update.Text = "Opdater";
            button1Update.UseVisualStyleBackColor = false;
            button1Update.Click += button1Update_Click;
            // 
            // buttonExportToCVS
            // 
            buttonExportToCVS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportToCVS.BackColor = Color.FromArgb(255, 161, 0);
            buttonExportToCVS.Location = new Point(737, 251);
            buttonExportToCVS.Margin = new Padding(4);
            buttonExportToCVS.Name = "buttonExportToCVS";
            buttonExportToCVS.Size = new Size(108, 39);
            buttonExportToCVS.TabIndex = 36;
            buttonExportToCVS.Text = "Export CVS";
            buttonExportToCVS.UseVisualStyleBackColor = false;
            buttonExportToCVS.Click += buttonExportToCVS_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Location = new Point(12, 558);
            buttonBack.Margin = new Padding(2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(160, 56);
            buttonBack.TabIndex = 37;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonFjernProdukt
            // 
            buttonFjernProdukt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFjernProdukt.BackColor = Color.FromArgb(255, 161, 0);
            buttonFjernProdukt.Location = new Point(882, 251);
            buttonFjernProdukt.Margin = new Padding(4, 5, 4, 5);
            buttonFjernProdukt.Name = "buttonFjernProdukt";
            buttonFjernProdukt.Size = new Size(108, 39);
            buttonFjernProdukt.TabIndex = 38;
            buttonFjernProdukt.Text = "Fjern";
            buttonFjernProdukt.UseVisualStyleBackColor = false;
            buttonFjernProdukt.Click += buttonFjernProdukt_Click;
            // 
            // textBoxFjernProdukt
            // 
            textBoxFjernProdukt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxFjernProdukt.Location = new Point(581, 210);
            textBoxFjernProdukt.Margin = new Padding(4, 5, 4, 5);
            textBoxFjernProdukt.Name = "textBoxFjernProdukt";
            textBoxFjernProdukt.Size = new Size(142, 31);
            textBoxFjernProdukt.TabIndex = 39;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(847, 166);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(124, 25);
            label16.TabIndex = 40;
            label16.Text = "Fjern fra Lager";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(916, 13);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // LagerMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 644);
            Controls.Add(pictureBox1);
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
            Margin = new Padding(4);
            Name = "LagerMenu";
            Text = "Antal";
            Load += LagerMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }

}