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
            buttonOrdreSearch = new Button();
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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(587, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // buttonOrdreSearch
            // 
            buttonOrdreSearch.Location = new Point(587, 157);
            buttonOrdreSearch.Name = "buttonOrdreSearch";
            buttonOrdreSearch.Size = new Size(94, 29);
            buttonOrdreSearch.TabIndex = 1;
            buttonOrdreSearch.Text = "Søg";
            buttonOrdreSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(587, 77);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Søg i Lager";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(98, 203);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxNavn
            // 
            textBoxNavn.Location = new Point(44, 34);
            textBoxNavn.Name = "textBoxNavn";
            textBoxNavn.Size = new Size(51, 27);
            textBoxNavn.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 5;
            label2.Text = "Navn";
            // 
            // textBoxBeskriv
            // 
            textBoxBeskriv.Location = new Point(133, 34);
            textBoxBeskriv.Name = "textBoxBeskriv";
            textBoxBeskriv.Size = new Size(125, 27);
            textBoxBeskriv.TabIndex = 6;
            // 
            // textBoxMinLager
            // 
            textBoxMinLager.Location = new Point(133, 92);
            textBoxMinLager.Name = "textBoxMinLager";
            textBoxMinLager.Size = new Size(125, 27);
            textBoxMinLager.TabIndex = 7;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(44, 92);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.Size = new Size(51, 27);
            textBoxDato.TabIndex = 8;
            // 
            // textBoxMaksLager
            // 
            textBoxMaksLager.Location = new Point(133, 142);
            textBoxMaksLager.Name = "textBoxMaksLager";
            textBoxMaksLager.Size = new Size(125, 27);
            textBoxMaksLager.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 8);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 10;
            label3.Text = "Beskrivelse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 72);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 11;
            label4.Text = "Dato";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 69);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 12;
            label5.Text = "MinLager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 122);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 13;
            label6.Text = "MaksLager";
            // 
            // LagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(buttonOrdreSearch);
            Controls.Add(textBox1);
            Name = "LagerMenu";
            Text = "LagerMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOrdreSearch;
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
    }
}