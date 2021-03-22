using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab_2_3a
{
    class Program
    {
        static void Main()
        {
          
            
            int result = 1;
            int i = 0;
            int[] arr = new int[5];             // створюєм масив 

            Console.WriteLine("Задайте елементи масиву : ");
            for (i = 0; i < arr.Length; i++)            // масив задається з клавіатури 
            {
                Console.Write("Елемент[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());// 
            }




            for (i = 0; i < arr.Length; i++)
                if (arr[i] < 0)             //умова щоб елементи масиву були від'ємні
                    result *= arr[i];// рахуєм добуток вiд'ємних елементiв масиву
            Console.WriteLine("Результат добутку вiд'ємних елементiв масиву \n" + result + "\n");//виводиться результат


            Console.WriteLine();


            int min = arr[0];//создали змінну для мінімалього елементу масиву 

            for (i = 0; i < arr.Length; i++)
              min = Math.Min(min, arr[i]);      //знаходится мінімальний елемент масиву 
                    Console.WriteLine(min);     // виводится на екран мінімальни елемент масиву для перевірки

        }// ДАЛІ Я НЕ ЗНАЮ ЯК ШУКАВ В ІНТЕРНЕТІ І В АНГЛІЙСКИХ РЕСУРСАЗ НІЧОГО ЗРОЗУМІЛОГО НЕ ЗНАЙШОВ
 
    }
}