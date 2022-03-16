using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Genetic_Algorithm_Template
{
    static public class GA_Compete
    {
        static internal void Compete(this GeneticAlgorithm GA)
        {
            Random randomCreature = new();
            while (GA.Population.Count > GA.PopulationSize / 2)
            {
                int mother = randomCreature.Next(GA.Population.Count);
                int father = randomCreature.Next(GA.Population.Count); 
                while (mother == father)
                {
                    father = randomCreature.Next(GA.Population.Count);
                }                
                GA.Population.RemoveAt(GA.Population[mother].NumberOfErrors > GA.Population[father].NumberOfErrors ? mother : father);
            }
        }
    }
}