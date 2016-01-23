using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordAnalysis;

namespace TestWordAnalsis
{
    [TestClass]
    public class WorldAnalysisTest
    {
        [TestMethod]
        public void TestExcercize1()
        { 
            WordAnalyzer wordAnlyzer = new WordAnalyzer();
            string readText = wordAnlyzer.loadFile();
            string entry = wordAnlyzer.getEntry("Ruben Walson");
            string byEmail = wordAnlyzer.getEntry("Elvis@Cote.com");
        }
    }
}
