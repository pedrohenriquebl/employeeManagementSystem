namespace ProjetoProgramacaoVIII
{
    partial class formLogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            login_signUpBtn = new Button();
            label5 = new Label();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_showPass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(79, 0, 11);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(login_signUpBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 400);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee_card;
            pictureBox1.Location = new Point(95, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 179);
            label6.Name = "label6";
            label6.Size = new Size(238, 21);
            label6.TabIndex = 2;
            label6.Text = "Employee Manangement System";
            // 
            // login_signUpBtn
            // 
            login_signUpBtn.BackColor = Color.White;
            login_signUpBtn.Cursor = Cursors.Hand;
            login_signUpBtn.FlatAppearance.BorderSize = 0;
            login_signUpBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 246, 189);
            login_signUpBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 246, 189);
            login_signUpBtn.FlatStyle = FlatStyle.Flat;
            login_signUpBtn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_signUpBtn.ForeColor = Color.Black;
            login_signUpBtn.Location = new Point(11, 350);
            login_signUpBtn.Name = "login_signUpBtn";
            login_signUpBtn.Size = new Size(263, 37);
            login_signUpBtn.TabIndex = 1;
            login_signUpBtn.Text = "SIGN UP";
            login_signUpBtn.UseVisualStyleBackColor = false;
            login_signUpBtn.Click += login_signUpBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(79, 323);
            label5.Name = "label5";
            label5.Size = new Size(129, 14);
            label5.TabIndex = 0;
            label5.Text = "Register your Account";
            label5.Click += label5_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.FromArgb(79, 0, 11);
            exit.Location = new Point(549, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 39);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(296, 106);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.Font = new Font("Tahoma", 11.25F);
            login_username.Location = new Point(296, 127);
            login_username.Name = "login_username";
            login_username.Size = new Size(260, 26);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Font = new Font("Tahoma", 11.25F);
            login_password.Location = new Point(296, 199);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(260, 26);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(296, 180);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(444, 231);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(112, 18);
            login_showPass.TabIndex = 7;
            login_showPass.Text = "Show password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(79, 0, 11);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(296, 283);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(101, 41);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private CheckBox login_showPass;
        private Button login_btn;
        private Button login_signUpBtn;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
