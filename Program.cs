using System;
using System.Collections.Generic;
using System.Linq;
//Кабанов Степан. 109 группа. Задание номер 6 на тему "LINQ"
namespace Linqt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(42);
            int size = 100;
            //Генерация случайной последовательности
            IEnumerable<int> numbers = Enumerable.Range(0, size);
            IEnumerable<int> indx = Enumerable.Range(0, size);
            var nn = from num in numbers select rand.Next(0,size);
            //Отбор нужных элементов
            var nn_list = nn.ToList();
            var res = from num in indx where num % 3 != 0 select nn_list[num];
            //Генерация новых индексов
            var nsize = res.Count();
            var rindx = Enumerable.Range(0, nsize);
            //Вычисление ответа
            int ind = 0;
            foreach(int num in res)
            {
                int a = num;
                if (ind % 2 == 0)
                    a *= 2;
                Console.WriteLine(a);
                ind++;
            }
        }
    }
}
