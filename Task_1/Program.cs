using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1
//Створіть інтерфейс ICalc. У ньому мають бути два 
//методи:
//■ int Less(int valueToCompare) — повертає кількість 
//менших значень, ніж valueToCompare;
//■ int Greater(intvalueToCompare) — повертає кількість 
//більших значень, ніж valueToCompare.
//Клас, створений раніше у практичному завданні Array,
//має імплементувати інтерфейс ICalc. 
//Метод Less — повертає кількість елементів масиву 
//менших, ніж valueToCompare.
//Метод Greater — повертає кількість елементів масиву 
//більших, ніж valueToCompare.
//Напишіть код для тестування отриманої функціональності.
namespace Task_1
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
        }
    }
}
