using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_exercise
{
    public class salaried_employee : employee
    {
        double weekly_salary;
        public void Salaried_employee(double x)
        {
            weekly_salary = x;
        }
        public override double getSalary()
        {
            return weekly_salary;
        }
        public override string ToString()
        {
            string x = "Salaried Employee: " + base.ToString() + "\n" + "Weekly Salary: " + getSalary();
            return x;
        }
    }
}
