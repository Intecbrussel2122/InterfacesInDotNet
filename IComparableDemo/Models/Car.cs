using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo.Models
{
    public class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Year: {Year}";
        }

        int IComparable<Car>.CompareTo(Car other)
        {
            return this.Name.CompareTo(other.Name);
            //return this.Year.CompareTo(other.Year);
        }

        //public int CompareTo(Car car)
        //{
        //    return car.Name.CompareTo(Name);    
        //}

    }
}
