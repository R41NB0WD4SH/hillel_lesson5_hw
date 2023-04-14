namespace Hillel_Lesson5_HW;

public class ArrayHandler
{

    private int[] _numbers = new int[20];
    private double[] _filteredRoots;

    public event EventHandler<IntegerNumberEvent> IntegerNumber; 


    public int[] Numbers
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

    public double[] FilteredRoots
    {
        get
        {
            return _filteredRoots;
        }
        set
        {
            _filteredRoots = value;
        }
    }


    // public void GetFilteredRoots(FilterRoots filterRoots)
    // {
    //     FilteredRoots = filterRoots(Numbers);
    // }


    public void ShowIntegerRoots()
    {
        for (int i = 0; i < FilteredRoots.Length; i++)
        {
            if (FilteredRoots[i] == 0)
            {
                IntegerNumberEvent numbers = new IntegerNumberEvent()
                {
                    Number = FilteredRoots[i]
                };
            }
            else
            {
                if (FilteredRoots[i] % 1 == 0)
                {
                    IntegerNumberEvent numbers = new IntegerNumberEvent()
                    {
                        Number = FilteredRoots[i]
                    };
                    OnIntegerNumber(numbers);
                }
            }

        }
    }
    
    
    protected virtual void OnIntegerNumber(IntegerNumberEvent e)
    {
        IntegerNumber?.Invoke(this, e);
    }





}