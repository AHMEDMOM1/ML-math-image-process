using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Models.ML;

namespace WindowsFormsApp1.Services.ML
{
    public class KnnClassifier : IClassifier
    {
        private IList<Models.ML.DataPoint> _data = new List<Models.ML.DataPoint>();

        public void SetTrainingData(IList<Models.ML.DataPoint> data)
        {
            _data = data ?? new List<Models.ML.DataPoint>();
        }

        public string Predict(double f1, double f2, int k = 3)
        {
            if (_data == null || _data.Count == 0)
                return "No training data";

            if (k <= 0) k = 3;
            if (k > _data.Count) k = _data.Count;

            
            var neighbors = _data
                .Select(p => new
                {
                    Point = p,
                    Distance = System.Math.Sqrt(
                        (p.Feature1 - f1) * (p.Feature1 - f1) +
                        (p.Feature2 - f2) * (p.Feature2 - f2))
                })
                .OrderBy(x => x.Distance)
                .Take(k)
                .ToList();

            
            var majority = neighbors
                .GroupBy(x => x.Point.Label)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;

            return majority;
        }
    }
}
