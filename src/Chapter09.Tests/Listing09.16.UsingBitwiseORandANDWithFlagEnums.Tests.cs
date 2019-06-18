﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_16.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod][Ignore]
        public void Main_ExpectHiddenAndReadOnlyFlags()
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            FileAttributes fileAttributes;
            string expected;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // The only working file attribute on Linux is ReadOnly.
                fileAttributes = FileAttributes.ReadOnly;
                Assert.AreEqual<int>(1, (int)fileAttributes);
                expected = $@"ReadOnly = {(int)fileAttributes}";
            }
            else
            {
                fileAttributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
                Assert.AreEqual<int>(3, (int)fileAttributes);
                expected = $@"ReadOnly, Hidden = {(int)fileAttributes}";
            }
            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}