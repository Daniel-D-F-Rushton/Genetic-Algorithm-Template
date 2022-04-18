using System;

namespace Genetic_Algorithm_Template
{
    static public class GA_StartStop
    {
        static public void Start(this GeneticAlgorithm GA)
        {
            GA.Stopped = false;
            GA.CreateRandomPopulation();
            GA.Generation();
        }

        static public void Stop(this GeneticAlgorithm GA)
        {
            GA.Stopped = true;
        }
    }
}