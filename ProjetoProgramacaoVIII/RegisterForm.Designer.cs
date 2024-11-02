namespace ProjetoProgramacaoVIII
{
    partial class RegisterForm
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
            signup_btn = new Button();
            signup_loginBtn = new Button();
            label5 = new Label();
            signup_showPass = new CheckBox();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            signup_email = new TextBox();
            label7 = new Label();
            label8 = new Label();
            signup_telefone = new MaskedTextBox();
            signup_cpf = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.White;
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 246, 189);
            signup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 246, 189);
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.Black;
            signup_btn.Location = new Point(296, 347);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(101, 41);
            signup_btn.TabIndex = 17;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_loginBtn
            // 
            signup_loginBtn.BackColor = Color.FromArgb(79, 0, 11);
            signup_loginBtn.Cursor = Cursors.Hand;
            signup_loginBtn.FlatAppearance.BorderSize = 0;
            signup_loginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            signup_loginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            signup_loginBtn.FlatStyle = FlatStyle.Flat;
            signup_loginBtn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_loginBtn.ForeColor = Color.White;
            signup_loginBtn.Location = new Point(11, 350);
            signup_loginBtn.Name = "signup_loginBtn";
            signup_loginBtn.Size = new Size(263, 37);
            signup_loginBtn.TabIndex = 1;
            signup_loginBtn.Text = "SIGN IN";
            signup_loginBtn.UseVisualStyleBackColor = false;
            signup_loginBtn.Click += signup_loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(79, 323);
            label5.Name = "label5";
            label5.Size = new Size(114, 14);
            label5.TabIndex = 0;
            label5.Text = "Login your Account";
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showPass.ForeColor = Color.White;
            signup_showPass.Location = new Point(444, 320);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(112, 18);
            signup_showPass.TabIndex = 16;
            signup_showPass.Text = "Show password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Tahoma", 11.25F);
            signup_password.Location = new Point(296, 288);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(260, 26);
            signup_password.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(296, 269);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Tahoma", 11.25F);
            signup_username.Location = new Point(296, 82);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(260, 26);
            signup_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Tahoma", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(296, 61);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(292, 39);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.FromArgb(79, 0, 11);
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(545, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signup_loginBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 400);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(36, 179);
            label6.Name = "label6";
            label6.Size = new Size(238, 21);
            label6.TabIndex = 2;
            label6.Text = "Employee Manangement System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 114);
            label1.Name = "label1";
            label1.Size = new Size(38, 18);
            label1.TabIndex = 18;
            label1.Text = "CPF:";
            // 
            // signup_email
            // 
            signup_email.Font = new Font("Tahoma", 11.25F);
            signup_email.Location = new Point(296, 236);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(260, 26);
            signup_email.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(296, 215);
            label7.Name = "label7";
            label7.Size = new Size(46, 18);
            label7.TabIndex = 20;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(296, 165);
            label8.Name = "label8";
            label8.Size = new Size(70, 18);
            label8.TabIndex = 22;
            label8.Text = "Telefone:";
            // 
            // signup_telefone
            // 
            signup_telefone.Location = new Point(297, 187);
            signup_telefone.Mask = "(00) 00000-0000";
            signup_telefone.Name = "signup_telefone";
            signup_telefone.Size = new Size(259, 23);
            signup_telefone.TabIndex = 25;
            signup_telefone.MaskInputRejected += signup_telefone_MaskInputRejected;
            // 
            // signup_cpf
            // 
            signup_cpf.Location = new Point(297, 135);
            signup_cpf.Name = "signup_cpf";
            signup_cpf.Size = new Size(259, 23);
            signup_cpf.TabIndex = 26;
            signup_cpf.TextChanged += signup_cpf_TextChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 0, 11);
            ClientSize = new Size(575, 400);
            Controls.Add(signup_cpf);
            Controls.Add(signup_telefone);
            Controls.Add(label8);
            Controls.Add(signup_email);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(signup_btn);
            Controls.Add(signup_showPass);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_btn;
        private Button signup_loginBtn;
        private Label label5;
        private CheckBox signup_showPass;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_username;
        private Label label3;
        private Label label2;
        private Label exit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private TextBox signup_email;
        private Label label7;
        private Label label8;
        private MaskedTextBox signup_telefone;
        private TextBox signup_cpf;
    }
}