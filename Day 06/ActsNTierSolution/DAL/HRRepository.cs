using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class HRRepository
    {
         
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            /*Connection string : used to establish connection with database file*/
            //contains 1. locadb type, 2. provider name ,
            //3. database path, 4. Security mode

            string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ActsDatabase.mdf;Integrated Security=True";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT id, name, age, phone from dbo.employees;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = int.Parse(reader[0].ToString());
                        employee.Name = reader[1].ToString();
                        employee.Age = int.Parse(reader[2].ToString());
                        employee.Phone = reader[3].ToString();

                        
                        //Populate the list
                        employees.Add(employee);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }

            return employees;
        }

        public Employee Get(int Id)
        {
            return null;
        }
    }
}
