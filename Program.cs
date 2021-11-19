using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Time;
            Console.Write("Время в секундах: ");
            Time = Convert.ToInt32(Console.ReadLine());
            int Sec = Time % 60;
            int Hour = Time / 3600;
            int Min = (Time / 60) % 60;
            Console.WriteLine($"{Time} сек. = {Hour} ч., {Min} мин. , {Sec} сек. ");


            int Len;
            Console.Write("Длина окружности: ");
            Len = Convert.ToInt32(Console.ReadLine());
            double R = Len / (2 * 3.1415926535);
            Console.WriteLine($"Радиус равен {R} ");


            Console.Write("Трехзначное целое число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int H = A / 100;
            int D = (A % 100) / 10;
            int U = A % 10;
            Console.Write($"{A} =\n Сотня: {H} \n Десяток: {D}\n Единица: {U}\n ");
        }
    }
}
