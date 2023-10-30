using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapLab5._2
{
    internal class Department
    {
        public string dpname {  get; set; }
        public Employee[] employees;
        public Department() { }
        public Department(string dpname, int n)
        {
            this.dpname = dpname;
            employees = new Employee[n];
        }
        public Employee this[int i]
        {
            get { return employees[i]; }
            set { employees[i] = value; }
        }
    }
}
