using IEnumarableDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Console.WriteLine("Cars in the garage");

            foreach (var item in garage)
            {
                Console.WriteLine(item);
            }
        }
    }
}
