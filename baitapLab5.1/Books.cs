using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5bai5._1
{
    internal class Book
    {
        private int id;
        private string title;
        private int price;
        private string publisher;

        public int Id
        {
            get { return 1; }

        }
        public string Title
        {
            get { return "Test"; }

        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        #region
        public void ToString()
        {
            Console.WriteLine("---Thong tin sach---");
            Console.WriteLine("Ma id: " + Id);
            Console.WriteLine("Tieu de: " + Title);
            Console.WriteLine("Gia: " + Price);
            Console.WriteLine("NXB: " + Publisher);
        }
        #endregion
    }
}
