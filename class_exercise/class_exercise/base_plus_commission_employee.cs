using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_exercise
{
    public class base_plus_commission_employee : commission_employee
    {
        double base_salary;
        public void Base_plus_commission_employee(double z)
        { base_salary = z; }
        public override double getSalary()
        {
            return base_salary + base.getSalary();
        }
        public override string ToString()
        {
            string x = "Base Salaried Commission Employee: " + base.ToString() + "\n" + "Base Salary: " + base_salary;
            return x;
        }
    }
}
