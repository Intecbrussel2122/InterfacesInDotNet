using IComparableDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IComparableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            cars[0] = new Car() { Name = "BMW", Year = 2020 };
            cars[1] = new Car() { Name = "Volvo", Year = 2015 };
            cars[2] = new Car() { Name = "Audi", Year = 2011 };

            Array.Sort(cars);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
