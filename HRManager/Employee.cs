// Anita Martin
// amartin98@cnm.edu
// Title: Abstract and Sealed Classes

// Employee.cs

using System;
using System.Collections.Generic;

namespace HRManager

{
    public abstract class Employee
    {
        private static int LastEmpNum = 1;
        public Employee()
        {
            EmpNum = LastEmpNum++;
        }

        public Employee(string firstName, string lastName):this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int EmpNum { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        private List<double> hours = new List<double>();
        public List<double> Hours
        {
            get { return hours; }
            set { hours = value; }
        }


        public abstract Decimal Pay(int start, int end);


        public abstract string PaySummary
        { get; }

        public override string ToString()
        {
            return EmpNum + " " + FirstName + " " + LastName;
        }
    }
}
