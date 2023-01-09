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
        [TestInitialize]
        public void Setup()
        {
            mockAccount = new Mock<Account>();
            mockRepository = new Mock<IAccountRepository>();
            sut = new AccountService(mockRepository.Object);
        }
        private Mock<Account> mockAccount;
        private Mock<IAccountRepository> mockRepository;
        private AccountService sut;

        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            // Arrange
            var account = new Account();
            mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);

            // Act
            sut.AddTransactionToAccount("Trading Account", 200m);

            // Assert
            Assert.AreEqual(200m, account.Balance);
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

        [TestMethod]
        public void DoNotThrowWhenAccountIsNotFound()
        {
            // Arrange

            // Act
            sut.AddTransactionToAccount("Trading Account", 100m);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ServiceException))]
        public void AccountExceptionsAreWrappedInThrowServiceException()
        {
            // Arrange
            //mockAccount.Setup(a => a.AddTransaction(100m)).Throws<DomainException>();
            mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(mockAccount.Object);
            var sut = new AccountService(mockRepository.Object);

            // Act
            sut.AddTransactionToAccount("Trading Account", 100m);

            // Assert
        }
    }
}
