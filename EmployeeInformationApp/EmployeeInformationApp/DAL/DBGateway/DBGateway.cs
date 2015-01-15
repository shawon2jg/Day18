using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformationApp.DAL.DAO;

namespace EmployeeInformationApp.DAL.DBGateway
{
    public class DBGateway
    {
        string connectionString = @"Data Source = SMSHAWON-PC; Database = EmployeeInformationDB; Integrated Security = true";
        private SqlConnection connection; 

        public void SaveDesignation(Designation aDesignation)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO tbl_designation VALUES('" + aDesignation.Code + "','" + aDesignation.Title + "')";
            SqlCommand aSqlCommand = new SqlCommand(query, connection);
            aSqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public Designation FindDesignationCode(string code)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM tbl_designation WHERE code = '"+code+"' ";
            SqlCommand aSqlCommand = new SqlCommand(query, connection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                Designation aDesignation = new Designation();
                aSqlDataReader.Read();
                aDesignation.DesId = Convert.ToInt32(aSqlDataReader["des_id"]);
                aDesignation.Code = aSqlDataReader["code"].ToString();
                aDesignation.Title = aSqlDataReader["title"].ToString();
                aSqlDataReader.Close();
                connection.Close();
                return aDesignation;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

        
        public void SaveEmployee(Employee aEmployee, Designation selecteDesignation)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO tbl_employee VALUES('" + aEmployee.Name + "','" + aEmployee.Email + "','" + aEmployee.Address + "','" + selecteDesignation.DesId + "')";
            SqlCommand aSqlCommand = new SqlCommand(query, connection);
            aSqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public Employee FindEmail(string email)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM tbl_employee WHERE email = '" + email + "' ";
            SqlCommand aSqlCommand = new SqlCommand(query, connection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                Employee aEmployee = new Employee();
                aSqlDataReader.Read();
                aEmployee.EmpId = Convert.ToInt32(aSqlDataReader["emp_id"]);
                aEmployee.Name = aSqlDataReader["name"].ToString();
                aEmployee.Email = aSqlDataReader["email"].ToString();
                aEmployee.Address = aSqlDataReader["address"].ToString();
                aSqlDataReader.Close();
                connection.Close();
                return aEmployee;
            }
            else
            {
                connection.Close();
                return null;
            }
        }
        public List<Designation> GetAllDesignationList()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM tbl_designation";
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();

            List<Designation> designationList = new List<Designation>();
            while (aReader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.DesId = (int)aReader["des_id"];
                //aDesignation.Code = aReader["code"].ToString();
                aDesignation.Title = aReader["title"].ToString();

                designationList.Add(aDesignation);
            }
            aReader.Close();
            connection.Close();
            return designationList;
        }

        public List<Employee> GetEmployeeList(string enterName)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "";
            if (!string.IsNullOrEmpty(enterName))
            {
                query = "SELECT * FROM tbl_employee WHERE name = '" + enterName + "'";
            }
            else
            {
                query = "SELECT * FROM tbl_employee";
            }
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                Employee aEmployee = new Employee();
                aEmployee.EmpId = (int)reader["emp_id"];
                aEmployee.Name = reader["name"].ToString();
                aEmployee.Email = reader["email"].ToString();
                aEmployee.Address = reader["address"].ToString();
                employeeList.Add(aEmployee);
            }
            reader.Close();
            connection.Close();
            return employeeList;
        }
    }
}
