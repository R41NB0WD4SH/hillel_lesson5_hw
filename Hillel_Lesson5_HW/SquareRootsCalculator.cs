
namespace Hillel_Lesson5_HW;

public static class SquareRootsCalculator
{

    public static double GetRoot(this int number)
    {
        return Math.Sqrt(number);
    }

    public static double[] GetIntegerRoots(int[] numbers)
    {
        double[] finalRoots = new double[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].GetRoot() > 5 || (numbers[i].GetRoot() % 1 == 0))
            {
                Array.Resize(ref finalRoots, finalRoots.Length + 1);
                finalRoots[finalRoots.Length - 1] = (numbers[i].GetRoot());
            }
        }

        return finalRoots;
    }
    
}









