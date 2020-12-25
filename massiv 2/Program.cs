using System;

namespace massiv_2
{
    class Program
    {
        //Незнаю почему не выводит конечный ответ
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int[,] myArray = new int[10, 10];
                Random random = new Random();
                for (int i = 0; i < myArray.GetLength(0); i++)
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        myArray[i, j] = random.Next(100);
                for (int y = 0; y < myArray.GetLength(0); y++)
                {
                    for (int x = 0; x < myArray.GetLength(1); x++)
                        Console.Write(myArray[y, x] + "\t");
                    Console.WriteLine();
                }
                Console.WriteLine("Введите номер строки для расчета суммы элементов: ");
                int N = Int32.Parse(Console.ReadLine()) - 1;
                int sum = 0;
                for (int i = 0; i < myArray.GetLength(1); i++)
                    sum += myArray[N, i];
                Console.WriteLine("Сумма элементов= " + sum);
                //сумма элементов каждой строки
                for (int y = 0; y < myArray.GetLength(0); y++)
                    
                {
                    sum = 0;
                    for (int x = 0; x < myArray.GetLength(1); x++)
                        sum += myArray[y, x];
                    Console.WriteLine("Сумма элементов в " + (y + 1) + " ряде = " + sum);
                    
                }
                Console.WriteLine();
            }
        }
    }
}
