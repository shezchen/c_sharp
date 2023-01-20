using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_31.Tests;

[TestClass]
public class ProgramTests
{

    [TestMethod]
    public void RecursivePatternMatchingTest()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            "(5, Princess)", () => Program.Main());
    }
}