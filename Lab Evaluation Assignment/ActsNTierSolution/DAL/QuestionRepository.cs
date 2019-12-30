using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class QuestionRepository
    {
        // Get Questions

        public static List<Question> GetQuestions()
        {
            // initializes an empty list
            List<Question> questions = new List<Question>();

            /*Connection string : used to establish connection with database file*/
            //contains 1. locadb type, 2. provider name ,
            //3. database path, 4. Security mode

       
            string connectionString =  @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Documents\DOTNETLAB\Lab Evaluation Batch 03\ActsNTierSolution\ActsOnline\App_Data\ExamDatabase.mdf; Integrated Security = True";
           
            //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ExamDatabase.mdf;Integrated Security=True";


            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT Id, QuestionString, Answer, OptionOne, OptionTwo, OptionThree, OptionFour from dbo.Questions;";

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
                    while (reader.Read())
                    {
                        Question question = new Question();
                        question.Id = int.Parse(reader[0].ToString());
                        question.QuestionString = reader[1].ToString();
                        question.Answer = int.Parse(reader[2].ToString());
                        question.OptionOne = reader[3].ToString();
                        question.OptionTwo = reader[4].ToString();
                        question.OptionThree = reader[5].ToString();
                        question.OptionFour = reader[6].ToString();

                        //Populate the list
                        questions.Add(question);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return questions;
        }

    }
}
