using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm_Template
{
    public class EventPass : EventArgs
    {
        public int Generation;
        public string Genes;
        public int Errors;
        public EventPass(int generation, string genes, int errors)
        {
            Generation = generation;
            Genes = genes;
            Errors = errors;
        }
    }
}
