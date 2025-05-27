namespace prjRegisterLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnClear = new Button();
            btnLogin = new Button();
            btnRegisterScreen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 53);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 0;
            label1.Text = "Login Screen";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 184);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 132);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(389, 129);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(172, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(385, 184);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(209, 257);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(360, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegisterScreen
            // 
            btnRegisterScreen.Location = new Point(503, 257);
            btnRegisterScreen.Name = "btnRegisterScreen";
            btnRegisterScreen.Size = new Size(136, 29);
            btnRegisterScreen.TabIndex = 7;
            btnRegisterScreen.Text = "Register Screen";
            btnRegisterScreen.UseVisualStyleBackColor = true;
            btnRegisterScreen.Click += btnRegisterScreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegisterScreen);
            Controls.Add(btnLogin);
            Controls.Add(btnClear);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnClear;
        private Button btnLogin;
        private Button btnRegisterScreen;
    }
}
