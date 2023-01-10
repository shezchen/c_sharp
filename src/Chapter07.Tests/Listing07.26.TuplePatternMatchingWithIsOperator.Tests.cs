using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_26.Tests;

static class TuplePatternMatchingTests
{
    static string DataFile = "./data.dat";
    const string EncryptedFileName = "./temp.out";
    
    public static async Task InvokeMainWithEncriptAction(Action<string[]> action)
    {
        File.Delete(DataFile);
        File.Delete(EncryptedFileName);
        
        const string data = "DATA";
        await File.WriteAllTextAsync(DataFile, data);
        string expected = $"ENCRYPTED <{data}> ENCRYPTED";


        action(new string[] { "encrypt", EncryptedFileName });

        string actual = await File.ReadAllTextAsync(EncryptedFileName);
        Assert.AreEqual<string>(expected, actual);
        File.Delete(DataFile);
        File.Delete(EncryptedFileName);
    }

    public static async Task InvokeMainWithShowFile(Action<string[]> action)
    {
        File.Delete(DataFile);

        const string data = "DATA";
        await File.WriteAllTextAsync(DataFile, data);

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            data,
            () => action(new string[] { "cat" }));

        File.Delete(DataFile);
    }
}

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task Main_EncryptFileUsingIsOperator_Success()
    {
        await TuplePatternMatchingTests.InvokeMainWithEncriptAction(
            Program.Main);
    }

    [TestMethod]
    public async Task Main_ShowFileWithIsOperator_Success()
    {
        await TuplePatternMatchingTests.InvokeMainWithShowFile(Program.Main);
    }
}
