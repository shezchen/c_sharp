using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_15
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext _)
        {
            ProgramWrapper = new ProgramWrapper(
                (args) =>
                    new ValueTask(Task.Run(() => Program.Main(args))), 
                (findText, urls, progress) => Program.FindTextInWebUriAsync(findText, urls.First(), progress));
        }

        override protected void AssertMainException(string messagePrefix, Exception exception)
        {
            Assert.IsTrue(
                    // Handle exceptions rethrown in Listing 19.14
                    IntelliTect.TestTools.Console.StringExtensions.IsLike(exception.Message, "Rethrowing...*") &&
                    IntelliTect.TestTools.Console.StringExtensions.IsLike(exception?.InnerException?.Message, messagePrefix)
                );
        }

        protected override void AssertFindTextInWebUriException(string messagePrefix, Exception exception)
        {
            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }
    }
}
