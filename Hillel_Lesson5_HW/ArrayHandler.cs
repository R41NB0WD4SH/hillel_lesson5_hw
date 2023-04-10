namespace Hillel_Lesson5_HW;

public class ArrayHandler
{

    private double[] _numbers = new double[5000];

    public event EventHandler<IntegerEventArgs> CatchIntegerNumber;


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

    public double[] SquareRoots(double[] numbers, FilterRoots filterRoots)
    {
        
        return filterRoots(numbers);

    }


    public void ShowIntegerNumbers()
    {
        for (int i = 0; i < _numbers.Length; i++)
        {
            if (_numbers[i] < 1 && _numbers[i] > 3)
            {
                IntegerEventArgs args = new IntegerEventArgs()
                {
                    Number = _numbers[i]
                };
                OnIntegerNumber(args);
            }
        }
    }

    protected virtual void OnIntegerNumber(IntegerEventArgs e)
    {
        CatchIntegerNumber.Invoke(this, e);
    }




}