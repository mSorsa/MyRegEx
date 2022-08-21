using LearnRegEx;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearningRegex.Tests;

[TestClass]
public class RegexMethodTests
{
    [TestMethod]
    [DataRow("abc020201", true)]
    [DataRow("abc020202", false)]
    [DataRow("0*)(&/1", false)]
    [DataRow("kljandfb01l.akmnsdfv", true)]
    public void CheckFor0FollowedBy1UsingRegex_Test(string input, bool expected)
    {
        bool actual = RegExMethods.CheckFor0FollowedBy1UsingRegex(input);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow("abc020201", false)]
    [DataRow(")(/asdb9876", true)]
    [DataRow("0*)(&/1", true)]
    [DataRow("kljandfb01l.akmnsdfv", false)]
    [DataRow("kl¤andfb01l.akmnsd(", true)]
    public void CheckFor3SymbolsUsingRegex_Test(string input, bool expected)
    {
        bool actual = RegExMethods.CheckFor3SymbolsUsingRegex(input);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow("abc020201", true)]
    [DataRow(")(/asdb9876", false)]
    [DataRow("0*)(&/1", true)]
    [DataRow("kljandfb0-1l.akmnsdfv", true)]
    [DataRow("0000111", false)]
    public void CheckIfOddNumberOf0sAnd1sTest(string input, bool expected)
    {
        bool actual = RegExMethods.CheckIfOddNumberOf0sAnd1s(input);
        Assert.AreEqual(expected, actual);
    }
}
