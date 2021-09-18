using BaseCoreUnitTestProject1.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseCoreUnitTestProject1
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod1()
        {
            // arrange

            Assert.IsFalse(false);
            // act


            // assert
        }
        [TestMethod]
        [TestTraits(Trait.EfCore)]
        public void TestMethod2()
        {
            // TODO
        }
        [TestMethod]
        [TestTraits(Trait.EfCore)]
        public void TestMethod3()
        {
            // TODO
        }
    }
}
