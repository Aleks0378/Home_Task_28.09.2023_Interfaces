using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//Створіть інтерфейс IOutput2. У ньому мають бути два методи:
//■ void ShowEven() — відображає парні значення контейнера з даними;
//■ void ShowOdd() — відображає непарні значення контейнера з даними.
//Клас, створений раніше у практичному завданні Array,
//має імплементувати інтерфейс IOutput2. 
//Метод ShowEven — відображає парні значення з масиву.
//Метод ShowOdd — відображає непарні значення масиву.
//Напишіть код для тестування отриманої функціональності
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 20;
            MyArray array = new MyArray(size);
            for (int i = 0; i < array.integ.Length; i++)
            {
                array.integ[i] = (rand.Next(0, 20));
            }

            array.Show("All numbers of the array:");
            Console.WriteLine("\n\n");
            int number = 10;
            Console.WriteLine($"Quantity of numbers less than {number}: {array.Less(number)}");
            Console.WriteLine($"Quantity of numbers greater than {number}: {array.Greater(number)}");
            Console.WriteLine("\n\n");
            Console.WriteLine("All Even numbers of the array:");
            array.ShowEven();
            Console.WriteLine("\n");
            Console.WriteLine("All Odd numbers of the array:");
            array.ShowOdd();
            Console.WriteLine("\n");
        }
    }
}
