﻿namespace StrategyExampleA
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    internal class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}