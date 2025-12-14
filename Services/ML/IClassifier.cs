using System.Collections.Generic;
using WindowsFormsApp1.Models.ML;

namespace WindowsFormsApp1.Services.ML
{
    public interface IClassifier
    {
        void SetTrainingData(IList<Models.ML.DataPoint> data);
        string Predict(double f1, double f2, int k = 3);
    }
}
