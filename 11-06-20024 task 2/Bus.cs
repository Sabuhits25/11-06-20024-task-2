using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06_20024_task_2
{
    internal class Bus:Vehicle
    {
        public int PassengerCount { get; set; }
        public Bus (int year) : base(year)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Year:{Year}");
        }
    }
}
