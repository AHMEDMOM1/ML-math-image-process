using System;
using System.Linq;

namespace WindowsFormsApp1.Services.Math
{
    public class MathService : IMathService
    {
        public double Sum(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Sum();
        }

        public double Average(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Average();
        }

        // Standard Deviation (Population)
        public double StdDev(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            double avg = numbers.Average();
            double variance = numbers.Select(x => (x - avg) * (x - avg)).Average();
            return System.Math.Sqrt(variance);
        }
    }
}
