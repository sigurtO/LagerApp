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
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukter).BeginInit();
            SuspendLayout();
            // 
            // buttonProductSearch
            // 
            buttonProductSearch.Location = new Point(582, 205);
            buttonProductSearch.Margin = new Padding(4, 4, 4, 4);
            buttonProductSearch.Name = "buttonProductSearch";
            buttonProductSearch.Size = new Size(118, 36);
            buttonProductSearch.TabIndex = 1;
            buttonProductSearch.Text = "Søg";
            buttonProductSearch.UseVisualStyleBackColor = true;
            buttonProductSearch.Click += buttonProductSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(734, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Søg i Lager";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(156, 506);
            buttonAdd.Margin = new Padding(4, 4, 4, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 36);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Tilføj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxProID
            // 
            textBoxProID.Location = new Point(46, 44);
            textBoxProID.Margin = new Padding(4, 4, 4, 4);
            textBoxProID.Name = "textBoxProID";
            textBoxProID.Size = new Size(73, 31);
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
            textBoxNavn.Location = new Point(166, 44);
            textBoxNavn.Margin = new Padding(4, 4, 4, 4);
            textBoxNavn.Name = "textBoxNavn";
            textBoxNavn.Size = new Size(155, 31);
            textBoxNavn.TabIndex = 6;
            // 
            // textBoxAntal
            // 
            textBoxAntal.Location = new Point(46, 250);
            textBoxAntal.Margin = new Padding(4, 4, 4, 4);
            textBoxAntal.Name = "textBoxAntal";
            textBoxAntal.Size = new Size(70, 31);
            textBoxAntal.TabIndex = 7;
            // 
            // textBoxSalgsID
            // 
            textBoxSalgsID.Location = new Point(46, 115);
            textBoxSalgsID.Margin = new Padding(4, 4, 4, 4);
            textBoxSalgsID.Name = "textBoxSalgsID";
            textBoxSalgsID.Size = new Size(73, 31);
            textBoxSalgsID.TabIndex = 8;
            // 
            // textBoxMaal
            // 
            textBoxMaal.Location = new Point(201, 250);
            textBoxMaal.Margin = new Padding(4, 4, 4, 4);
            textBoxMaal.Name = "textBoxMaal";
            textBoxMaal.Size = new Size(73, 31);
            textBoxMaal.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 10);
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
            label4.Location = new Point(59, 90);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 11;
            label4.Text = "SalgsID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 221);
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
            label6.Location = new Point(211, 219);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 25);
            label6.TabIndex = 13;
            label6.Text = "Mål";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 154);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 14;
            label7.Text = "Vægt";
            // 
            // textBoxVaegt
            // 
            textBoxVaegt.Location = new Point(46, 181);
            textBoxVaegt.Margin = new Padding(4, 4, 4, 4);
            textBoxVaegt.Name = "textBoxVaegt";
            textBoxVaegt.Size = new Size(73, 31);
            textBoxVaegt.TabIndex = 15;
            textBoxVaegt.TextChanged += textBox2_TextChanged;
            // 
            // textBoxBeskriv
            // 
            textBoxBeskriv.Location = new Point(166, 115);
            textBoxBeskriv.Margin = new Padding(4, 4, 4, 4);
            textBoxBeskriv.Name = "textBoxBeskriv";
            textBoxBeskriv.Size = new Size(155, 31);
            textBoxBeskriv.TabIndex = 16;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(201, 316);
            textBoxDato.Margin = new Padding(4, 4, 4, 4);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.Size = new Size(73, 31);
            textBoxDato.TabIndex = 17;
            // 
            // textBoxMinbehold
            // 
            textBoxMinbehold.Location = new Point(46, 316);
            textBoxMinbehold.Margin = new Padding(4, 4, 4, 4);
            textBoxMinbehold.Name = "textBoxMinbehold";
            textBoxMinbehold.Size = new Size(70, 31);
            textBoxMinbehold.TabIndex = 18;
            // 
            // textBoxMaxbehold
            // 
            textBoxMaxbehold.Location = new Point(209, 380);
            textBoxMaxbehold.Margin = new Padding(4, 4, 4, 4);
            textBoxMaxbehold.Name = "textBoxMaxbehold";
            textBoxMaxbehold.Size = new Size(63, 31);
            textBoxMaxbehold.TabIndex = 19;
            // 
            // textBoxMoebeltype
            // 
            textBoxMoebeltype.Location = new Point(46, 380);
            textBoxMoebeltype.Margin = new Padding(4, 4, 4, 4);
            textBoxMoebeltype.Name = "textBoxMoebeltype";
            textBoxMoebeltype.Size = new Size(70, 31);
            textBoxMoebeltype.TabIndex = 20;
            // 
            // textBoxMaterialer
            // 
            textBoxMaterialer.Location = new Point(166, 181);
            textBoxMaterialer.Margin = new Padding(4, 4, 4, 4);
            textBoxMaterialer.Name = "textBoxMaterialer";
            textBoxMaterialer.Size = new Size(155, 31);
            textBoxMaterialer.TabIndex = 21;
            // 
            // textBoxKostpris
            // 
            textBoxKostpris.Location = new Point(46, 444);
            textBoxKostpris.Margin = new Padding(4, 4, 4, 4);
            textBoxKostpris.Name = "textBoxKostpris";
            textBoxKostpris.Size = new Size(63, 31);
            textBoxKostpris.TabIndex = 22;
            // 
            // textBoxSalgspris
            // 
            textBoxSalgspris.Location = new Point(211, 444);
            textBoxSalgspris.Margin = new Padding(4, 4, 4, 4);
            textBoxSalgspris.Name = "textBoxSalgspris";
            textBoxSalgspris.Size = new Size(63, 31);
            textBoxSalgspris.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(189, 90);
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
            label9.Location = new Point(211, 286);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 25;
            label9.Text = "Dato";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 286);
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
            label11.Location = new Point(166, 351);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(145, 25);
            label11.TabIndex = 27;
            label11.Text = "Maksbeholdning";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 351);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(107, 25);
            label12.TabIndex = 28;
            label12.Text = "Moebeltype";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(186, 154);
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
            label14.Location = new Point(41, 416);
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
            label15.Location = new Point(198, 415);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(83, 25);
            label15.TabIndex = 31;
            label15.Text = "Salgspris";
            // 
            // textBoxProduktsøgning
            // 
            textBoxProduktsøgning.Location = new Point(709, 140);
            textBoxProduktsøgning.Margin = new Padding(4, 5, 4, 5);
            textBoxProduktsøgning.Name = "textBoxProduktsøgning";
            textBoxProduktsøgning.Size = new Size(142, 31);
            textBoxProduktsøgning.TabIndex = 33;
            // 
            // dataGridViewProdukter
            // 
            dataGridViewProdukter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdukter.Location = new Point(546, 250);
            dataGridViewProdukter.Margin = new Padding(4, 5, 4, 5);
            dataGridViewProdukter.Name = "dataGridViewProdukter";
            dataGridViewProdukter.RowHeadersWidth = 51;
            dataGridViewProdukter.Size = new Size(342, 250);
            dataGridViewProdukter.TabIndex = 34;
            // 
            // button1Update
            // 
            button1Update.Location = new Point(295, 507);
            button1Update.Margin = new Padding(4, 4, 4, 4);
            button1Update.Name = "button1Update";
            button1Update.Size = new Size(118, 36);
            button1Update.TabIndex = 35;
            button1Update.Text = "Opdater";
            button1Update.UseVisualStyleBackColor = true;
            button1Update.Click += button1Update_Click;
            // 
            // buttonExportToCVS
            // 
            buttonExportToCVS.Location = new Point(734, 205);
            buttonExportToCVS.Margin = new Padding(4, 4, 4, 4);
            buttonExportToCVS.Name = "buttonExportToCVS";
            buttonExportToCVS.Size = new Size(118, 36);
            buttonExportToCVS.TabIndex = 36;
            buttonExportToCVS.Text = "Export CVS";
            buttonExportToCVS.UseVisualStyleBackColor = true;
            buttonExportToCVS.Click += buttonExportToCVS_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(26, 508);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 34);
            buttonBack.TabIndex = 37;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // LagerMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 564);
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
            Margin = new Padding(4, 4, 4, 4);
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
    }

}