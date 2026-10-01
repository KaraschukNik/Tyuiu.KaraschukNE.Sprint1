using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KaraschukNE.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            double term1 = x;
            double term2 = Math.Exp(x);
            double term3 = (Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / Math.Pow(3, x);
            double term4 = Math.Pow(y, 5) / Math.Pow(5, y);
            double z = term1 + term2 + term3 + term4;
            return Math.Round(z, 3);
        }
    }
}
