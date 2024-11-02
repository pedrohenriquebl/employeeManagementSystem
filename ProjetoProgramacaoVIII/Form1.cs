using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoProgramacaoVIII
{
    public partial class formLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=projetoProgramacaoVIII;Integrated Security=True");

        public formLogin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signUpBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                        {
                            cmd.Parameters.AddWithValue("username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfuly!",
                                    "Information Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            } else
                            {
                                MessageBox.Show("Incorrect Username/Password!",
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
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
    }
}
