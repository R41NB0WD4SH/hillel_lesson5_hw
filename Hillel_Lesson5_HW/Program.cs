using System;


namespace Hillel_Lesson5_HW
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            
            Random rnd = new Random();
            Random rndDouble = new Random();

            ArrayHandler newArray = new ArrayHandler();

            double[] numbers = new double [10];

            for (int i = 0; i < newArray.Numbers.Length; i++)
            {
                double number = rndDouble.NextDouble();
                int multiplier = rnd.Next(0, 1000);
                
                newArray.Numbers[i] = number * multiplier;
            }


            // for (int i = 0; i < newArray.Numbers.Length; i++)
            // {
            //     Console.WriteLine(newArray.Numbers[i]);
            // }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            FilterRoots filterRoots = new FilterRoots(SquareRootsCalculator.GetFilteredNumbers);
            
            
            
            ArrayHandler finalArray = new ArrayHandler();

            finalArray.Numbers = finalArray.SquareRoots(newArray.Numbers, filterRoots);


            // for (int i = 0; i < finalArray.Numbers.Length; i++)
            // {
            //     Console.WriteLine(finalArray.Numbers[i]);
            // }
            
            finalArray.CatchIntegerNumber += On_CatchInteger;
            
            finalArray.ShowIntegerNumbers();
            
            Console.ReadKey();

        }


        public static void On_CatchInteger(object sender, IntegerEventArgs e)
        {
            Console.WriteLine(e.Number);
        }
        
        

    }
}