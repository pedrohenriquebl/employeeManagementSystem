using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProjetoProgramacaoVIII
{
    class EmployeeData
    {
        public int ID { set; get; } // 0
        public string EmployeeID { set; get; } // 1
        public string Name { set; get; } // 2
        public string Gender { set; get; } // 3
        public string Contact { set; get; } // 4
        public string Position { set; get; } // 5
        public string Image { set; get; } // 6
        public double Salary { set; get; } // 7
        public string Status { set; get; } //8
        public string CPF { set; get; } //9
        public string Birthday { set; get; } //10
        public string Email { set; get; } //11


        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=projetoProgramacaoVIII;Integrated Security=True");

        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();            

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();                    

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();

                            ed.ID = (int)reader["id"];
                            ed.Name = reader["full_name"].ToString();
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.CPF = reader["cpf"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Birthday = !reader.IsDBNull(reader.GetOrdinal("birthday")) ? reader["birthday"].ToString() : null;
                            ed.Position = reader["position"].ToString();
                            ed.Email = reader["email"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Status = reader["status"].ToString();
                            ed.Salary = !reader.IsDBNull(reader.GetOrdinal("salary")) ? Convert.ToDouble(reader["salary"]) : 0.0;

                            listdata.Add(ed);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
