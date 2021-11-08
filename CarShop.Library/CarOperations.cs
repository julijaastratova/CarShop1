using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public class CarOperations : ICarOperations
    {
        //public List<Car> ListOfCars = new List<Car>();
        public Car[] CarArray = new Car[0];

        public void AddCarToTheList(Car car)
        {
            //ListOfCars.Add(car);
            Array.Resize(ref CarArray, CarArray.Length + 1);
            var count = CarArray.Count(x => x != null);
            CarArray[count] = car;
        }

        public Car FindCar(int year)
        {
            return null;
        }

        public void FindCar(Car car)
        {
            int counter = 0;
            for(int i=0; i< CarArray.Length; i++)
            {
                if (CarArray[i].Model == car.Model)
                {
                    Console.WriteLine("Found car:" + " Model: " + CarArray[i].Model);
                    Console.WriteLine("Found car:" + " Color: " + CarArray[i].Color);
                    Console.WriteLine("Found car:" + " Year: " + CarArray[i].Year);
                    counter++;
                }             
            }

            if(counter == 0)
            {
                Console.WriteLine("No cars found");
            }
        }

        public string GetReceipt()
        {
            return null;
        }

        public void AddCarbyCriteria(Car car)
        {
            var count = CarArray.Count(x => x != null);
            CarArray[count] = car;
        }

        public int FindAvailableCarsCount()
        {
            int counter = 0;

            for (int i = 0; i < CarArray.Length; i++)
            {
                counter++;
            }

            return counter;
        }

        public int FindAvailableCarsCount(object toInt32)
        {
            return 0;
        }
    }
}








//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace CarShop.Library
//{
//    public class CarOperations : ICarOperations
//    {
//        private List<Car> ListOfCars = new List<Car>();

//        public void AddCarToTheList(Car car)
//        {
//            ListOfCars.Add(car);
//        }
//        public int FindAvailableCarsCount()
//        {
//            return 1;
//        }
//        public Car FindCar(int year)
//        {
//            return null;
//        }
//        public string GetRecipiet()
//        {
//            return null;
//        }
//    }
//}

