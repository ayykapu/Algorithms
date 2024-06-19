using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms
{
    public class cubicFunction
    {
        public static string[] SolveCubicEquation(double a, double b, double c, double d)
        {

            if(a == 0 || b == 0 || c == 0)
            {
                throw new Exception("Nieprawidłowe dane.");
            }
           
            double normalisedA = b / a;
            double normalisedB = c / a;
            double normalisedC = d / a;

            double Q = (3 * normalisedB - Math.Pow(normalisedA, 2)) / 9;
            double R = (9 * normalisedA * normalisedB - 27 * normalisedC - 2 * Math.Pow(normalisedA, 3)) / 54;
            double D = Math.Pow(Q, 3) + Math.Pow(R, 2); 

            string[] roots = new string[3];

            if (D >= 0)  
            {
                double S = Math.Cbrt(R + Math.Sqrt(D));
                double T = Math.Cbrt(R - Math.Sqrt(D));

                double realRoot1 = -normalisedA / 3 + (S + T);
                double realPart = -normalisedA / 3 - (S + T) / 2;
                double imaginaryPart = (S - T) * Math.Sqrt(3) / 2;

                roots[0] = Math.Round(realRoot1, 3).ToString();
                roots[1] = $"{Math.Round(realPart, 3)} + {Math.Round(imaginaryPart, 3)}i";
                roots[2] = $"{Math.Round(realPart, 3)} - {Math.Round(imaginaryPart, 3)}i";
            }
            else 
            {
                double realAlpha = Math.Acos(R / Math.Sqrt(-Math.Pow(Q, 3)));
                double realBeta = Math.Sqrt(-Q);

                double realRoot1 = 2 * realBeta * Math.Cos(realAlpha / 3) - normalisedA / 3;
                double realRoot2 = 2 * realBeta * Math.Cos((realAlpha + 2 * Math.PI) / 3) - normalisedA / 3;
                double realRoot3 = 2 * realBeta * Math.Cos((realAlpha + 4 * Math.PI) / 3) - normalisedA / 3;

                double[] unsortedRootArray = { realRoot1, realRoot2, realRoot3 };

                Array.Sort(unsortedRootArray);

                for (int i = 0; i < roots.Length; i++)
                {
                    roots[i] = Math.Round(unsortedRootArray[i], 3).ToString();
                }
            }

            return roots;
        }

    }
}
