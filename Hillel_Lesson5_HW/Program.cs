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
                
                newArray.Numbers[i] = multiplier;
            }


            for (int i = 0; i < newArray.Numbers.Length; i++)
            {
                Console.WriteLine(newArray.Numbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // FilterRoots filterRoots = new FilterRoots(SquareRootsCalculator.GetIntegerRoots);
            
            
            // newArray.GetFilteredRoots(filterRoots);


            // FilterRoots filterRoots = new FilterRoots();

            newArray.IntegerNumber += On_IntegerNumber;
            
            newArray.ShowIntegerRoots();
            
            Console.ReadKey();

        }
        
        
        public static void On_IntegerNumber(object sender, IntegerNumberEvent e)
        {
            Console.WriteLine("{0} - Integer Root", e.Number);
        }
        
        
        

    }
}