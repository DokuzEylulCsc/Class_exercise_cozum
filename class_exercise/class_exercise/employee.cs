using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_exercise
{
    public abstract class employee
    {
        string f_name;
        string l_name;
        int ssn;
        public void Employee(string a,string b, int c)
        {
            f_name = a;
            l_name = b;
            ssn = c;
        }
        public abstract double getSalary();
        public override string ToString()
        {
           string x = f_name + " " + l_name + "\n" + "Social Security Number: " + ssn;
            return x;
        }
    }
}
