namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_01;

public class LineCount
{
    #region INCLUDE
    public static void Main()
    {
        int lineCount;
        string files;

        DisplayHelpText();
        files = GetFiles();
        lineCount = CountLines(files);
        DisplayLineCount(lineCount);
    }
    #endregion INCLUDE
    private static void DisplayLineCount(int lineCount)
    {
        throw new NotImplementedException();
    }

    private static int CountLines(string files)
    {
        throw new NotImplementedException();
    }

    private static string GetFiles()
    {
        throw new NotImplementedException();
    }

    private static void DisplayHelpText()
    {
        throw new NotImplementedException();
    }
}
