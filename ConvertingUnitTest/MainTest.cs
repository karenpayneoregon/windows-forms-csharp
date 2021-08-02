using ConvertingUnitTest.Base;
using ConvertingUnitTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertingUnitTest
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.SingleConvert)]
        public void TestToDecimal()
        {
            string mockedBasePrice = "USD1000";
            decimal basePrice = mockedBasePrice.ToDecimal();
            decimal expected = 1000;
            
            Assert.AreEqual(basePrice, expected);

        }
        
        [TestMethod]
        [TestTraits(Trait.SingleConvert)]
        public void TestStringValueIsNotGreaterThan()
        {
            string mockedBasePrice = "USD1000";
            decimal basePrice = mockedBasePrice.ToDecimal();

            string value = "USD999";
            
            Assert.IsFalse(value.ToDecimal() > basePrice);
        }
        
        [TestMethod]
        [TestTraits(Trait.SingleConvert)]
        public void TestStringValueIsGreaterThan()
        {
            string mockedBasePrice = "USD1000";
            decimal basePrice = mockedBasePrice.ToDecimal();

            string value = "USD1001";

            Assert.IsTrue(value.ToDecimal() > basePrice);
        }
        
        [TestMethod]
        [TestTraits(Trait.SingleConvert)]
        public void TestStringWithWhiteSpace()
        {
            string mockedBasePrice = "USD1000";
            decimal basePrice = mockedBasePrice.ToDecimal();

            string value = "USD10 01";

            Assert.IsTrue(value.ToDecimal() > basePrice);
        }

        [TestMethod]
        [TestTraits(Trait.ArrayConvert)]
        public void TestStringArrayNotGreaterThan()
        {
            string mockedBasePrice = "USD1000";
            decimal basePrice = mockedBasePrice.ToDecimal();
            
            string[] values = { "USD999", "", "USD20" };

            var onlyDecimalArray = values.ToDecimalArray();
            
            Assert.IsFalse(onlyDecimalArray.GreaterThan(basePrice));
        }
        [TestMethod]
        [TestTraits(Trait.ArrayConvert)]
        public void TestStringArrayIsGreaterThan()
        {
            string mockedBasePrice = "USD1000";
            decimal basePrice = mockedBasePrice.ToDecimal();

            string[] values = { "USD999", "USD2020", "USD20" };

            var onlyDecimalArray = values.ToDecimalArray();

            Assert.IsTrue(onlyDecimalArray.GreaterThan(basePrice));
            Assert.IsTrue(onlyDecimalArray[1].GreaterThan(basePrice));
        }

    }
}
    

