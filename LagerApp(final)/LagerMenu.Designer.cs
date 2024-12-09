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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
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
            // textBox2
            // 
            textBox2.Location = new Point(133, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(44, 92);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(51, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 142);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
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
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
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
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}