using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
using GraphicsLib;
using BankingLib;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Complex c1 = new Complex(2, 3);

            Complex c2 = new Complex();

            c2.Real = 4;
            c2.Imaginary = 5;

            Complex c3 = c1 + c2;
            Complex c4 = c1 - c2;
            Complex c5 = c1 * c2;
            Complex c6 = c1 / c2;

            Console.WriteLine("Number One : "  + c1);
            Console.WriteLine("Number Two : " + c2);
            Console.WriteLine("One + Two : " + c3);
            Console.WriteLine("One - Two : " + c4);
            Console.WriteLine("One * Two : " + c5);
            Console.WriteLine("One / Two : " + c6);


            Person p1 = new Person("John", "Doe" , new DateTime(1990, 12 ,21), "john.doe@gmail.com", "Moon Base");

            Person p2 = new Employee("Tron", "Foe", new DateTime(1991, 11, 22), "tron.foe@gmail.com", "International Space Station", 1000);

            Person p3 = new Manager("Cron", "Job", new DateTime(1992, 10, 23), "cron.job@gmail.com", "Mars Space Station", 1000, 100);

            Person p4 = new SalesManager("Fawn", "Doe", new DateTime(1993, 09, 24), "fawn.doe@gmail.com", "Central Park Zoo", 1000, 100, 10);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.WriteLine("\nNet Pay for Person: " + p1.computePay());
            Console.WriteLine("\nNet Pay for Employee: " + p2.computePay());
            Console.WriteLine("\nNet Pay for Manager: " + p3.computePay());
            Console.WriteLine("\nNet Pay for Sales Manager: " + p4.computePay());


            Shape s1 = new Line(new Point(0, 0), new Point(5, 10));
            Shape s2 = new Rectangle(new Point(1,1), new Point(10, 5));

            Console.WriteLine("Line: " + s1);
            Console.WriteLine("Rectangle: " + s2);

            s1.draw();
            s2.draw();

            Account a1 = new Account();

            // Initial balance
            a1.Balance = 100;

            Console.WriteLine(a1);

            // deposit
            Console.WriteLine("Depositing 50");
            a1.deposit(50);

            Console.WriteLine(a1);

            // withdraw
            Console.WriteLine("withdrawing 150");
            a1.withdraw(150);

            Console.WriteLine(a1);


            Console.ReadLine();
        }
    }

    public class Complex
    {

        private static int _count;

        public static int Count
        {
            get { return _count; }
            set
            {
                _count = value;
            }
        }

        private int _real;
        public int Real
        {
            get { return _real; }
            set
            {
                _real = value;
            }
        }
        private int _imaginary;

        public int Imaginary
        {
            get { return _imaginary; }
            set
            {
                _imaginary = value;
            }
        }

        public Complex(int r, int i)
        {
            _real = r;
            _imaginary = i;
        }

        public Complex()
        {

        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2._real, c1.Imaginary - c2._imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2._real, c1.Imaginary * c2._imaginary);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex(c1.Real / c2._real, c1.Imaginary / c2._imaginary);
        }

        public override string ToString()
        {
            return "Real : " + this.Real + " and Imaginary : " + this.Imaginary;
        }

        ~Complex()
        {

        }
    }
}
