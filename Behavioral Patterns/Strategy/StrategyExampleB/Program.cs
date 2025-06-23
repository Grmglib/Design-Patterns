namespace StrategyExampleB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            while (true)
            {
                Console.WriteLine("First Value: ");
                double v1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second Value: ");
                double v2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1 - Sum");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Division");
                Console.WriteLine("4 - Multiplication");
                string option = Console.ReadLine() ?? "";
                if (option == "1")
                {
                    calculate.calculator = new Sum();
                    calculate.CalculateOperation(v1, v2);
                }
                if (option == "2")
                {
                    try
                    {
                        calculate.calculator = new Subtract();
                        calculate.CalculateOperation(v1, v2);
                    }
                    catch
                    {
                        Console.WriteLine("A error occurred");
                    }
                }
                if (option == "3")
                {
                    try
                    {
                        calculate.calculator = new Division();
                        calculate.CalculateOperation(v1, v2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A error occurred : " + ex.InnerException);
                    }
                }
                if (option == "4")
                {
                    calculate.calculator = new Multiplication();
                    calculate.CalculateOperation(v1, v2);
                }
            }
        }
    }
}