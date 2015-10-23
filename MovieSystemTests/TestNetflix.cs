using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieSystemTests
{
    //Testerna är ofärdig = osäker på hur jag skulle skriva dem..

    [TestClass]
    public class TestNetflix
    {

        [TestMethod]
        public void Test_To_Create_Facade_Netflix()
        {
            IPlayer player = PlayerFactory.CreatePlayer(movieName);

            MovieFacade sut = new MovieFacade(movieName);

            sut.Play("Star Wars 3");

            Assert.IsTrue(sut.HasBeenPlayed);

        }
    }
}
