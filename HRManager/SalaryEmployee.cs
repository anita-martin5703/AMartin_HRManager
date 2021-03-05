// Anita Martin
// amartin98@cnm.edu
// Title: Abstract and Sealed Classes

// SalaryEmployee.cs

using System;

namespace HRManager
{
    class SalaryEmployee : Employee
    {
        public SalaryEmployee():this("","",30000.0m)
        { }
        public SalaryEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
            Salary = salary;
        }
        public decimal Salary { get; set; }

        public override string PaySummary
        {
            get
            {
                return "This employee is paid " + Salary + " per year.";
            }
        }

        public override decimal Pay(int start, int end)
        {
            const int payPeriodsPerYear = 24;
            decimal pay = Salary * (end - start) / payPeriodsPerYear;
            return pay;
        }

        public override string ToString()
        {
            return base.ToString() + " Salary Employee";
        }
    }
}
