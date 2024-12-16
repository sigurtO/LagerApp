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
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdre).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 106);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 84);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Søg Kunde";
            // 
            // buttonOrdreSearch
            // 
            buttonOrdreSearch.Location = new Point(49, 142);
            buttonOrdreSearch.Margin = new Padding(3, 2, 3, 2);
            buttonOrdreSearch.Name = "buttonOrdreSearch";
            buttonOrdreSearch.Size = new Size(94, 30);
            buttonOrdreSearch.TabIndex = 2;
            buttonOrdreSearch.Text = "Søg";
            buttonOrdreSearch.UseVisualStyleBackColor = true;
            buttonOrdreSearch.Click += buttonOrdreSearch_Click;
            // 
            // dataGridViewOrdre
            // 
            dataGridViewOrdre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrdre.Location = new Point(388, 21);
            dataGridViewOrdre.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOrdre.Name = "dataGridViewOrdre";
            dataGridViewOrdre.RowHeadersWidth = 62;
            dataGridViewOrdre.Size = new Size(569, 378);
            dataGridViewOrdre.TabIndex = 4;
            dataGridViewOrdre.CellContentClick += dataGridViewOrdre_CellContentClick;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(49, 400);
            buttonBack.Margin = new Padding(2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 27);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // OrdreMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewOrdre);
            Controls.Add(buttonOrdreSearch);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1000, 500);
            Name = "OrdreMenu";
            StartPosition = FormStartPosition.CenterParent;
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
        private Button buttonBack;
    }
}