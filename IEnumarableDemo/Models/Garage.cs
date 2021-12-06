using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarableDemo.Models
{
    //public class Garage:IEnumerable<Car> // This is for generic use for Car class
    //public class Garage:IEnumerable // this is for non-generic use 
    // public class Garage  // this will work without implementing IEnumareable, instead we just write GetEnumerator() method 
    public class Garage //: IEnumerable<Car>
    {
        private Car[] _cars = new Car[3];
        public Garage()
        {
            _cars[0] = new Car { Name = "Bmw", Year = 2015 };
            _cars[1] = new Car { Name = "Ford", Year = 2021 };
            _cars[2] = new Car { Name = "Volvo", Year = 2020 };
        }

        //public IEnumerator<Car> GetEnumerator()
        //{
        //    return ((IEnumerable<Car>)_cars).GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return _cars.GetEnumerator();
        //}

        public IEnumerator GetEnumerator()
        {
            return _cars.GetEnumerator();
        }
    }
}
