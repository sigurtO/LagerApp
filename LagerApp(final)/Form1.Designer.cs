namespace LagerApp_final_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonLogin = new Button();
            buttonSkipLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(400, 215);
            textBoxUsername.Margin = new Padding(4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(178, 31);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(400, 288);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(178, 31);
            textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 175);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 2;
            label1.Text = "Medarbejder ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 259);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(255, 161, 0);
            buttonLogin.Location = new Point(413, 350);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(157, 40);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonSkipLogin
            // 
            buttonSkipLogin.Location = new Point(58, 164);
            buttonSkipLogin.Margin = new Padding(4);
            buttonSkipLogin.Name = "buttonSkipLogin";
            buttonSkipLogin.Size = new Size(118, 36);
            buttonSkipLogin.TabIndex = 5;
            buttonSkipLogin.Text = "Skip Login";
            buttonSkipLogin.UseVisualStyleBackColor = true;
            buttonSkipLogin.Click += buttonSkipLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(888, 13);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 663);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSkipLogin);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Button buttonLogin;
        private Button buttonSkipLogin;
        private PictureBox pictureBox1;
    }
}
