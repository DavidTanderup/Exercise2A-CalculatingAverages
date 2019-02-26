using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_2A___Calculating_Averages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A___Calculating_Averages.Tests
{
    [TestClass()]
    public class ILoveMathTests
    {
        ILoveMath math = new ILoveMath();
        [TestMethod()]
        public void LetterGradeTest()
        {
            Assert.AreEqual("D",math.LetterGrade(60));
        }
    }
}