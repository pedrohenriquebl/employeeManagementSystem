namespace ProjetoProgramacaoVIII
{
    partial class AddEmployee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addEmployee_position = new ComboBox();
            addEmployee_phoneNumber = new MaskedTextBox();
            addEmployee_birthday = new MaskedTextBox();
            addEmployee_status = new ComboBox();
            label9 = new Label();
            employee_position = new Label();
            addEmployee_clearBtn = new Button();
            addEmployee_deleteBtn = new Button();
            addEmployee_updateBtn = new Button();
            addEmployee_addBtn = new Button();
            addEmployee_importBtn = new Button();
            addEmployee_email = new TextBox();
            label6 = new Label();
            addEmployee_label = new Label();
            addEmployee_cpf = new TextBox();
            label8 = new Label();
            addEmployee_picture = new PictureBox();
            label5 = new Label();
            addEmployee_gender = new ComboBox();
            label4 = new Label();
            addEmployee_fullName = new TextBox();
            label3 = new Label();
            addEmployee_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 276);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(79, 0, 11);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(13, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(802, 205);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addEmployee_position);
            panel2.Controls.Add(addEmployee_phoneNumber);
            panel2.Controls.Add(addEmployee_birthday);
            panel2.Controls.Add(addEmployee_status);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(employee_position);
            panel2.Controls.Add(addEmployee_clearBtn);
            panel2.Controls.Add(addEmployee_deleteBtn);
            panel2.Controls.Add(addEmployee_updateBtn);
            panel2.Controls.Add(addEmployee_addBtn);
            panel2.Controls.Add(addEmployee_importBtn);
            panel2.Controls.Add(addEmployee_email);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addEmployee_label);
            panel2.Controls.Add(addEmployee_cpf);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(addEmployee_picture);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addEmployee_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addEmployee_fullName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addEmployee_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 226);
            panel2.TabIndex = 1;
            // 
            // addEmployee_position
            // 
            addEmployee_position.FormattingEnabled = true;
            addEmployee_position.Items.AddRange(new object[] { "Bussiness Management", "Front-end Developer", "Back-end Developer", "Administrator", "UX/UI Designer" });
            addEmployee_position.Location = new Point(340, 7);
            addEmployee_position.Name = "addEmployee_position";
            addEmployee_position.Size = new Size(139, 23);
            addEmployee_position.TabIndex = 26;
            // 
            // addEmployee_phoneNumber
            // 
            addEmployee_phoneNumber.Location = new Point(118, 128);
            addEmployee_phoneNumber.Mask = "(00)00000-0000";
            addEmployee_phoneNumber.Name = "addEmployee_phoneNumber";
            addEmployee_phoneNumber.Size = new Size(144, 23);
            addEmployee_phoneNumber.TabIndex = 25;
            // 
            // addEmployee_birthday
            // 
            addEmployee_birthday.Location = new Point(340, 88);
            addEmployee_birthday.Mask = "00/00/0000";
            addEmployee_birthday.Name = "addEmployee_birthday";
            addEmployee_birthday.Size = new Size(139, 23);
            addEmployee_birthday.TabIndex = 24;
            // 
            // addEmployee_status
            // 
            addEmployee_status.FormattingEnabled = true;
            addEmployee_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addEmployee_status.Location = new Point(554, 10);
            addEmployee_status.Name = "addEmployee_status";
            addEmployee_status.Size = new Size(144, 23);
            addEmployee_status.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F);
            label9.Location = new Point(496, 14);
            label9.Name = "label9";
            label9.Size = new Size(52, 16);
            label9.TabIndex = 22;
            label9.Text = "Status: ";
            // 
            // employee_position
            // 
            employee_position.AutoSize = true;
            employee_position.Font = new Font("Tahoma", 9.75F);
            employee_position.Location = new Point(277, 12);
            employee_position.Name = "employee_position";
            employee_position.Size = new Size(60, 16);
            employee_position.TabIndex = 20;
            employee_position.Text = "Position: ";
            // 
            // addEmployee_clearBtn
            // 
            addEmployee_clearBtn.BackColor = Color.FromArgb(79, 0, 11);
            addEmployee_clearBtn.Cursor = Cursors.Hand;
            addEmployee_clearBtn.FlatAppearance.BorderSize = 0;
            addEmployee_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_clearBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_clearBtn.Font = new Font("Tahoma", 9F);
            addEmployee_clearBtn.ForeColor = Color.White;
            addEmployee_clearBtn.Location = new Point(602, 175);
            addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            addEmployee_clearBtn.Size = new Size(144, 36);
            addEmployee_clearBtn.TabIndex = 19;
            addEmployee_clearBtn.Text = "Clear";
            addEmployee_clearBtn.UseVisualStyleBackColor = false;
            addEmployee_clearBtn.Click += addEmployee_clearBtn_Click;
            // 
            // addEmployee_deleteBtn
            // 
            addEmployee_deleteBtn.BackColor = Color.FromArgb(79, 0, 11);
            addEmployee_deleteBtn.Cursor = Cursors.Hand;
            addEmployee_deleteBtn.FlatAppearance.BorderSize = 0;
            addEmployee_deleteBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_deleteBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_deleteBtn.Font = new Font("Tahoma", 9F);
            addEmployee_deleteBtn.ForeColor = Color.White;
            addEmployee_deleteBtn.Location = new Point(442, 175);
            addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            addEmployee_deleteBtn.Size = new Size(144, 36);
            addEmployee_deleteBtn.TabIndex = 18;
            addEmployee_deleteBtn.Text = "Delete";
            addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            addEmployee_deleteBtn.Click += addEmployee_deleteBtn_Click;
            // 
            // addEmployee_updateBtn
            // 
            addEmployee_updateBtn.BackColor = Color.FromArgb(79, 0, 11);
            addEmployee_updateBtn.Cursor = Cursors.Hand;
            addEmployee_updateBtn.FlatAppearance.BorderSize = 0;
            addEmployee_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_updateBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_updateBtn.Font = new Font("Tahoma", 9F);
            addEmployee_updateBtn.ForeColor = Color.White;
            addEmployee_updateBtn.Location = new Point(278, 175);
            addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            addEmployee_updateBtn.Size = new Size(144, 36);
            addEmployee_updateBtn.TabIndex = 17;
            addEmployee_updateBtn.Text = "Update";
            addEmployee_updateBtn.UseVisualStyleBackColor = false;
            addEmployee_updateBtn.Click += addEmployee_updateBtn_Click;
            // 
            // addEmployee_addBtn
            // 
            addEmployee_addBtn.BackColor = Color.FromArgb(79, 0, 11);
            addEmployee_addBtn.Cursor = Cursors.Hand;
            addEmployee_addBtn.FlatAppearance.BorderSize = 0;
            addEmployee_addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addEmployee_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_addBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_addBtn.Font = new Font("Tahoma", 9F);
            addEmployee_addBtn.ForeColor = Color.White;
            addEmployee_addBtn.Location = new Point(118, 175);
            addEmployee_addBtn.Name = "addEmployee_addBtn";
            addEmployee_addBtn.Size = new Size(144, 36);
            addEmployee_addBtn.TabIndex = 16;
            addEmployee_addBtn.Text = "Add";
            addEmployee_addBtn.UseVisualStyleBackColor = false;
            addEmployee_addBtn.Click += addEmployee_addBtn_Click;
            // 
            // addEmployee_importBtn
            // 
            addEmployee_importBtn.BackColor = Color.FromArgb(79, 0, 11);
            addEmployee_importBtn.Cursor = Cursors.Hand;
            addEmployee_importBtn.FlatAppearance.BorderSize = 0;
            addEmployee_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            addEmployee_importBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_importBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployee_importBtn.ForeColor = Color.White;
            addEmployee_importBtn.Location = new Point(715, 136);
            addEmployee_importBtn.Name = "addEmployee_importBtn";
            addEmployee_importBtn.Size = new Size(100, 31);
            addEmployee_importBtn.TabIndex = 15;
            addEmployee_importBtn.Text = "Import";
            addEmployee_importBtn.UseVisualStyleBackColor = false;
            addEmployee_importBtn.Click += addEmployee_importBtn_Click;
            // 
            // addEmployee_email
            // 
            addEmployee_email.Location = new Point(340, 128);
            addEmployee_email.Name = "addEmployee_email";
            addEmployee_email.Size = new Size(139, 23);
            addEmployee_email.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F);
            label6.Location = new Point(277, 130);
            label6.Name = "label6";
            label6.Size = new Size(47, 16);
            label6.TabIndex = 13;
            label6.Text = "Email: ";
            // 
            // addEmployee_label
            // 
            addEmployee_label.AutoSize = true;
            addEmployee_label.Font = new Font("Tahoma", 9.75F);
            addEmployee_label.Location = new Point(277, 90);
            addEmployee_label.Name = "addEmployee_label";
            addEmployee_label.Size = new Size(62, 16);
            addEmployee_label.TabIndex = 11;
            addEmployee_label.Text = "Birthday: ";
            // 
            // addEmployee_cpf
            // 
            addEmployee_cpf.Location = new Point(340, 51);
            addEmployee_cpf.Name = "addEmployee_cpf";
            addEmployee_cpf.Size = new Size(139, 23);
            addEmployee_cpf.TabIndex = 10;
            addEmployee_cpf.TextChanged += addEmployee_cpf_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F);
            label8.Location = new Point(277, 52);
            label8.Name = "label8";
            label8.Size = new Size(38, 16);
            label8.TabIndex = 9;
            label8.Text = "CPF: ";
            // 
            // addEmployee_picture
            // 
            addEmployee_picture.BackColor = SystemColors.ButtonFace;
            addEmployee_picture.BorderStyle = BorderStyle.FixedSingle;
            addEmployee_picture.Location = new Point(715, 35);
            addEmployee_picture.Name = "addEmployee_picture";
            addEmployee_picture.Size = new Size(100, 102);
            addEmployee_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            addEmployee_picture.TabIndex = 8;
            addEmployee_picture.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F);
            label5.Location = new Point(12, 132);
            label5.Name = "label5";
            label5.Size = new Size(100, 16);
            label5.TabIndex = 6;
            label5.Text = "Phone Number: ";
            // 
            // addEmployee_gender
            // 
            addEmployee_gender.FormattingEnabled = true;
            addEmployee_gender.Items.AddRange(new object[] { "Male", "Female" });
            addEmployee_gender.Location = new Point(118, 86);
            addEmployee_gender.Name = "addEmployee_gender";
            addEmployee_gender.Size = new Size(144, 23);
            addEmployee_gender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.Location = new Point(13, 93);
            label4.Name = "label4";
            label4.Size = new Size(57, 16);
            label4.TabIndex = 4;
            label4.Text = "Gender: ";
            // 
            // addEmployee_fullName
            // 
            addEmployee_fullName.Location = new Point(118, 47);
            addEmployee_fullName.Name = "addEmployee_fullName";
            addEmployee_fullName.Size = new Size(144, 23);
            addEmployee_fullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.Location = new Point(13, 52);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 2;
            label3.Text = "Full Name: ";
            // 
            // addEmployee_id
            // 
            addEmployee_id.Location = new Point(118, 7);
            addEmployee_id.Name = "addEmployee_id";
            addEmployee_id.Size = new Size(144, 23);
            addEmployee_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.Location = new Point(13, 14);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 0;
            label2.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox addEmployee_gender;
        private Label label4;
        private TextBox addEmployee_fullName;
        private Label label3;
        private TextBox addEmployee_id;
        private Label label2;
        private TextBox addEmployee_email;
        private Label label6;
        private Label addEmployee_label;
        private TextBox addEmployee_cpf;
        private Label label8;
        private PictureBox addEmployee_picture;
        private Label label5;
        private Button addEmployee_clearBtn;
        private Button addEmployee_deleteBtn;
        private Button addEmployee_updateBtn;
        private Button addEmployee_addBtn;
        private Button addEmployee_importBtn;
        private Label employee_position;
        private ComboBox addEmployee_status;
        private Label label9;
        private MaskedTextBox addEmployee_birthday;
        private MaskedTextBox addEmployee_phoneNumber;
        private ComboBox addEmployee_position;
    }
}