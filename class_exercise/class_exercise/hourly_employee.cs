using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_exercise
{
    public class hourly_employee : employee
    {
        double wage;
        double hours;
        public void Hourly_employee(double x, double y)
        {
            wage = x;
            hours = y;
        }
        public override double getSalary()
        {
            if (hours < 40)
                return wage * hours;
            else
                return wage * 40 + (wage * 1.5 * (hours-40));
        }
        public override string ToString()
        {
            string x = "Hourly Employee: " + base.ToString() + "\n" + "Hourly Wage: " + wage + "\n" + "Hourly Worked: " + hours;
            return x;
        }
    }
}
