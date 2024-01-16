using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace FirstApp
{
    class StartClass
    {

        static void Main(string[] args)
        {

            string t;
            int m;

            t = Console.ReadLine();
            if (StrToMonth(t, out m))
                Console.WriteLine(m);
            else
                Console.WriteLine("Error");

        }


        public static bool StrToMonth(string text, out int month)

        {

            if (int.TryParse(text, out month))
            {

                return (month >= 1 && month <= 12);
            }

            else
                return false;
        }
    }
}
