using baitapLab5._2;
using System;
public class Program
{
    static void Main(string[] args)
    {
        Department dev = new Department("Developers", 3);
        dev[0] = new Employee(1, "Tien", 26);
        dev[1] = new Employee(2, "Tan", 20);
        dev[2] = new Employee(3, "Tai", 20);
        Console.WriteLine("Danh sach nhan vien phong {0}:", dev.dpname);
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(dev[i]);
        }
    }
}