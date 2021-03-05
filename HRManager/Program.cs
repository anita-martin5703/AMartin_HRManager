// Anita Martin
// amartin98@cnm.edu
// Title: Abstract and Sealed Classes
// Objectives:
//      - Demonstrate how to declare and abstract classes and methods
//      - Demonstrate how to build constructors in derived classes.
//      - Demonstrate declaration of sealed methods and classes.
//      - Demonstrate how to build constructors in derived classes.
//      - Demonstrate how to use is and as operators.

// Program.cs


using System;
using System.Collections.Generic;

namespace HRManager

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myEmployees = new List<Employee>();

            HourlyEmployee hourEmp = new HourlyEmployee("Luke", "Skywalker", 201.00m);
            hourEmp.Hours.Add(80.00);
            hourEmp.Hours.Add(90.00);
            hourEmp.Hours.Add(70.00);

            SalaryEmployee salEmp = new SalaryEmployee("Darth", "Vader", 850000.00m);
            salEmp.Hours.Add(80.00);
            salEmp.Hours.Add(90.00);
            salEmp.Hours.Add(70.00);

            myEmployees.Add(hourEmp);
            myEmployees.Add(salEmp);

            decimal payroll = 0;
            foreach (Employee e in myEmployees)
            {
                payroll += e.Pay(0,2);
            }
            
            DisplayEmployeeInfo(hourEmp);
            Console.WriteLine();
            DisplayEmployeeInfo(salEmp);
            Console.WriteLine("\nPayroll total for 0-2: " + payroll.ToString("C"));
            Console.WriteLine();
            Console.WriteLine();

            foreach (Employee emp in myEmployees)
            {
                Console.WriteLine("Employee: " + emp);
                if(emp is HourlyEmployee)
                {
                    HourlyEmployee hourlyEmp= emp as HourlyEmployee;
                    Console.WriteLine("Hourly rate: " + hourlyEmp.HourlyRate);
                }
                if (emp is SalaryEmployee)
                {
                    // SalaryEmployee salaryEmp = emp as SalaryEmployee;   alternate below-->> seen more
                    // unboxing
                    SalaryEmployee salaryEmp = (SalaryEmployee)emp;
                    Console.WriteLine("Salary rate: " + salaryEmp.Salary);
                }
            }

        }

        private static void DisplayEmployeeInfo(Employee emp)
        {
            Console.WriteLine("Name: " + emp.FirstName + " " +emp.LastName);
            Console.WriteLine("\n\tToString: " + emp.ToString());
            Console.WriteLine("\n\tGetPaySummary : " + emp.PaySummary);
            Console.WriteLine("\n\tPay for period 0-2: " + emp.Pay(0, 2).ToString("C"));
        }
    }
}
