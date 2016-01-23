using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            WordAnalyzer wordAnlyzer = new WordAnalyzer();
            string readText = wordAnlyzer.loadFile();
        }
    }
}
