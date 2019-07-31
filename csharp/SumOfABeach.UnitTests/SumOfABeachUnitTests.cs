using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfABeach.UnitTests
{
    [TestClass]
    public class SumOfABeachUnitTests
    {
        [TestMethod]
        public void SumOfABeach_ZeroWords_ReturnsZero()
        {
            Assert.AreEqual(0, Kata.SumOfABeach("String"), "Should be zero");
            Assert.AreEqual(0, Kata.SumOfABeach(""), "Should be zero");
            Assert.AreEqual(0, Kata.SumOfABeach("su"), "Should be zero");
            Assert.AreEqual(0, Kata.SumOfABeach("alphalphalpha"), "Should be zero");
        }
        [TestMethod]
        public void SumOfABeach_SunWords_ReturnsOne()
        {
            Assert.AreEqual(1, Kata.SumOfABeach("sun"), "assert 1");
            Assert.AreEqual(1, Kata.SumOfABeach("SUNar"), "assert 2");
            Assert.AreEqual(1, Kata.SumOfABeach("naruSuN"), "assert 3");
            Assert.AreEqual(1, Kata.SumOfABeach("nusunus"), "assert 4");
        }
        [TestMethod]
        public void SumOfABeach_WaterWords_ReturnsOne()
        {
            Assert.AreEqual(1, Kata.SumOfABeach("water"), "assert 1");
            Assert.AreEqual(1, Kata.SumOfABeach("watwater"), "assert 2");
            Assert.AreEqual(1, Kata.SumOfABeach("waterwat"), "assert 3");
            Assert.AreEqual(1, Kata.SumOfABeach("fukwaterful"), "assert 4");
        }
        [TestMethod]
        public void SumOfABeach_AllWords_ReturnsOne()
        {
            Assert.AreEqual(1, Kata.SumOfABeach("water"), "assert 1");
            Assert.AreEqual(1, Kata.SumOfABeach("sun"), "assert 2");
            Assert.AreEqual(1, Kata.SumOfABeach("sand"), "assert 3");
            Assert.AreEqual(1, Kata.SumOfABeach("fish"), "assert 4");
            Assert.AreEqual(1, Kata.SumOfABeach("xxxfish"), "assert 5");
            Assert.AreEqual(1, Kata.SumOfABeach("fishxx"), "assert 6");
            Assert.AreEqual(1, Kata.SumOfABeach("assertedsun"), "assert 7");
        }
        [TestMethod]
        public void SumOfABeach_AllWords_ReturnsTwo()
        {
            Assert.AreEqual(2, Kata.SumOfABeach("waterwater"), "assert 1");
            Assert.AreEqual(2, Kata.SumOfABeach("sunsun"), "assert 2");
            Assert.AreEqual(2, Kata.SumOfABeach("sandsand"), "assert 3");
            Assert.AreEqual(2, Kata.SumOfABeach("fishfish"), "assert 4");
            Assert.AreEqual(2, Kata.SumOfABeach("sandsun"), "assert 5");
            Assert.AreEqual(2, Kata.SumOfABeach("fisandfisun"), "assert 6");

        }
        public void SumOfABeach_AllWords_ReturnsThree()
        {
            Assert.AreEqual(3, Kata.SumOfABeach("waterwatersssand"), "assert 1");
            Assert.AreEqual(3, Kata.SumOfABeach("sunsunxxxxxxxxsunx"), "assert 2");
            Assert.AreEqual(3, Kata.SumOfABeach("sandsandxxxxfish"), "assert 3");
            Assert.AreEqual(3, Kata.SumOfABeach("fishfishfishi"), "assert 4");
            Assert.AreEqual(3, Kata.SumOfABeach("sandsunwater"), "assert 5");
            Assert.AreEqual(3, Kata.SumOfABeach("fisandfisunfifish"), "assert 6");

        }
    }
}
