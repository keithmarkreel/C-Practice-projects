using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Xml.Linq;

namespace CalorieTracker
{
    class Food     {
        private int _Calories;
        public string Name { get; set; }
        public int Calories {
            
            get { return _Calories; } 
            
            set{
                if (value < 0)
                {
                    throw new ArgumentException("Calories cannot be negative.");
                }
                else
                {
                    _Calories = value;
                }
            }

        }
        
        public Food(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }
    }

    class Parts
    {
        public string partName { get; set; }
        public string partPrice { get; set; }
            public Parts(string name, string price) //CONSTRUCTOR
            {
                partName = name;
                partPrice = price;
        }
    }

    class PC : Parts
    {
        public string PCpartBrand { get; set; }

        public PC(string name, string price, string brand) : base(name, price) //THIS IS A CONSTRUCTOR FOR THE PC CLASS, IT INHERITS THE NAME AND PRICE FROM THE PARTS CLASS 
        {                                                                       //the public PC() takes data then the "base" transfers the data to the Parts class
            PCpartBrand = brand;
        }
    }
    class Program
    {
        static void Main()
        {
            List<Food> foodList = new List<Food>();
            
            string optionInput = "test";

            while (optionInput != "exit")
            {
                Program.PrintUI();
                optionInput = Console.ReadLine();
                if (optionInput == "1")
                {
                    GetCalories(foodList);
                    
                }
                else if (optionInput == "2")
                {
                   
                    ViewCalories(foodList);

                }
            }


        }

        static void PrintUI()
        {
            Console.WriteLine("Welcome to the Calorie Tracker!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add Food and Calories");
            Console.WriteLine("2. View Calories");

        }
        static void GetCalories(List <Food> foodList)
        {
            
            Console.WriteLine("Enter Food");
            string FoodName = Console.ReadLine();
            Console.WriteLine("Enter Calories of that food");
            string Calories = Console.ReadLine();
            Food newEntry = new Food(FoodName, int.Parse(Calories));
            foodList.Add(newEntry);
            return;
          
        }

        static void ViewCalories(List<Food> foodList)
        {
            int total = 0;
            foreach(Food food in foodList)
            {
                Console.WriteLine($"Food: {food.Name}, Calories: {food.Calories}");
                total += food.Calories;
            }
            Console.WriteLine("Total Calories: " + total);
            Console.WriteLine("\n");
            Console.WriteLine("Press any to return to menu");
            Console.ReadLine();
        }

    }
}