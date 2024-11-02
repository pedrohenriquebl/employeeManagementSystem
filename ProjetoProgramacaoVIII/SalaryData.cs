using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class SalaryData
    {        
        public string EmployeeID { set; get; } // 1
        public string Name { set; get; } // 2
        public string Gender { set; get; } // 3
        public string Contact { set; get; } // 4
        public string Position { set; get; } // 5        
        public double Salary { set; get; } // 6
        public string CPF { set; get; } //7
        public string Birthday { set; get; } //8
        public string position {  set; get; } //9
        public string Email { set; get; } //10       



        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=projetoProgramacaoVIII;Integrated Security=True");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE status = 'Active' " +
                        "AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.EmployeeID = reader["employee_id"].ToString();
                            sd.Name = reader["full_name"].ToString();
                            sd.Gender = reader["gender"].ToString();
                            sd.Contact = reader["contact_number"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Salary = !reader.IsDBNull(reader.GetOrdinal("salary")) ? Convert.ToDouble(reader["salary"]) : 0.0;
                            sd.CPF = reader["cpf"].ToString();
                            sd.Birthday = !reader.IsDBNull(reader.GetOrdinal("birthday")) ? reader["birthday"].ToString() : null;
                            sd.Position = reader["position"].ToString();
                            sd.Email = reader["email"].ToString();

                            listdata.Add(sd);
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
