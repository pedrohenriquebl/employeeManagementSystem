using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ProjetoProgramacaoVIII
{
    public partial class AddEmployee : UserControl
    {
        private readonly string connectionString = @"Data Source=localhost;Initial Catalog=projetoProgramacaoVIII;Integrated Security=True";
        
        public AddEmployee()
        {
            InitializeComponent();
            DisplayEmployeeData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayEmployeeData();
        }

        public void DisplayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (
                addEmployee_id.Text == "" ||
                addEmployee_fullName.Text == "" ||
                addEmployee_gender.Text == "" ||
                addEmployee_phoneNumber.Text == "" ||
                addEmployee_position.Text == "" ||
                addEmployee_cpf.Text == "" ||
                addEmployee_birthday.Text == "" ||
                addEmployee_email.Text == "" ||
                addEmployee_status.Text == ""
            )
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                if (!IsValidEmail(addEmployee_email.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    addEmployee_email.Clear();
                    return;
                }

                using (SqlConnection connect = new SqlConnection(connectionString))

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkEmId = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand chechEm = new SqlCommand(checkEmId, connect))
                        {
                            chechEm.Parameters.AddWithValue("@emID", addEmployee_id.Text.Trim());
                            int count = (int)chechEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " Is already taken",
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO employees " +
                                    "(employee_id , full_name, contact_number, gender, cpf,  salary, birthday, email, position, image, status, insert_date)" +
                                    "VALUES(@employeeId, @fullName, @contactNumber, @gender, @cpf, @salary, @birthday, @email, @position, " +
                                    "@image, @status, @insertDate)";

                                string path = Path.Combine(@"C:\Users\pedru\source\repos\ProjetoProgramacaoVIII\ProjetoProgramacaoVIII\Directory\"
                                   + addEmployee_picture.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeId", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNumber", addEmployee_phoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cpf", addEmployee_cpf.Text.Trim());
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@birthday", addEmployee_birthday.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", addEmployee_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertDate", today);

                                    cmd.ExecuteNonQuery();

                                    DisplayEmployeeData();
                                    MessageBox.Show("Added sucessfully!",
                                        "Information Message",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                    );

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmployee_cpf_TextChanged(object sender, EventArgs e)
        {
            var plainCpf = new string(addEmployee_cpf.Text.Where(char.IsDigit).ToArray());

            if (plainCpf.Length > 11)
            {
                plainCpf = plainCpf.Substring(0, 11);
            }

            if (plainCpf.Length == 11)
            {
                addEmployee_cpf.TextChanged -= addEmployee_cpf_TextChanged;
                addEmployee_cpf.Text = $"{plainCpf.Substring(0, 3)}.{plainCpf.Substring(3, 3)}.{plainCpf.Substring(6, 3)}-{plainCpf.Substring(9, 2)}";
                addEmployee_cpf.SelectionStart = addEmployee_cpf.Text.Length;
                addEmployee_cpf.TextChanged += addEmployee_cpf_TextChanged;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployee_picture.ImageLocation = imagePath
    ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex,
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            addEmployee_id.Text = "";
            addEmployee_fullName.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phoneNumber.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_cpf.Text = "";
            addEmployee_birthday.Text = "";
            addEmployee_email.Text = "";
            addEmployee_status.SelectedIndex = -1;
            addEmployee_picture.Text = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_id.Text = row.Cells[1].Value.ToString();
                addEmployee_fullName.Text = row.Cells[2].Value.ToString();
                addEmployee_gender.Text = row.Cells[3].Value.ToString();
                addEmployee_phoneNumber.Text = row.Cells[4].Value.ToString();
                addEmployee_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    addEmployee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmployee_picture.Image = null;
                }

                addEmployee_status.Text = row.Cells[8].Value.ToString();
                addEmployee_cpf.Text = row.Cells[9].Value.ToString();
                addEmployee_birthday.Text = row.Cells[10].Value.ToString();
                addEmployee_email.Text = row.Cells[11].Value.ToString();
            }
        }


        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (
               addEmployee_id.Text == "" ||
               addEmployee_fullName.Text == "" ||
               addEmployee_gender.Text == "" ||
               addEmployee_phoneNumber.Text == "" ||
               addEmployee_position.Text == "" ||
               addEmployee_cpf.Text == "" ||
               addEmployee_birthday.Text == "" ||
               addEmployee_email.Text == "" ||
               addEmployee_status.Text == ""
            )
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you wuant to UPDATE " +
                    "Employee ID: " + addEmployee_id.Text.Trim() + "?",
                    "Confirmation Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (check == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))

                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET full_name = @fullname, contact_number = @contactNumber" +
                            ", gender = @gender, cpf = @cpf, birthday = @birthday, email = @email, position = @position" +
                            ", update_date = @updateDate, status = @status " +
                            "WHERE employee_id =@employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNumber", addEmployee_phoneNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@cpf", addEmployee_cpf.Text.Trim());
                            cmd.Parameters.AddWithValue("@salary", 0);
                            cmd.Parameters.AddWithValue("@birthday", addEmployee_birthday.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", addEmployee_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            DisplayEmployeeData();

                            MessageBox.Show("Updated sucessfully!",
                                "Information Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Canceled.",
                        "Information Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (
               addEmployee_id.Text == "" ||
               addEmployee_fullName.Text == "" ||
               addEmployee_gender.Text == "" ||
               addEmployee_phoneNumber.Text == "" ||
               addEmployee_position.Text == "" ||
               addEmployee_cpf.Text == "" ||
               addEmployee_birthday.Text == "" ||
               addEmployee_email.Text == "" ||
               addEmployee_status.Text == ""
            )
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you wuant to DELETE " +
                    "Employee ID: " + addEmployee_id.Text.Trim() + "?",
                    "Confirmation Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (check == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))

                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string deleteData = "UPDATE employees SET delete_date = @deleteDate " + 
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {                            
                            cmd.Parameters.AddWithValue("@deleteDate", today);                           
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            DisplayEmployeeData();

                            MessageBox.Show("Deleted sucessfully!",
                                "Information Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Canceled.",
                        "Information Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
    }
}
