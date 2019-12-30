using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    class UserRepository
    {
        // Get user based on parameter : username
        public static User GetUser()
        {
            // initializes an empty list
            User user = new User();

            /*Connection string : used to establish connection with database file*/
            //contains 1. locadb type, 2. provider name ,
            //3. database path, 4. Security mode

            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Documents\DOTNETLAB\Lab Evaluation Batch 03\ActsNTierSolution\ActsOnline\App_Data\ExamDatabase.mdf; Integrated Security = True";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT Id, UserName, Password from dbo.Users;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        user.Id = int.Parse(reader[0].ToString());
                        user.UserName = reader[1].ToString();
                        user.Password = reader[2].ToString();

                        return user;
                    }
                
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }


    }
}
