namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool doLoop = true;

            do
            {
                Console.WriteLine("[1] Funkcja sześcienna\n[2] Funkcja wielomianowa\n[E] Wyjdź");
                string input = "";
                input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "1":
                        CubicStart();
                        break;

                    case "2":
                        PolynomialStart();
                        break;

                    case "E":
                        doLoop = false;
                        break;

                    default:
                        //polecenie nie istnieje
                        break;
                }
                Console.Clear();
            } while (doLoop);
        }

        public static void CubicStart()
        {
            Console.Clear();
            bool doLoop = true;

            do
            {
                Console.WriteLine("[1] Wprowadz dane\n[B] Wróć");
                string input = "";
                input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "1":

                        double a, b, c, d;
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("f(x) = ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^3 + ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^3 + ({b})x^2 + ");
                            c = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^3 + ({b})x^2 + ({c})x + ");
                            d = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^3 + ({b})x^2 + ({c})x + ({d})");

                            var result = cubicFunction.SolveCubicEquation(a, b, c, d);

                            Console.Write("\n");
                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.WriteLine("x" + (i + 1) + ": " + result[i]);
                            }

                            Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("FormatException");
                            Console.ReadLine();
                        }

                        break;

                    case "B":
                        doLoop = false;
                        break;

                    default:
                        //polecenie nie istnieje
                        break;
                }
                Console.Clear();
            } while (doLoop);
        }

        public static void PolynomialStart()
        {
            Console.Clear ();
            bool doLoop = true;

            do
            {
                Console.WriteLine("[1] Wprowadz dane\n[B] Wróć");
                string input = "";
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        double a, b, c, d, e, f;
                        double minX, maxX, step;
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("f(x) = ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^5 + ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^5 + ({b})x^4 + ");
                            c = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^5 + ({b})x^4 + ({c})x^3 + ");
                            d = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^5 + ({b})x^4 + ({c})x^3 + ({d})x^2 + ");
                            e = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^5 + ({b})x^4 + ({c})x^3 + ({d})x^2 + ({e})x ");
                            f = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"f(x) = ({a})x^5 + ({b})x^4 + ({c})x^3 + ({d})x^2 + ({e})x + ({f})");
                            Console.WriteLine("Podaj dolny punkt badanego przedziału: ");
                            minX = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Podaj górny punkt badanego przedziału: ");
                            maxX = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Podaj step: ");
                            step = Convert.ToDouble(Console.ReadLine());
                            

                            var result = polynomialFunction.SolvePolynomialEquation(a, b, c, d, e, f, minX, maxX, step, epsilon: 0.01);

                            Console.Write("\n");
                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.WriteLine($"{(i + 1)}) {result[i]}");
                            }

                            Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("FormatException");
                            Console.ReadLine();
                        }

                        break;
                    case "B":
                        doLoop = false;
                        break;

                    default:
                        //polecenie nie istnieje
                        break;
                }
            } while (doLoop);
        }
    }
}
