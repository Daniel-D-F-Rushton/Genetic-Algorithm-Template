namespace Genetic_Algorithm_Template
{
    static public class GA_Ageing
    {
        static internal void Age(this GeneticAlgorithm GA)
        {
            foreach (Creature creature in GA.Population)
            {
                creature.Age++;
                if (creature.Age > GA.MaximumAge) creature.NumberOfErrors = 1000000000;
            }
        }
    }
}