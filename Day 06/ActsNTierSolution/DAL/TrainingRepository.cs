using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public static class TrainingRepository
    {
        public static List<Student> GetAll()
        {
            var students = new List<Student>{
                            new Student() { Id = 1, Name = "Raj", Age = 18 } ,
                            new Student() { Id = 2, Name = "Steve",  Age = 21 } ,
                            new Student() { Id = 3, Name = "Bill",  Age = 25 } ,
                            new Student() { Id = 4, Name = "Reena" , Age = 20 } ,
                            new Student() { Id = 5, Name = "Smith" , Age = 31 } ,
                            new Student() { Id = 4, Name = "Chris" , Age = 17 } ,
                            new Student() { Id = 4, Name = "Ravi" , Age = 44 }
                        };
            return students;
        }
    }
}
