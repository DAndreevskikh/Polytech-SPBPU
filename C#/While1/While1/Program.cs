using System;
namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
         // Первый случай
        double volume1 = 750, speedM1 = 185, speedB1 = 30, time1 = 0;
           while (volume1 > 0)
        {
            volume1 -= (speedM1 - speedB1) * (20.0 / 60);
            speedM1 *= 0.99;  // Уменьшение на 1%
            speedB1 *= 1.02;  // Увеличение на 2%
            time1 += 20.0 / 60;
         }
           int hourReached1 = (int)Math.Round(time1);
           Console.WriteLine("Время, когда моряк доберется до пробоины в первом случае: " + hourReached1 + " часов");

            // Второй случай
           double volume2 = 2000, speedM2 = 273, speedB2 = 41, time2 = 0;
           while (volume2 > 0)
        {
            volume2 -= (speedM2 - speedB2) * (20.0 / 60);
            speedM2 *= 0.98;  // Уменьшение на 2%
            speedB2 *= 0.99;  // Уменьшение на 1%
            time2 += 20.0 / 60;
        }
           int hourReached2 = (int)Math.Round(time2);
           Console.WriteLine("Время, когда моряк доберется до пробоины во втором случае: " + hourReached2 + " часов");
     }
   }
  }