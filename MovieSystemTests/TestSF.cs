using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieSystemTests
{
    //Testerna är ofärdig = osäker på hur jag skulle skriva dem..

    [TestClass]
    public class TestSF
    {
        [TestMethod]
        public void Test_To_Create_Facade_SF()
        {
            MovieFacade facade = new MovieFacade();

            Assert.IsFalse(facade.HasBeenPlayed);
        }
    }
}

