using System;

namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            // Условие нахождения внутри: круг радиуса 1, но исключая первую четверть (где x > 0 и y > 0)
            if ((x * x + y * y < 1) && !(x > 0 && y > 0))
            {
                Console.WriteLine("да");
            }
            else
            {
                // Проверка нахождения на границе (дуга окружности без 1-й четверти, а также оси координат в пределах от -1 до 1)
                bool onArc = (Math.Abs(x * x + y * y - 1) < 1e-9) && !(x > 0 && y > 0);
                bool onAxes = (Math.Abs(x) < 1e-9 && y >= -1 && y <= 1) || (Math.Abs(y) < 1e-9 && x >= -1 && x <= 1);

                if (onArc || onAxes)
                {
                    Console.WriteLine("на границе");
                }
                else
                {
                    Console.WriteLine("нет");
                }
            }
        }
    }
}