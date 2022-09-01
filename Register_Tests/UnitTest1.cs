using Register;

namespace Register_Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestGrandTotal()
        {
            List<Product> values = new List<Product>();
            values.Add(new Product("Milk", 2.50m));
            values.Add(new Product("Bread", 2.00m));
            values.Add(new Product("Eggs", 3.00m));

            decimal actual = CashRegister.GrandTotal(values);
            Assert.Equal(7.50m, actual);

        }

        [Fact]
        public void TestGrandTotal0()
        {
            List<Product> values = new List<Product>();


            decimal actual = CashRegister.GrandTotal(values);
            Assert.Equal(0m, actual);

        }

        [Fact]
        public void TestTax1()
        {
            List<Product> valueList = new List<Product>();
            valueList.Add(new Product("Milk", 2.50m));
            valueList.Add(new Product("Bread", 2.00m));
            valueList.Add(new Product("Eggs", 3.00m));

            decimal actual = CashRegister.CalculateTax(valueList);
            Assert.Equal(0.45m, actual);
        }

        [Fact]
        public void TestTax2()
        {
            List<Product> valueList = new List<Product>();

            decimal actual = CashRegister.CalculateTax(valueList);

            Assert.Equal(0.0m, actual);

        }


    }
}