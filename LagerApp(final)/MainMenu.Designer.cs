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
            SuspendLayout();
            // 
            // buttonLagerStyring
            // 
            buttonLagerStyring.Location = new Point(346, 178);
            buttonLagerStyring.Name = "buttonLagerStyring";
            buttonLagerStyring.Size = new Size(132, 29);
            buttonLagerStyring.TabIndex = 0;
            buttonLagerStyring.Text = "Lagerstyring";
            buttonLagerStyring.UseVisualStyleBackColor = true;
            buttonLagerStyring.Click += buttonLagerStyring_Click;
            // 
            // Ordrehandle
            // 
            Ordrehandle.Location = new Point(346, 243);
            Ordrehandle.Name = "Ordrehandle";
            Ordrehandle.Size = new Size(132, 29);
            Ordrehandle.TabIndex = 1;
            Ordrehandle.Text = "Ordrehåndtering";
            Ordrehandle.UseVisualStyleBackColor = true;
            Ordrehandle.Click += Ordrehandle_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ordrehandle);
            Controls.Add(buttonLagerStyring);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLagerStyring;
        private Button Ordrehandle;
    }
}