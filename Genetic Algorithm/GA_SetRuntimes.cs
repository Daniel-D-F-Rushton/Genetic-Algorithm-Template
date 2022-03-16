namespace Genetic_Algorithm_Template
{
    static public class GA_SetRuntimes
    {
        static public void Set_PopulationSize(this GeneticAlgorithm GA, int populationSize) => GA.PopulationSize = populationSize < 4 ? 4 : populationSize;
        static public void Set_MutationOdds(this GeneticAlgorithm GA, int odds) => GA.MutationOdds = odds;
        static public void Set_AlwaysMutate(this GeneticAlgorithm GA, bool alwaysMutate) => GA.AlwaysMutate = alwaysMutate;
        static public void Set_MaximumAge(this GeneticAlgorithm GA, int age) => GA.MaximumAge = age < 1 ? 1 : age;

        static public void Set_Problem(this GeneticAlgorithm GA, IProblem problem)
        {
            GA.Problem = problem;
            GA.GeneticsSize = problem.GeneSize;
        }
    }
}