
namespace Hillel_Lesson5_HW;

public static class SquareRootsCalculator
{

    public static double GetRoot(this double number)
    {
        return Math.Sqrt(number);
    }

    public static double[] GetFilteredNumbers(double[] numbers)
    {
        double[] finalRoots = new double[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].GetRoot() > 5 || (numbers[i].GetRoot() % 2 == 0))
            {
                Array.Resize(ref finalRoots, finalRoots.Length + 1);
                finalRoots[finalRoots.Length - 1] = (numbers[i].GetRoot());
            }
        }

        return finalRoots;
    }
    
}