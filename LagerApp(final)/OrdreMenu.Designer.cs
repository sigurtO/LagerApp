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
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 74);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 57);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Søg i Ordre";
            // 
            // buttonOrdreSearch
            // 
            buttonOrdreSearch.Location = new Point(426, 101);
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
            dataGridViewOrdre.Location = new Point(12, 24);
            dataGridViewOrdre.Name = "dataGridViewOrdre";
            dataGridViewOrdre.Size = new Size(343, 283);
            dataGridViewOrdre.TabIndex = 4;
            // 
            // OrdreMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewOrdre);
            Controls.Add(buttonOrdreSearch);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrdreMenu";
            Text = "OrdreMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonOrdreSearch;
        private DataGridView dataGridViewOrdre;
    }
}