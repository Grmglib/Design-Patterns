namespace StrategyExampleB
{
    internal class Calculate
    {
        public ICalculator calculator { get; set; }

        public void CalculateOperation(double v1, double v2)
        {
            Console.WriteLine(calculator.Operation(v1, v2));
        }
    }
}