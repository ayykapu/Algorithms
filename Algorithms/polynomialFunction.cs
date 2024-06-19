using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class polynomialFunction
    {
        public static string[] SolvePolynomialEquation(double a, double b, double c, double d, double e, double f, double minX, double maxX, double step, double epsilon)
        {
            if (a == 0 || b == 0 || c == 0 || d == 0 || e == 0 || (Math.Abs(minX - maxX) < step))
            {
                throw new Exception("Nieprawidłowe dane.");
            }

            List<string> resultList = new List<string>();

            for (double x = minX; x <= maxX + epsilon; x += step)
            {
                if (x > maxX - epsilon) 
                    x = maxX; 

                double wynik = a * Math.Pow(x, 5) + b * Math.Pow(x, 4) + c * Math.Pow(x, 3) + d * Math.Pow(x, 2) + e * x + f;
                string resultString = "f(" + x.ToString("0.00") + ") = " + wynik.ToString("0.00");
                resultList.Add(resultString); 
            }

            return resultList.ToArray();
        }

    }
}
