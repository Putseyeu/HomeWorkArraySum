using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArrayRowColumn
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[,] array = new int[2, 4] { { 10, 3, 5, 7 }, { 2, 4, 6, 8 } };
            int sumSecondLine = 0;
            int multiplicationСolumn = 1;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sumSecondLine += array[1, i];
            }

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Cумма второй строки массива равна: " + sumSecondLine);            

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplicationСolumn *= array[i, 0];
            }
            
            Console.WriteLine("Произведение первого столбца равно: " + multiplicationСolumn);
        }
    }
}
