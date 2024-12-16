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
<<<<<<< Updated upstream
=======
            buttonRaavarer = new Button();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // buttonLagerStyring
            // 
<<<<<<< Updated upstream
            buttonLagerStyring.Location = new Point(346, 178);
            buttonLagerStyring.Name = "buttonLagerStyring";
            buttonLagerStyring.Size = new Size(132, 29);
=======
            buttonLagerStyring.Anchor = AnchorStyles.None;
            buttonLagerStyring.BackColor = Color.White;
            buttonLagerStyring.Location = new Point(389, 177);
            buttonLagerStyring.Margin = new Padding(4);
            buttonLagerStyring.Name = "buttonLagerStyring";
            buttonLagerStyring.Size = new Size(239, 45);
>>>>>>> Stashed changes
            buttonLagerStyring.TabIndex = 0;
            buttonLagerStyring.Text = "Lagerstyring";
            buttonLagerStyring.UseVisualStyleBackColor = false;
            buttonLagerStyring.Click += buttonLagerStyring_Click;
            // 
            // Ordrehandle
            // 
<<<<<<< Updated upstream
            Ordrehandle.Location = new Point(346, 243);
            Ordrehandle.Name = "Ordrehandle";
            Ordrehandle.Size = new Size(132, 29);
=======
            Ordrehandle.Anchor = AnchorStyles.None;
            Ordrehandle.BackColor = Color.FromArgb(255, 161, 0);
            Ordrehandle.Location = new Point(389, 330);
            Ordrehandle.Margin = new Padding(4);
            Ordrehandle.Name = "Ordrehandle";
            Ordrehandle.Size = new Size(239, 45);
>>>>>>> Stashed changes
            Ordrehandle.TabIndex = 1;
            Ordrehandle.Text = "Ordrehåndtering";
            Ordrehandle.UseVisualStyleBackColor = false;
            Ordrehandle.Click += Ordrehandle_Click;
            // 
<<<<<<< Updated upstream
=======
            // buttonRaavarer
            // 
            buttonRaavarer.Anchor = AnchorStyles.None;
            buttonRaavarer.BackColor = Color.DarkGray;
            buttonRaavarer.Location = new Point(389, 252);
            buttonRaavarer.Margin = new Padding(4);
            buttonRaavarer.Name = "buttonRaavarer";
            buttonRaavarer.Size = new Size(239, 45);
            buttonRaavarer.TabIndex = 2;
            buttonRaavarer.Text = "Råvarer";
            buttonRaavarer.UseVisualStyleBackColor = false;
            buttonRaavarer.Click += button1_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.White;
            buttonBack.Location = new Point(38, 503);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(128, 45);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(896, 13);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
>>>>>>> Stashed changes
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(800, 450);
=======
            ClientSize = new Size(1008, 663);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack);
            Controls.Add(buttonRaavarer);
>>>>>>> Stashed changes
            Controls.Add(Ordrehandle);
            Controls.Add(buttonLagerStyring);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLagerStyring;
        private Button Ordrehandle;
<<<<<<< Updated upstream
=======
        private Button buttonRaavarer;
        private Button buttonBack;
        private PictureBox pictureBox1;
>>>>>>> Stashed changes
    }
}