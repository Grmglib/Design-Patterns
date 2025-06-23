namespace StrategyExampleB
{
    internal class Subtract : ICalculator
    {
        public double Operation(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}