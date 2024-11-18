namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(0);

            Console.Write("Введите количество бензина для заправки: ");
            if (int.TryParse(Console.ReadLine(), out int fuelAmount))
            {
                myCar.Refuel(fuelAmount);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
            myCar.Drive();
        }
    }
}
