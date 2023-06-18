using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheiratance
{
    internal class Vehicle
    {
        public string Manufacturer;
        public int Year;
        public Vehicle(string manumacture, int year) 
        {
            Manufacturer = manumacture;
            Year = year;
        }
    }

    internal class Car :Vehicle
    {
        string model;
        int numberOfDoor;

        public Car(string manumacture, int year, string model, int numberofdoor) : base(manumacture, year)
        {
            this.model = model;
            numberOfDoor = numberofdoor;
        }

        public void getviehcleinfo()
        {
            Console.WriteLine(Manufacturer + " " + Year + " " + model + " " + numberOfDoor);
        }
    }
}
