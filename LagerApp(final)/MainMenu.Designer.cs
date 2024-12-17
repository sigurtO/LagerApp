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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            buttonLagerStyring = new Button();
            Ordrehandle = new Button();
            buttonRaavarer = new Button();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLagerStyring
            // 
            buttonLagerStyring.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLagerStyring.Location = new Point(432, 204);
            buttonLagerStyring.Margin = new Padding(4);
            buttonLagerStyring.Name = "buttonLagerStyring";
            buttonLagerStyring.Size = new Size(165, 36);
            buttonLagerStyring.TabIndex = 0;
            buttonLagerStyring.Text = "Lagerstyring";
            buttonLagerStyring.UseVisualStyleBackColor = true;
            buttonLagerStyring.Click += buttonLagerStyring_Click;
            // 
            // Ordrehandle
            // 
            Ordrehandle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ordrehandle.BackColor = Color.FromArgb(255, 161, 0);
            Ordrehandle.Location = new Point(432, 322);
            Ordrehandle.Margin = new Padding(4);
            Ordrehandle.Name = "Ordrehandle";
            Ordrehandle.Size = new Size(165, 36);
            Ordrehandle.TabIndex = 1;
            Ordrehandle.Text = "Ordrehåndtering";
            Ordrehandle.UseVisualStyleBackColor = false;
            Ordrehandle.Click += Ordrehandle_Click;
            // 
            // buttonRaavarer
            // 
            buttonRaavarer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRaavarer.BackColor = Color.LightGray;
            buttonRaavarer.Location = new Point(432, 265);
            buttonRaavarer.Margin = new Padding(4);
            buttonRaavarer.Name = "buttonRaavarer";
            buttonRaavarer.Size = new Size(165, 36);
            buttonRaavarer.TabIndex = 2;
            buttonRaavarer.Text = "Råvarer";
            buttonRaavarer.UseVisualStyleBackColor = false;
            buttonRaavarer.Click += button1_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Location = new Point(39, 552);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(160, 56);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(916, 13);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 644);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack);
            Controls.Add(buttonRaavarer);
            Controls.Add(Ordrehandle);
            Controls.Add(buttonLagerStyring);
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLagerStyring;
        private Button Ordrehandle;
        private Button buttonRaavarer;
        private Button buttonBack;
        private PictureBox pictureBox1;
    }
}