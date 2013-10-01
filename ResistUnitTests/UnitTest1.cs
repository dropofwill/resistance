using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistWPF;
using System.Diagnostics;

namespace ResistUnitTests
{
    [TestClass]
    public class UnitTestInit
    {
        [TestMethod]
        public void SpySelection()
        {
            var game = new Game();
            game.chooseRoles();
            
            //Assert.IsInstanceOfType(game.ResistIndex, typeof(List<int>));
            Assert.AreEqual(3, game.ResistIndex.Count);
        }
    }
}
