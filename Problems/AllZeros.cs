namespace Genetic_Algorithm_Template
{
    public class AllZeros : IProblem
    {
        public int GeneSize { get; set; } = 10000;
        public int CalculateErrors(string geneString)
        {
            int ErrorCount = 0;
            foreach (char gene in geneString)
            {
                ErrorCount += gene == '1' ? 1 : 0;
            }
            return ErrorCount;
        }
    }
}