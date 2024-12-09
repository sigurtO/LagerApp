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
            buttonLagerSearch = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 167);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Søg i Ordre";
            // 
            // buttonLagerSearch
            // 
            buttonLagerSearch.Location = new Point(314, 236);
            buttonLagerSearch.Name = "buttonLagerSearch";
            buttonLagerSearch.Size = new Size(94, 29);
            buttonLagerSearch.TabIndex = 2;
            buttonLagerSearch.Text = "Søg";
            buttonLagerSearch.UseVisualStyleBackColor = true;
            // 
            // OrdreMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLagerSearch);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "OrdreMenu";
            Text = "OrdreMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonLagerSearch;
    }
}