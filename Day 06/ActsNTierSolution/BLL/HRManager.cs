using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class HRManager
    {
        public static List<Employee> GetEmployees() {
            return HRRepository.GetEmployees();
        }
    }
}
