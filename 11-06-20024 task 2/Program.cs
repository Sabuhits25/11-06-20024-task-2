namespace _11_06_20024_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(2024,"Audi","RS6");
            Bus bus = new Bus(2023);

            Vehicle[] vehicles = { car, bus };
            foreach(var item in vehicles)
            {
                item.ShowInfo();
            }
        }
    }
}
