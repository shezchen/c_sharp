// Ignored as implementation was removed for elucidation
#pragma warning disable IDE0060 //Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_52
{
    using System;

    #region INCLUDE
    // File: Program.cs
    partial class Program
    {
        static void Main(string[] args)
        {
            CommandLine commandLine = new CommandLine(args);

            switch (commandLine.Action)
            {
                #region EXCLUDE
                default:
                    break;
                    #endregion
            }
        }
    }

    // File: Program+CommandLine.cs
    partial class Program
    {
        // Define a nested class for processing the command line
        private class CommandLine
        {
            #region EXCLUDE
            public CommandLine(string[] args)
            {
                //not implemented
            }

            // ...
            public int Action
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
            #endregion
        }
    }
    #endregion
}
