using System;

namespace Genetic_Algorithm_Template
{
    static public class GA_StartStop
    {
        static public void Start(this GeneticAlgorithm GA)
        {
            if (GA.GeneticsSize == 0)
            {
                Console.WriteLine("You need to set the IProblem before you can run");
                return;
            }
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