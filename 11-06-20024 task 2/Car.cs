using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06_20024_task_2
{
    public class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Car(int year,string brand,string model) : base(year)
        {
            
            Brand = brand;
            Model = model;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand},Model:{Model}");


        }
    }

}
