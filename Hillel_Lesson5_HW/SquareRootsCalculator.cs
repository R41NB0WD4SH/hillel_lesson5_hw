
namespace Hillel_Lesson5_HW;

public static class SquareRootsCalculator
{

    public static double[] GetRoots(this int[] number, FilterRoots filterRoots)
    {

        double[] roots = new double[number.Length];

        for (int i = 0; i < roots.Length; i++)
        {
            roots[i] = Math.Sqrt(number[i]);
        }

        double[] filteredRoots = new double[0];

        filterRoots += SelectIntegersAndDivBy5Roots;

        return filterRoots(roots);

    }

    public static double[] SelectIntegersAndDivBy5Roots(double[] roots)
    { 
        double[] filteredRoots = new double[0];
        
        for (int i = 0; i < roots.Length; i++)
        {
            if (roots[i] > 5 || roots[i] % 1 == 0)
            {
                Array.Resize(ref filteredRoots, filteredRoots.Length + 1);
                filteredRoots[filteredRoots.Length - 1] = roots[i];
            }
        }

        return filteredRoots;

    }

    static Func<int, bool> numbersFilter = a => a > 5;

    public static void GetNumbers(Func<int, bool> filter)
    {
        for (int i = 0; i < 100; i++)
            if (filter(i))
                Console.WriteLine(i);
    }

    
    
}









