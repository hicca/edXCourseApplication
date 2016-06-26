using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edXCourseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Henri";
            //string lastName = "Raadi";
            //string birthDate = "19/05/1991";
            //string addressLine1 = "Centurion Court";
            //string addressLine2 = "";
            //string city = "Cheltenham";
            //string state = "Gloucestershire";
            //string postal = "GL51";
            //string country = "England";

            //Console.WriteLine("{0} {1} \n{2} \n{3} \n{4}{5} \n{6} \n{7} \n{8}", firstName, lastName, birthDate, addressLine1, addressLine2, city, state, postal, country);
            //Console.ReadLine();
            string firstName;
            string lastName;
            string birthDate;
            GetStudentInformation(out firstName, out lastName, out birthDate);
            PrintStudentDetails(firstName, lastName, birthDate);
        }
        static void GetStudentInformation(out string firstName, out string lastName, out string birthDate)
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate: ");
            birthDate = Console.ReadLine();

            //Console.WriteLine("Enter the student's address line 1: ");
            //string addressLine1 = Console.ReadLine();
            //Console.WriteLine("Enter the student's address line 2: ");
            //string addressLine2 = Console.ReadLine();
            //Console.WriteLine("Enter the student's city: ");
            //string city = Console.ReadLine();
            //Console.WriteLine("Enter the student's state: ");
            //string state = Console.ReadLine();
            //Console.WriteLine("Enter the student's postcode: ");
            //string postal = Console.ReadLine();
            //Console.WriteLine("Enter the student's country: ");
            //string country = Console.ReadLine();
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine(first);
            Console.WriteLine(last);
            Console.WriteLine(birthday);
            Console.ReadLine();
        }
    }
}
