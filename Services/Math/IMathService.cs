using System;

namespace WindowsFormsApp1.Services.Math
{
    public interface IMathService
    {
        double Sum(params double[] numbers);
        double Average(params double[] numbers);
        double StdDev(params double[] numbers);
    }
}
