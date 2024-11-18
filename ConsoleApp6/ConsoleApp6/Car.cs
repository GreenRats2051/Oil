using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Car : IVehiculo
    {
        private int fuel;

        public Car(int initialFuel)
        {
            fuel = initialFuel;
        }

        public void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Автомобиль находится в движении.");
                fuel--;
            }
            else
            {
                Console.WriteLine("Недостаточно бензина для движения.");
            }
        }

        public bool Refuel(int amount)
        {
            if (amount > 0)
            {
                fuel += amount;
                Console.WriteLine($"Заправлено {amount} литров бензина. Текущий уровень бензина: {fuel} литров.");
                return true;
            }
            Console.WriteLine("Количество бензина для заправки должно быть положительным.");
            return false;
        }
    }
}
