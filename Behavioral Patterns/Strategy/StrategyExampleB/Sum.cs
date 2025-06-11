namespace StrategyExampleB
{
    class Sum : ICalculator
    {
        public double Operation(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
