using NUnit.Framework;
namespace TDDCheckoutKata
{
    [TestFixture]
    class TddCheckoutKataTests
    {
        [Test]
        [TestCase("",0, TestName="Basket is empty total is 0")]
        [TestCase("A",50, TestName="Basket contains 'A' total is 50")]
        [TestCase("B",30, TestName="Basket contains 'B' total is 30")]
        [TestCase("C",20, TestName="Basket contains 'B' total is 20")]
        [TestCase("D",15, TestName="Basket contains 'B' total is 15")]
        public void CheckoutBasketContainsASingleItemTotalsCorrectly(string basket, int expected)
        {

            //Act
            var result = ShoppingCart.Checkout(basket);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("AA", 100, TestName = "Basket contains 'AA' total is 100")]
        public void CheckoutBasketContainsAMultipleItemsButNoffersTotalsCorrectly(string basket, int expected)
        {

            //Act
            var result = ShoppingCart.Checkout(basket);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        
    }
}
