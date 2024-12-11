namespace LagerApp_final_
{
    partial class MainMenu
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
            buttonLagerStyring = new Button();
            Ordrehandle = new Button();
            buttonRaavarer = new Button();
            SuspendLayout();
            // 
            // buttonLagerStyring
            // 
            buttonLagerStyring.Location = new Point(432, 204);
            buttonLagerStyring.Margin = new Padding(4, 4, 4, 4);
            buttonLagerStyring.Name = "buttonLagerStyring";
            buttonLagerStyring.Size = new Size(165, 36);
            buttonLagerStyring.TabIndex = 0;
            buttonLagerStyring.Text = "Lagerstyring";
            buttonLagerStyring.UseVisualStyleBackColor = true;
            buttonLagerStyring.Click += buttonLagerStyring_Click;
            // 
            // Ordrehandle
            // 
            Ordrehandle.Location = new Point(432, 322);
            Ordrehandle.Margin = new Padding(4, 4, 4, 4);
            Ordrehandle.Name = "Ordrehandle";
            Ordrehandle.Size = new Size(165, 36);
            Ordrehandle.TabIndex = 1;
            Ordrehandle.Text = "Ordrehåndtering";
            Ordrehandle.UseVisualStyleBackColor = true;
            Ordrehandle.Click += Ordrehandle_Click;
            // 
            // buttonRaavarer
            // 
            buttonRaavarer.Location = new Point(432, 260);
            buttonRaavarer.Margin = new Padding(4);
            buttonRaavarer.Name = "buttonRaavarer";
            buttonRaavarer.Size = new Size(165, 36);
            buttonRaavarer.TabIndex = 2;
            buttonRaavarer.Text = "Råvarer";
            buttonRaavarer.UseVisualStyleBackColor = true;
            buttonRaavarer.Click += button1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(buttonRaavarer);
            Controls.Add(Ordrehandle);
            Controls.Add(buttonLagerStyring);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLagerStyring;
        private Button Ordrehandle;
        private Button buttonRaavarer;
    }
}