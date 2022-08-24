using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestItem
{
    struct RequestItem
    {
        public double Kilkist;
        public string Name;
        

        public RequestItem(double kilkist, string name) : this()
        {
            Kilkist = kilkist;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine($" Kilkist {Kilkist}, Name {Name}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilkist = 100;
            string name = "Call of Duti: Warzon";
            RequestItem requestItem = new RequestItem(kilkist, name);
            requestItem.Print();
        }
    }
}
