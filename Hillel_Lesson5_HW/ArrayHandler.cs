namespace Hillel_Lesson5_HW;

public class ArrayHandler
{

    private double[] _numbers = new double[500];
    private int[] _selectedRoots = new int[1];
    
    
    public double[] Numbers
    {
        get
        {
            return _numbers;
        }
        set
        {
            _numbers = value;
        }

    }

    public int[] SelectedRoots
    {
        get
        {
            return _selectedRoots;
        }
        set
        {
            _selectedRoots = value;
        }
    }




    public double[] SquareRoots(double[] numbers, FilterRoots filterRoots)
    {
        return filterRoots(numbers);


    }





}