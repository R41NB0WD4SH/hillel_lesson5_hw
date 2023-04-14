
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

    // public static double[] GetIntegerRoots(int[] numbers)
    // {
    //     double[] finalRoots = new double[0];
    //
    //     for (int i = 0; i < numbers.Length; i++)
    //     {
    //         if (numbers[i].GetRoot() > 5 || (numbers[i].GetRoot() % 1 == 0))
    //         {
    //             Array.Resize(ref finalRoots, finalRoots.Length + 1);
    //             finalRoots[finalRoots.Length - 1] = (numbers[i].GetRoot());
    //         }
    //     }
    //
    //     return finalRoots;
    // }
    
}









