namespace Library
{
    partial class MainLoginForm
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
            btnLoginAsCustomer = new Button();
            btnLoginAsAdmin = new Button();
            SuspendLayout();
            // 
            // btnLoginAsCustomer
            // 
            btnLoginAsCustomer.BackColor = Color.FromArgb(255, 128, 128);
            btnLoginAsCustomer.Font = new Font("Segoe UI", 25F);
            btnLoginAsCustomer.Location = new Point(100, 238);
            btnLoginAsCustomer.Name = "btnLoginAsCustomer";
            btnLoginAsCustomer.Size = new Size(582, 149);
            btnLoginAsCustomer.TabIndex = 0;
            btnLoginAsCustomer.Text = "Login As Customer";
            btnLoginAsCustomer.UseVisualStyleBackColor = false;
            btnLoginAsCustomer.Click += btnLoginAsCustomer_Click;
            // 
            // btnLoginAsAdmin
            // 
            btnLoginAsAdmin.BackColor = Color.Cyan;
            btnLoginAsAdmin.Font = new Font("Segoe UI", 25F);
            btnLoginAsAdmin.Location = new Point(100, 40);
            btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            btnLoginAsAdmin.Size = new Size(582, 153);
            btnLoginAsAdmin.TabIndex = 1;
            btnLoginAsAdmin.Text = "Login As Admin";
            btnLoginAsAdmin.UseVisualStyleBackColor = false;
            btnLoginAsAdmin.Click += btnLoginAsAdmin_Click;
            // 
            // MainLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoginAsAdmin);
            Controls.Add(btnLoginAsCustomer);
            Name = "MainLoginForm";
            Text = "MainLoginForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoginAsCustomer;
        private Button btnLoginAsAdmin;
    }
}