using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void task1()
        {
            Console.Write("Площадь помещения (м2): ");
            double squareMeter = double.Parse(Console.ReadLine());

            Console.Write("Количество проживающих людей: ");
            int numberOfResidents = int.Parse(Console.ReadLine());

            Console.Write("Сезон (осень/зима): ");
            string season = Console.ReadLine();

            Console.Write("Ветеран труда (да/нет): ");
            bool isVeteran = Console.ReadLine().ToLower() == "да";

            Console.Write("Ветеран войны (да/нет): ");
            bool isWarVeteran = Console.ReadLine().ToLower() == "да";

            
            double otoplenie = 2.0; 
            double water = 1.0;   
            double gas = 1.5;     
            double remont = 5.0;  

           
            double otopleniePay = squareMeter * otoplenie * (season.ToLower() == "зима" ? 1.5 : 1.0);
            double waterPay = numberOfResidents * water;
            double gasPay = numberOfResidents * gas;
            double remontPay = squareMeter * remont;

            double totalPayment = otopleniePay + waterPay + gasPay + remontPay;

            
            if (isVeteran)
            {
                totalPayment -= otopleniePay * 0.3; 
            }

            if (isWarVeteran)
            {
                totalPayment -= otopleniePay * 0.5; 
            }

            // Вывод таблицы
            Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t{otopleniePay}\t{(isVeteran ? otopleniePay * 0.3 : 0)}\t{otopleniePay - (isVeteran ? otopleniePay * 0.3 : 0)}");
            Console.WriteLine($"Вода\t{waterPay}\t0\t{waterPay}");
            Console.WriteLine($"Газ\t{gasPay}\t0\t{gasPay}");
            Console.WriteLine($"Ремонт\t{remontPay}\t0\t{remontPay}");
            Console.WriteLine($"Итого\t{totalPayment}");
        }
        static void Main(string[] args)
        {
            task1();
            Console.ReadKey();
        }
    }
}
