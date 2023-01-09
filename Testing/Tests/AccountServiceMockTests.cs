using Microsoft.ServiceFabric.Services.Communication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Testing.Interfaces;
using Testing.Services;

namespace Testing.Tests
{
    [TestClass]
    public class AccountServiceMockTests
    {
        private AccountServiceBuilder _accountServiceBuilder;

        [TestInitialize]
        public void TestInitialize()
        {
            _accountServiceBuilder = new AccountServiceBuilder();
        }
        [TestMethod]
        public void
        AddingTransactionToAccountDelegatesToAccountInstance()
        {
            // Arrange
            var sut = _accountServiceBuilder
            .WithAccountCalled("Trading Account")
            .AddTransactionOfValue(200m)
            .Build();
            // Act
            sut.AddTransactionToAccount("Trading Account", 200m);
            // Assert
            _accountServiceBuilder.MockAccount.Verify();
        }

    [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CannotCreateAccountServiceWithNullAccountRepository()
        {
            // Arrange

            // Act
            new AccountService(null);

            // Assert
        }

        //[TestMethod]
        //public void DoNotThrowWhenAccountIsNotFound()
        //{
        //    // Arrange

        //    // Act
        //    sut.AddTransactionToAccount("Trading Account", 100m);

        //    // Assert
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ServiceException))]
        //public void AccountExceptionsAreWrappedInThrowServiceException()
        //{
        //    // Arrange
        //    //mockAccount.Setup(a => a.AddTransaction(100m)).Throws<DomainException>();
        //    mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(mockAccount.Object);
        //    var sut = new AccountService(mockRepository.Object);

        //    // Act
        //    sut.AddTransactionToAccount("Trading Account", 100m);

        //    // Assert
        //}
    }
}
