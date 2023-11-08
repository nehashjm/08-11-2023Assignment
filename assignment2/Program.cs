using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string employeename;
            char gender;
            double employeesalary;
            DateTime doj;
            Console.WriteLine("Enter Employee ID");
            ID = int.Parse(Console.ReadLine()); 
            Console.WriteLine("enter the employee name");
            employeename = Console.ReadLine();
            Console.WriteLine("enter employee gander ex M or F");
            gender = char.Parse(Console.ReadLine()); 
            Console.WriteLine("enter employee salary");
            employeesalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the date of joining");
            doj = DateTime.Parse(Console.ReadLine());

            if(employeesalary > 90000)
            {
                Console.WriteLine("ID \t  Employee name  \t Employee Gender \t Employee Salary \t DOJ" );
                Console.WriteLine("==================================================================================================");
                Console.WriteLine(ID +"\t \t" +employeename+"\t\t\t"+gender+"\t\t\t"+employeesalary+"\t\t"+doj);
                Console.WriteLine("you need to 30% Tax");
            }
            else
            {
                Console.WriteLine("ID \t  Employee name  \t Employee Gender \t Employee Salary \t DOJ");
                Console.WriteLine("===================================================================================================");
                Console.WriteLine(ID + "\t \t" + employeename + "\t\t\t" + gender + "\t\t\t" + employeesalary + "\t\t" + doj);
            }

            Console.ReadKey();
            
        }
    }
}
