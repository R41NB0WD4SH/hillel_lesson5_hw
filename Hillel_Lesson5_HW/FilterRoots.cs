namespace Hillel_Lesson5_HW;

public delegate double[] FilterRoots(double[] numbers);

public delegate TResult Func<in T,out TResult>(T arg);