﻿using System;
using System.Collections.Generic;
using System.Linq;
using CarShop.Library;

namespace CarShop.Frontend
{
    class Program
    {
        static readonly CarOperations CarOperator = new CarOperations();

        static void Main(string[] args)
        {
            //ShowMenu();

            string exit = "continue";

            while (exit == "continue")
            {
                ShowMenu();

                string option = Console.ReadLine();

                if (option.Equals("exit"))
                {
                    exit = option;
                }

                switch (option)
                {
                    case "1":
                        //Add car to the list
                        AddCarToTheList();
                        break;
                    case "2":
                        //Find a car by criteria
                        FindCarbyCriteria();
                        break;
                    case "3":
                        //Get available cars
                        FindAvailableCarsCount();
                        break;
                }
            };
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Please choose car operation:");
            Console.WriteLine("1. Add car to the shop");
            Console.WriteLine("2. Find car by criteria");
            Console.WriteLine("3. Get available cars");
        }

        public static Car CreateCarObject()
        {
            var car = new Car();

            Console.WriteLine("Please add car model:");
            car.Model = Console.ReadLine();

            Console.WriteLine("Add car color");
            car.Color = Console.ReadLine();

            Console.WriteLine("Add car year");
            //car.Year = Convert.ToInt32(Console.ReadLine());

            while (!int.TryParse(Console.ReadLine(), out var input1))
            {
                Console.WriteLine("Incorrect input! Please use numbers when entering year");
            }

            if(int.TryParse(Console.ReadLine(), out var input2))
            {
                car.Year = input2;
            }

            return car;
        }

        public static void AddCarToTheList()
        {
            var continues = true;

            while (continues)
            {
                var car = CreateCarObject();
                CarOperator.AddCarToTheList(car);

                Console.WriteLine("Do you want to create more cars?(Yes/No)");

                var yesNo = Console.ReadLine();
                if (yesNo != "Yes")
                {
                    continues = false;
                }
            }
        }

        public static Car SearchingForTheCar()
        {
            var car = new Car();

            Console.WriteLine("Enter the desired model:");
            car.Model = Console.ReadLine();

            Console.WriteLine("Enter the car color");
            car.Color = Console.ReadLine();

            Console.WriteLine("Enter the car year");
            //car.Year = Convert.ToInt32(Console.ReadLine());

            while (!int.TryParse(Console.ReadLine(), out var input1))
            {
                Console.WriteLine("Incorrect input! Please use numbers when entering year");
            }

            if (int.TryParse(Console.ReadLine(), out var input2))
            {
                car.Year = input2;
            }

            return car;
        }

        public static void FindCarbyCriteria()
        {
            var continues = true;

            while (continues)
            {
                var car = SearchingForTheCar();
                CarOperator.FindCar(car);

                Console.WriteLine("Do you want find another car by criteria?(Yes/No)");

                var yesNo = Console.ReadLine();
                if (yesNo != "Yes")
                {
                    continues = false;
                }
            }
        }

        public static Car AvailableCar()
        {
            var car = new Car();

            Console.WriteLine(car.IsAvailable);

            return car;
        }

        public static void FindAvailableCarsCount()
        {
            var continues = true;

            while (continues)
            {
                var car = AvailableCar();
                CarOperator.FindAvailableCarsCount(car);

                Console.WriteLine("Available cars: +");

                var yesNo = Console.ReadLine();
                if (yesNo != "Yes")
                {
                    continues = false;
                }
            }
        }
    }
}
