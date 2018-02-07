using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(80);
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            myCar.Speed = 50;
            Console.WriteLine("MyCar is going {0} MPH", myCar.Speed);
            Console.WriteLine("MyVan is going {0} MPH", myVan.Speed);
            Console.ReadLine();
        }
    }
}
