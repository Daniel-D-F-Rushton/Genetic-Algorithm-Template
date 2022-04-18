using System;

namespace Genetic_Algorithm_Template
{
    static public class GA_Mate
    {
        static internal void Mate(this GeneticAlgorithm GA)
        {
            Random randomCreature = new();

            int NumberOfValidCreatures = GA.Population.Count;
            while (GA.Population.Count < GA.PopulationSize)
            {
                int mother = randomCreature.Next(NumberOfValidCreatures);
                int father = randomCreature.Next(NumberOfValidCreatures);
                while (mother == father)
                {
                    father = randomCreature.Next(NumberOfValidCreatures);
                }
                string child = GA_Mate_Helper.MateGenes(GA.Population[mother].GeneticsString, GA.Population[father].GeneticsString);
                child = GA_Mate_Helper.MutateGenes(child, GA.AlwaysMutate, GA.MutationOdds);
                int childErrors = GA.Problem.CalculateErrors(ref child);
                GA.Population.Add(new Creature(child, childErrors));
                if (childErrors < GA.CurrentBest)
                {
                    GA.Call_EImprovementFound(child, childErrors);
                    GA.CurrentBest = childErrors;
                    if (childErrors == 0)
                    {
                        GA.Call_EAlgorithmSuccessful(child);
                        GA.Stopped = true;
                    }
                }
            }
        }

    }
}