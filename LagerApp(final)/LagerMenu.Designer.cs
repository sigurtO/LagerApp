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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // buttonOrdreSearch
            // 
            buttonOrdreSearch.Location = new Point(331, 244);
            buttonOrdreSearch.Name = "buttonOrdreSearch";
            buttonOrdreSearch.Size = new Size(94, 29);
            buttonOrdreSearch.TabIndex = 1;
            buttonOrdreSearch.Text = "Søg";
            buttonOrdreSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 164);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Søg i ordre";
            // 
            // LagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}