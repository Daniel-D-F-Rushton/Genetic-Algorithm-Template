using System;
using System.Collections.Generic;
using System.Text;

namespace Genetic_Algorithm_Template
{
    static internal class GA_Generation
    {
        static internal void Generation(this GeneticAlgorithm GA)
        {
            while (GA.Stopped == false)
            {
                GA.Mate();
                GA.Compete();
                GA.Age();
                GA.CurrentGeneration++;
                GA.Call_EGenerationComplete();
            }          
        }
    }
}