// Anita Martin
// amartin98@cnm.edu
// Title: Abstract and Sealed Classes

// HourlyEmployee.cs

namespace HRManager

{
    // if sealing a class use like this
    //     public sealed class HourlyEmployee : Employee
    //     look at TestSealed
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee():this("","", 7.50m)
        { }
        public HourlyEmployee(string firstName, string lastName, decimal hourRate): base(firstName, lastName)
        {
            HourlyRate = hourRate;
        }
        public decimal HourlyRate { get; set; }


        public override decimal Pay(int start, int end)
        {
            double hours = 0;
            for (int day = 0; day < end; ++day)
            {
                hours += Hours[day];
            }
            return (decimal)hours * HourlyRate;
        }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + HourlyRate + " per hour.";
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }

    }
}
