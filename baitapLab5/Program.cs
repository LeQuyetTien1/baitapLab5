using System;
using Dongvat.AnCo;
using Dongvat.AnThit;
using Dongvat.AnTap;
namespace Dongvat
{
    public class DongVat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public void ToString()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
        }
    }
    namespace AnCo
    {
        public class Bo : DongVat { }
        public class Trau : DongVat { }
        public class De : DongVat { }
    }
    namespace AnThit
    {
        public class CaSau : DongVat { }
        public class  Ho: DongVat { }
        public class SuTu : DongVat { }
    }
    namespace AnTap 
    {
        public class Lon : DongVat { }
        public class Gau : DongVat { }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Trau trau1 = new Trau() { ID = 1,Name="Trau1",Weight=300 };
            Ho ho1 = new Ho (){ ID = 2, Name = "Ho", Weight = 100 };
            Gau gau1 = new Gau() { ID = 3, Name = "Gau", Weight = 200 };
            trau1.ToString();
            ho1.ToString();
            gau1.ToString();
        }
    }
}