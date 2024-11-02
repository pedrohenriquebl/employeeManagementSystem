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
using EmployeeManagementSystem;

namespace ProjetoProgramacaoVIII
{
    public partial class Salary : UserControl
    {
        private readonly string connectionString = @"Data Source=localhost;Initial Catalog=projetoProgramacaoVIII;Integrated Security=True";

        public Salary()
        {
            InitializeComponent();
            DisplayEmployees();
            DisableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayEmployees();
            DisableFields();
        }

        public void DisableFields()
        {
            salary_employeeID.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }

        public void DisplayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        public void clearFields()
        {
            salary_employeeID.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
            salary_salary.Text = "";
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_employeeID.Text = row.Cells[0].Value.ToString();
                salary_name.Text = row.Cells[1].Value.ToString();
                salary_position.Text = row.Cells[4].Value.ToString();
                salary_salary.Text = row.Cells[5].Value.ToString();
            }
        }

        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if (salary_employeeID.Text == ""
                || salary_name.Text == ""
                || salary_position.Text == ""
                || salary_salary.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", 
                    "Error Message", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: " +
                    salary_employeeID.Text.Trim() + "?", 
                    "Confirmation Message",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                );

                if (check == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(connectionString))

                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            if (!float.TryParse(salary_salary.Text.Trim(), out float salaryValue))
                            {
                                MessageBox.Show("Invalid salary format. Please enter a valid number.", 
                                    "Error Message",
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error
                                );

                                return;
                            }

                            string updateData = "UPDATE employees SET salary = @salary" +
                                ", update_date = @updateData WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salaryValue);
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                DisplayEmployees();

                                MessageBox.Show("Updated successfully!",
                                    "Information Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex,
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
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
