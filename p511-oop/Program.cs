using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
  
    internal class Program
    {
        static bool IsPalindrome(string str) {
            // Приводим строку к нижнему регистру и удаляем пробелы  
            str = str.ToLower().Replace(" ", "");

            // Используем два указателя для сравнения символов  
            int left = 0;
            int right = str.Length - 1;

            while (left < right) {
                if (str[left] != str[right]) {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }  

        static void Main(string[] args)
        {
            // Запрос ввода строки у пользователя 
            Console.Write("Введите строку для проверки: ");
            string input = Console.ReadLine();
            // Проверка на палиндром 
            if (IsPalindrome(input)) {
                Console.WriteLine("Введённая строка является палиндромом!");
            } else {
                Console.WriteLine("Введённая строка не является палиндромом.");
            }

            Console.ReadKey();



        }
    }
}
