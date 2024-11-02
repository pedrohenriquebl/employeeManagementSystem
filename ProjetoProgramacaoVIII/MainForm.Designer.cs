namespace ProjetoProgramacaoVIII
{
    partial class MainForm
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
            Button dashboard_btn;
            panel1 = new Panel();
            label2 = new Label();
            exit = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            salary_btn = new Button();
            employee_btn = new Button();
            pictureBox1 = new PictureBox();
            greet_user = new Label();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addEmployee1 = new AddEmployee();
            salary1 = new Salary();
            dashboard_btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(79, 0, 11);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(12, 203);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(200, 40);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(79, 0, 11);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 35);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(216, 18);
            label2.TabIndex = 1;
            label2.Text = "Employee Management System";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1081, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(salary_btn);
            panel2.Controls.Add(employee_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(greet_user);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 565);
            panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(79, 0, 11);
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(12, 511);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(82, 30);
            logout_btn.TabIndex = 5;
            logout_btn.Text = "Sign Out";
            logout_btn.TextAlign = ContentAlignment.MiddleLeft;
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // salary_btn
            // 
            salary_btn.BackColor = Color.FromArgb(79, 0, 11);
            salary_btn.Cursor = Cursors.Hand;
            salary_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            salary_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            salary_btn.FlatStyle = FlatStyle.Flat;
            salary_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary_btn.ForeColor = Color.White;
            salary_btn.Location = new Point(12, 317);
            salary_btn.Name = "salary_btn";
            salary_btn.Size = new Size(200, 40);
            salary_btn.TabIndex = 4;
            salary_btn.Text = "SALARY";
            salary_btn.UseVisualStyleBackColor = false;
            salary_btn.Click += salary_btn_Click;
            // 
            // employee_btn
            // 
            employee_btn.BackColor = Color.FromArgb(79, 0, 11);
            employee_btn.Cursor = Cursors.Hand;
            employee_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            employee_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            employee_btn.FlatStyle = FlatStyle.Flat;
            employee_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_btn.ForeColor = Color.White;
            employee_btn.Location = new Point(12, 262);
            employee_btn.Name = "employee_btn";
            employee_btn.Size = new Size(200, 40);
            employee_btn.TabIndex = 3;
            employee_btn.Text = "ADD EMPLOYEE";
            employee_btn.UseVisualStyleBackColor = false;
            employee_btn.Click += employee_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee_card;
            pictureBox1.Location = new Point(57, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // greet_user
            // 
            greet_user.AutoSize = true;
            greet_user.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greet_user.ForeColor = Color.White;
            greet_user.Location = new Point(48, 160);
            greet_user.Name = "greet_user";
            greet_user.Size = new Size(121, 19);
            greet_user.TabIndex = 0;
            greet_user.Text = "Welcomer, User";
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(salary1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 565);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(-2, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(887, 565);
            dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(0, 0);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(885, 565);
            addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.Location = new Point(0, 0);
            salary1.Name = "salary1";
            salary1.Size = new Size(885, 565);
            salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label greet_user;
        private Button salary_btn;
        private Button employee_btn;
        private Button dashboard_btn;
        private Button logout_btn;
        private Panel panel3;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private Dashboard dashboard1;
    }
}