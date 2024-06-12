using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06_20024_task_2
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }


        public Vehicle(int year)
        {
            Year = year;
        }
        public abstract void ShowInfo();
    }
}
