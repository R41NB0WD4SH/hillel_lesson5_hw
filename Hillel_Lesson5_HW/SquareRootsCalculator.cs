
using System.Runtime.CompilerServices;

namespace Hillel_Lesson5_HW;

public static class SquareRootsCalculator
{

    public static List<double> GetRoots(int[] number, Func<int, bool> numberFilter)
    {

        List<double> roots = new List<double>(number.Length);

        for (int i = 0; i < number.Length; i++)
        {
            if (numberFilter(number[i]))
            {
                roots.Add(Math.Sqrt(number[i]));
            }
        }

        return roots;
    }
    
    public static Func<int, bool> numbersFilter = a => Math.Sqrt(a) > 5;
    
    public static void GetNumbers(Func<int, bool> filter)
    {
        for (int i = 0; i < 100; i++)
            if (filter(i))
                Console.WriteLine(i);
    }
    
    
}









