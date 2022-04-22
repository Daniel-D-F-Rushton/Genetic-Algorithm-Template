using System;
using System.Collections.Generic;

namespace Genetic_Algorithm_Template
{
    public class GeneticAlgorithm
    {
        internal int PopulationSize = 16;
        internal List<Creature> Population = new();
        internal int MutationOdds;
        internal bool AlwaysMutate = true;
        internal int CurrentGeneration = 0;
        internal int MaximumAge = 10;
        internal int CurrentBest = 100000000;
        internal bool Stopped = true;

        // IProblem things here
        internal int GeneticsSize = 0;
        internal IProblem Problem;

        /// <summary> This is called at the end of each generation </summary>
        public event EventHandler<EventPass> E_GenerationComplete;
        internal void Call_EGenerationComplete()
        {
            EventPass eventPass = new EventPass(CurrentGeneration, "", -1);
            E_GenerationComplete?.Invoke(this, eventPass);
        }

        /// <summary> This is called in the problem is improved upon </summary>
        public event EventHandler<EventPass> E_ImprovementFound;
        internal void Call_EImprovementFound(string child, int childErrors)
        {
            EventPass eventPass = new EventPass(CurrentGeneration, child, childErrors);
            E_ImprovementFound?.Invoke(this, eventPass);
        }

        /// <summary> This is called if the problem finds a zero error solultion </summary>
        public event EventHandler<EventPass> E_AlgorithmSuccessful;
        internal void Call_EAlgorithmSuccessful(string solution)
        {
            EventPass eventPass = new EventPass(CurrentGeneration, solution, 0);
            E_AlgorithmSuccessful?.Invoke(this, eventPass);
        }
    }
}