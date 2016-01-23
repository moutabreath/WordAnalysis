using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordAnalysis.DataStructures;

namespace WordAnalysis
{
    public class WordAnalyzer
    {
        Dictionary<string, string> storage = new Dictionary<string, string>();
        TreeWord namesTreeWord = new TreeWord();
        TreeWord emailTreeWord = new TreeWord();
        
        public string loadFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\SearchInFile.csv";
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            char[] delimiterChars = { '\n' };
            

            string[] lines = readText.Split(delimiterChars);
            // Iterate over a line
            foreach (var word in lines)
            {
                char[] wordDelimeter = { ',' };
                string[] lineValues = word.Split(wordDelimeter);
                if ((lineValues != null) &&(lineValues.Count() == 3))
                {
                    namesTreeWord.Add(lineValues[0], lineValues[1].Substring(1));
                    string trimmedEmail = lineValues[2].Substring(1, lineValues[2].Count() - 2);
                    emailTreeWord.Add(lineValues[0], trimmedEmail);
                }
            }
            return readText;
        }

        public string getEntry(string key)
        {
            if (key.Contains("@"))
            {
                return emailTreeWord.search(key);
            }
            else
            {
                return namesTreeWord.search(key);
            }
        }
    }
}
