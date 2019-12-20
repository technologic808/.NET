using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Person
    {


        // declare fields
        private String _firstName, _lastName, _email, _location;
        private DateTime _birthDate;


        // declare properties
        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                _birthDate = value;
            }
        }

        // parameterless constructor
        public Person()
        {

        }


        public Person(String fName, String lName, DateTime birthDate, String email, String location)
        {
            this.FirstName = fName;
            this._lastName = lName;
            this.BirthDate = birthDate;
            this.Email = email;
            this._location = location;
        }

        public override string ToString()
        {
            return "\nDetails: \n" + FirstName + " " + _lastName + "\n" +
                "Date of Birth : " + BirthDate + "\n" +
                "Email : " + Email + "\n" +
                "Location : " + Location;
        }
        ~Person()
        {

        }
        public virtual double computePay() { return -1;  }

    }

    public class Employee : Person
    {

        public override string ToString()
        {
            return base.ToString() + "\nSalary: " + Salary;
        }

        private double _salary;

        public Employee()
        {
        }

        public Employee(String fName, String lName, DateTime birthDate, String email, String location, double salary)
        {
            // properties of person
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Location = location;

            // property of employee
            this.Salary = salary;

        }

        public double Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }

        public override double computePay()
        {
            return Salary;
        }
    }

    public class Manager : Employee
    {

        public override string ToString()
        {
            return base.ToString() + "\nIncentive: " + ManagerIncentive;
        }

        private double _managerIncentive;

        public double ManagerIncentive
        {
            get
            {
                return _managerIncentive;
            }

            set
            {
                _managerIncentive = value;
            }
        }

        public Manager()
        {

        }

        public Manager(String fName, String lName, DateTime birthDate, String email, String location, double salary, double managerIncentive)
        {
            // properties of person
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Location = location;

            // property of employee
            this.Salary = salary;

            // property of manager
            this.ManagerIncentive = managerIncentive;

        }

        public override double computePay()
        {
            return Salary + ManagerIncentive;
        }

    }
    public class SalesManager : Manager
    {

        public override string ToString()
        {
            return base.ToString() + "\nBonus: " + SalesBonus;
        }

        private double _salesBonus;

        public double SalesBonus
        {
            get
            {
                return _salesBonus;
            }

            set
            {
                _salesBonus = value;
            }
        }

        public SalesManager()
        {

        }

        public SalesManager(String fName, String lName, DateTime birthDate, String email, String location, double salary, double managerIncentive, double salesBonus)
        {
            // properties of person
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Location = location;

            // property of employee
            this.Salary = salary;

            // property of manager
            this.ManagerIncentive = managerIncentive;

            // property of salesmanager
            this.SalesBonus = salesBonus;

        }

        public override double computePay()
        {
            return Salary + ManagerIncentive + SalesBonus;
        }



    }
}