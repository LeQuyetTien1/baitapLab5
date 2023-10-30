using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapLab5._2
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Employee() { }
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return "ID: " + id + "\nName: " + name + "\nAge: " + age;
        }
    }
}
