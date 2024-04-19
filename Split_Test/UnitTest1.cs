using split_bill;

namespace Split_Test
{
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        decimal totalAmount = 100.00m;
            int numberOfPeople = 5;
            decimal expectedSplit = 20.00m;
            bill_splitter splitter = new bill_splitter();
            decimal actualSplit = splitter.Amountsplited(totalAmount, numberOfPeople);
            Assert.AreEqual(expectedSplit, actualSplit);
    }
    [TestMethod]
        public void Amountsplited_LargeTotalAmount_ReturnsRoundedSplit()
        {
    
            decimal totalAmount = 115.00m;
            int numberOfPeople = 7;
            decimal expectedSplit = 16.43m; // Rounded up from 16.428
            bill_splitter splitter = new bill_splitter();
            decimal actualSplit = splitter.Amountsplited(totalAmount, numberOfPeople);
            Assert.AreEqual(expectedSplit, actualSplit);
        }
    [TestClass]
    public class CalculateTipTests
    {
        [TestMethod]
        public void CalculateTip_ValidInputs_ReturnsCorrectTipAmounts()
        {
            var mealCosts = new Dictionary<string, decimal>
            {
                {"rohan1", 20.00m},
                {"yash2", 30.00m},
                {"prit3", 25.00m}
            };
            float tipPercentage = 15.0f;
            var expectedTipAmounts = new Dictionary<string, decimal>
            {
                {"rohan1", 3.00m},
                {"yash2", 4.50m},
                {"prit3", 3.75m}
            };
            bill_splitter splitter = new bill_splitter();
            var actualTipAmounts = splitter.CalculateTip(mealCosts, tipPercentage);
            Assert.AreEqual(expectedTipAmounts, actualTipAmounts);
        }
        [TestMethod]
        public void CalculateTip_EmptyMealCosts_ThrowsArgumentException()
        {
            var mealCosts = new Dictionary<string, decimal>();
            float tipPercentage = 15.0f;
            bill_splitter splitter = new bill_splitter();
            Assert.AreEqual(mealCosts, tipPercentage);
        }

        [TestMethod]
        public void CalculateTip_InvalidTipPercentage_ThrowsArgumentException()
        {
            var mealCosts = new Dictionary<string, decimal>
            {
                {"rohan1", 20.00m},
                {"yash2", 30.00m},
                {"Prit3", 25.00m}
            };
            float tipPercentage = -10.0f;
            bill_splitter splitter = new bill_splitter();
            Assert.AreEqual(mealCosts, tipPercentage);
        }
    }

        


}
}
