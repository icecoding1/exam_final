using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_final
{
    internal class Two
    {
        public void show_max(string[] stringNumbers) {

            //string[] stringNumbers = input.Split(',');
            int[] numbers = new int[stringNumbers.Length];//บอกจำนวนขนาด array

           // เเปลง array string เป็น array int
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                int number;
                if (int.TryParse(stringNumbers[i], out number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input: " + stringNumbers[i]);

                }
            }
            

            //หาค่ามากที่สุด
            int largestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }
            }

            Console.WriteLine("The largest number is: " + largestNumber);

        }
    }
}
