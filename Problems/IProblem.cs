namespace Genetic_Algorithm_Template
{
    public interface IProblem
    {
        public int GeneSize { get; set; }
        public int CalculateErrors(string geneString);
    }
}