using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строковый_калькулятор
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Ввод: ");
            var str = Console.ReadLine().Trim();
            Test(str, '+');
            Test(str, '-');
            Test(str, '*');
            Test(str, '/');
            if (ind == 0 || k != 1) Stop();
            char zn = str[ind];
            var str1 = str.Remove(ind).Trim();
            var str2 = str.Substring(ind + 1).Trim();
            int act = 0;
            int number = 0;
            
            if (str1.IndexOf('"') == 0 && str1.LastIndexOf('"') == str1.Length - 1 && str1.IndexOf('"') != str1.LastIndexOf('"'))
            {
                str1 = str1.Remove(str1.Length - 1).Substring(1);
                if (str1.IndexOf('"') != -1) Stop();
            }
            else Stop();
            try
            {
                number = int.Parse(str2);
                act = 1;
            }
            catch
            {
                if (str2.IndexOf('"') == 0 && str2.LastIndexOf('"') == str2.Length - 1 && str2.IndexOf('"') != str2.LastIndexOf('"'))
                {
                    str2 = str2.Remove(str2.Length - 1).Substring(1);
                    act = 2;
                    if (str2.IndexOf('"') != -1) Stop();
                }
                else Stop();
            }
            if (str1.Length > 10) Stop();
            if (str2.Length > 10) Stop();
            if (number > 10) Stop() ;
            string output = "";
            if (zn == '+' && act == 1) Stop();
            if (zn == '-' && act == 1) Stop();
            if (zn == '*' && act == 2) Stop();
            if (zn == '/' && act == 2) Stop();
            if (zn == '+') output = string.Concat(str1, str2);
            if (zn == '-') output = str1.Replace(str2, "");
            if (zn == '*')
            {
                for (int i = 0; i < number; i++) output += str1;
            }
            if(zn == '/')
            {
                for (int i = 0; i < (str1.Length / number); i++) output += str1[i];
            }
            if(output.Length>40) Console.WriteLine($"Вывод: {output.Remove(40)}...");
            else Console.WriteLine($"Вывод: {output}");
        }

        static void Stop()
        {
            Console.WriteLine("\n" + new Exception("Ошибка"));
            while (true)
            {
                
            }
        }
          public static int k = 0;
          public static int ind = 0;
        public static void Test(string str, char c)
        {
            if (str.IndexOf(c) == str.LastIndexOf(c) && str.IndexOf(c) != -1)
            {
                ind = str.IndexOf(c);
                k++;
            }
        }
    }
}
