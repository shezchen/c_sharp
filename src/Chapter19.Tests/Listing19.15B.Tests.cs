using AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext textContext)
        {
            ProgramWrapper = new ProgramWrapper(
                Program.Main,
                (findText, urls, progress) => Program.FindTextInWebUriAsync(findText, urls, progress));
        }

        protected override void AssertMainException(string messagePrefix, Exception exception)
        {
            Assert.AreEqual<Type>(typeof(AggregateException), exception.GetType());  // Testing type first (even though the cast will also verify)

            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }
    }
}
