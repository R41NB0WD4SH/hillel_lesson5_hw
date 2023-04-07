using System;


namespace Hillel_Lesson5_HW
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            
            Random rnd = new Random();

            ArrayHandler newArray = new ArrayHandler();

            int[] numbers = new int [10];

            for (int i = 0; i < newArray.Numbers.Length; i++)
            {
                int nextNumber = rnd.Next(0, 1000);
                newArray.Numbers[i] = nextNumber;
            }


            for (int i = 0; i < newArray.Numbers.Length; i++)
            {
                Console.WriteLine(newArray.Numbers[i]);
            }

            Console.ReadKey();

        }
    }
}