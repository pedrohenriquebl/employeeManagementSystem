using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoProgramacaoVIII
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=projetoProgramacaoVIII;Integrated Security=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            formLogin loginForm = new formLogin();
            loginForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)

        {
            DateTime today = DateTime.Today;

            if (
                signup_username.Text == "" ||
                signup_password.Text == "" ||
                signup_cpf.Text == "" ||
                signup_telefone.Text == "" ||
                signup_email.Text == ""
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
                if (!IsValidEmail(signup_email.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    signup_email.Clear();
                    return;
                }

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectUserName = "SELECT COUNT(id) FROM users WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(selectUserName, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "Is already Taken!",
                                    "Information Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                            else
                            {
                                string insertData = "INSERT INTO users " +
                                    "(username, cpf, telefone, email, password, date_register) " +
                                    "VALUES(@username, @cpf, @telefone, @email, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cpf", signup_cpf.Text.Trim());
                                    cmd.Parameters.AddWithValue("@telefone", signup_telefone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!",
                                        "Information Message",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                    );

                                    formLogin loginForm = new formLogin();
                                    loginForm.Show();
                                    this.Hide();
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

        private void signup_cpf_TextChanged(object sender, EventArgs e)
        {
            var plainCpf = new string(signup_cpf.Text.Where(char.IsDigit).ToArray());

            if (plainCpf.Length > 11)
            {
                plainCpf = plainCpf.Substring(0, 11);
            }

            if (plainCpf.Length == 11)
            {
                signup_cpf.TextChanged -= signup_cpf_TextChanged;
                signup_cpf.Text = $"{plainCpf.Substring(0, 3)}.{plainCpf.Substring(3, 3)}.{plainCpf.Substring(6, 3)}-{plainCpf.Substring(9, 2)}";
                signup_cpf.SelectionStart = signup_cpf.Text.Length;
                signup_cpf.TextChanged += signup_cpf_TextChanged;
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void signup_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
