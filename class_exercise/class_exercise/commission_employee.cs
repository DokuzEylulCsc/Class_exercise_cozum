using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_exercise
{
    public class commission_employee : employee
    {
        double gross_sales;
        double commission_rate;
        public void Commission_employee(double x, double y)
        {
            gross_sales = x;
            commission_rate = y;
        }
        public override double getSalary()
        {
            return gross_sales * commission_rate;
        }
        public override string ToString()
        {
            string x = "Commission Employee: " + base.ToString() + "\n" + "Gross Sales: " + gross_sales + "\n" + "Commission Rate: " + commission_rate;
            return x;
        }
    }
}
