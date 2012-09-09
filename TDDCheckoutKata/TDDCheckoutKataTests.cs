using NUnit.Framework;
namespace TDDCheckoutKata
{
    [TestFixture]
    class TddCheckoutKataTests
    {
        [Test]
        public void CheckoutBasketContainsASingleATotalShouldBeFifty()
        {
            //Arrange
            var basket = "A";

            //Act
            var result = ShoppingCart.Checkout(basket);

            //Assert
            Assert.That(result, Is.EqualTo(50));
        }

        
    }
}
