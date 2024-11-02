namespace ProjetoProgramacaoVIII
{
    partial class Salary
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            salary_clearBtn = new Button();
            salary_updateBtn = new Button();
            salary_salary = new TextBox();
            label5 = new Label();
            salary_position = new TextBox();
            label4 = new Label();
            salary_name = new TextBox();
            label3 = new Label();
            salary_employeeID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(salary_clearBtn);
            panel1.Controls.Add(salary_updateBtn);
            panel1.Controls.Add(salary_salary);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salary_position);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(salary_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(salary_employeeID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 541);
            panel1.TabIndex = 0;
            // 
            // salary_clearBtn
            // 
            salary_clearBtn.BackColor = Color.FromArgb(79, 0, 11);
            salary_clearBtn.Cursor = Cursors.Hand;
            salary_clearBtn.FlatAppearance.BorderSize = 0;
            salary_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            salary_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            salary_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            salary_clearBtn.FlatStyle = FlatStyle.Flat;
            salary_clearBtn.Font = new Font("Tahoma", 9F);
            salary_clearBtn.ForeColor = Color.White;
            salary_clearBtn.Location = new Point(119, 490);
            salary_clearBtn.Name = "salary_clearBtn";
            salary_clearBtn.Size = new Size(105, 35);
            salary_clearBtn.TabIndex = 20;
            salary_clearBtn.Text = "Clear";
            salary_clearBtn.UseVisualStyleBackColor = false;
            salary_clearBtn.Click += salary_clearBtn_Click;
            // 
            // salary_updateBtn
            // 
            salary_updateBtn.BackColor = Color.FromArgb(79, 0, 11);
            salary_updateBtn.Cursor = Cursors.Hand;
            salary_updateBtn.FlatAppearance.BorderSize = 0;
            salary_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            salary_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 0, 38);
            salary_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 38);
            salary_updateBtn.FlatStyle = FlatStyle.Flat;
            salary_updateBtn.Font = new Font("Tahoma", 9F);
            salary_updateBtn.ForeColor = Color.White;
            salary_updateBtn.Location = new Point(10, 490);
            salary_updateBtn.Name = "salary_updateBtn";
            salary_updateBtn.Size = new Size(105, 35);
            salary_updateBtn.TabIndex = 18;
            salary_updateBtn.Text = "Update";
            salary_updateBtn.UseVisualStyleBackColor = false;
            salary_updateBtn.Click += salary_updateBtn_Click;
            // 
            // salary_salary
            // 
            salary_salary.Location = new Point(8, 205);
            salary_salary.Name = "salary_salary";
            salary_salary.Size = new Size(213, 23);
            salary_salary.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 185);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "Salary:";
            // 
            // salary_position
            // 
            salary_position.Location = new Point(9, 154);
            salary_position.Name = "salary_position";
            salary_position.Size = new Size(213, 23);
            salary_position.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 134);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "Position: ";
            // 
            // salary_name
            // 
            salary_name.Location = new Point(10, 104);
            salary_name.Name = "salary_name";
            salary_name.Size = new Size(213, 23);
            salary_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 84);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // salary_employeeID
            // 
            salary_employeeID.Location = new Point(10, 54);
            salary_employeeID.Name = "salary_employeeID";
            salary_employeeID.Size = new Size(213, 23);
            salary_employeeID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 34);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 0;
            label2.Text = "Employee ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(265, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 541);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(11, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(572, 471);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox salary_salary;
        private Label label5;
        private TextBox salary_position;
        private Label label4;
        private TextBox salary_name;
        private Label label3;
        private TextBox salary_employeeID;
        private Label label2;
        private Button salary_clearBtn;
        private Button salary_updateBtn;
        private DataGridView dataGridView1;
    }
}