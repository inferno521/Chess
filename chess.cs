using System;

namespace sharmanka521
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1,x2,y1,y2;
            Console.WriteLine("Введите координату по горизонтали");
            x1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите координату по вертикали");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1-я координата: ");
            Console.WriteLine($"{x1}, {y1}");
            Console.WriteLine("Введите следующую координату по горизонтали");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите следующую координату по вертикали");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-я координата: ");
            Console.WriteLine($"{x2}, {y2}"); 
            if (x1==x2 || y1==y2 )
            {
                Console.WriteLine("Ладья сможет перейти из этой координаты во вторую.");
            }
            else
            {
                Console.WriteLine("Ладья не сможет перейти из этой координаты во вторую.");
            }
        }
        
    }
}
