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
        public void Amountsplited_ZeroAmount_ThrowsArgumentException()
        {
            
            decimal totalAmount = 0m;
            int numberOfPeople = 9;
            bill_splitter splitter = new bill_splitter();
            Assert.AreEqual(totalAmount, numberOfPeople);
        }
    [TestMethod]
    public void Amountsplited_NegativeTotalAmount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalAmount = -45.00m;
        int numberOfPeople = 9;

        // Act & Assert
        bill_splitter splitter = new bill_splitter();
        Assert.AreEqual(totalAmount, numberOfPeople);
    }
    [TestMethod]
        public void Amountsplited_NegativeTotalAmount_ThrowsArgumentExceptionlast()
        {
        
            decimal totalAmount = -100.00m;
            int numberOfPeople = 5;
            bill_splitter splitter = new bill_splitter();
            Assert.AreEqual(totalAmount, numberOfPeople);
        }

        


}
}