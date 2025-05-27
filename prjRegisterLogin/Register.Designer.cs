namespace prjRegisterLogin
{
    partial class Register
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLoginScreen = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 44);
            label1.Name = "label1";
            label1.Size = new Size(265, 46);
            label1.TabIndex = 1;
            label1.Text = "Register Screen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 128);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 188);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(374, 125);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(172, 27);
            txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(374, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnLoginScreen
            // 
            btnLoginScreen.Location = new Point(426, 277);
            btnLoginScreen.Name = "btnLoginScreen";
            btnLoginScreen.Size = new Size(136, 29);
            btnLoginScreen.TabIndex = 8;
            btnLoginScreen.Text = "Login Screen";
            btnLoginScreen.UseVisualStyleBackColor = true;
            btnLoginScreen.Click += btnLoginScreen_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(248, 277);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLoginScreen);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLoginScreen;
        private Button btnRegister;
    }
}