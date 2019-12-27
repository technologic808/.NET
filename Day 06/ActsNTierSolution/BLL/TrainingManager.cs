using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL
{
    public class TrainingManager
    {
        public static IEnumerable<Student> GetAllStudents() {
            List<Student> students = DAL.TrainingRepository.GetAll();

            var filteredStudents = from student in students
                                   where student.Age < 27
                                   select student;
            return filteredStudents;

        }
    }
}
