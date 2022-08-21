using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExMethods.Tests
{
    [TestClass()]
    public class RegExIntAndFloatMethodsTests
    {
        [TestMethod]
        [DataRow("100", true)]
        [DataRow("-100", false)]
        [DataRow("1001", true)]
        [DataRow("100.5", true)]
        [DataRow("-100.5", false)]
        [DataRow("-200", false)]
        [DataRow("200", true)]
        [DataRow("10a0.5", false)]
        [DataRow("-10a0.5", false)]
        [DataRow("10a0*.5", false)]
        [DataRow("-10a0*.5", false)]
        [DataRow("&/(c22", false)]
        public void CheckPositiveIntUsingRegEx_Test(string input, bool expected)
        {
            var regIntAndFloats = new RegExIntAndFloatMethods();
            
            bool actual = regIntAndFloats.CheckPositiveIntUsingRegEx(input);
            Assert.AreEqual(expected, actual);
        }
    }
}