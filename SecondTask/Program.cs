using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строчку"); /// запрос на ввод
            string inputString = Console.ReadLine(); /// ввод строки пользователем
            char[] charArray = inputString.ToCharArray(); /// преобразование строки в массив для дальнейшей работы
            string sstring = SString(inputString);
            string symbols = StringLan(charArray);
            /// проверка на наличие в переменной symbols символов, если они есть, значит переменная содержит неподходящие символы. Если переменная symbols пустая - значит в веденной пользователем строки присутствуют только английские символы
            if (symbols.Length > 0)
            {
                Console.WriteLine("Введены не подходящие символы " + symbols);
            }
            else
            {
                Console.WriteLine(sstring);
            }
        }
        /// проверка на наличие английских символов, если какой-то элемент массива не содержит английский символ, то он записывается в переменную symbols
        public static string StringLan(params char[] charArray)
        {
            string symbols = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] >= 'a' && charArray[i] <= 'z'))
                {

                }
                else
                {
                    symbols += charArray[i];
                }
            }
            return symbols;

        }

        static string SString(string inputString)
        {
            if (inputString.Length % 2 == 0)
            {
                int split = inputString.Length / 2;
                /// разделение на 2 части
                string first = inputString.Substring(0, split);
                string second = inputString.Substring(split);
                /// переворачивание двух строк + соединение
                string first1 = new string(first.Reverse().ToArray());
                string second1 = new string(second.Reverse().ToArray());
                return first1 + second1;
            }
            /// переворачивание нечётную строку + присвоение к изначальной строки
            else
            {
                string Istring = new string(inputString.Reverse().ToArray());
                return Istring + inputString;
            }
        }
    }
}
