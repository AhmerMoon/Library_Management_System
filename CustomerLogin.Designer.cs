namespace Library
{
    partial class CustomerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLogin));
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            Password = new TextBox();
            Username = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SpringGreen;
            btnLogin.Font = new Font("Segoe UI", 16F);
            btnLogin.Location = new Point(125, 471);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 44);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(125, 371);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(125, 300);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 7;
            label1.Text = "Email or Username";
            // 
            // Password
            // 
            Password.Location = new Point(125, 402);
            Password.Name = "Password";
            Password.Size = new Size(330, 27);
            Password.TabIndex = 6;
            // 
            // Username
            // 
            Username.Location = new Point(125, 331);
            Username.Name = "Username";
            Username.Size = new Size(330, 27);
            Username.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(145, 176);
            label3.Name = "label3";
            label3.Size = new Size(297, 46);
            label3.TabIndex = 11;
            label3.Text = "Login as Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(591, 562);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "CustomerLogin";
            Text = "Customer Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox Password;
        private TextBox Username;
        private Label label3;
        private PictureBox pictureBox1;
    }
}