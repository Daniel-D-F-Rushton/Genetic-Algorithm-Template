using System;
using System.Collections.Generic;
using System.Text;

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
    }
}