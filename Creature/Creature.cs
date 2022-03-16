namespace Genetic_Algorithm_Template
{
    internal class Creature
    {
        internal string GeneticsString;
        internal int Age;
        internal int NumberOfErrors;

        internal Creature(string geneticsString, int numberOfErrors)
        {
            Age = 0;
            GeneticsString = geneticsString;
            NumberOfErrors = numberOfErrors;
        }
    }
}