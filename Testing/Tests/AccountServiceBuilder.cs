﻿using Moq;
using Testing.Interfaces;
using Testing.Services;

namespace Testing.Tests
{
    public class AccountServiceBuilder
    {
        private readonly AccountService _accountService;
        private readonly Mock<IAccountRepository> _mockAccountRepo;
        public Mock<Account> MockAccount
        {
            get;
            private set;
        }
        public AccountServiceBuilder()
        {
            _mockAccountRepo = new Mock<IAccountRepository>();
            _accountService = new AccountService(_mockAccountRepo.Object);
        }
        public AccountServiceBuilder WithAccountCalled(string accountName)
        {
            MockAccount = new Mock<Account>();
            _mockAccountRepo.Setup(r =>
            r.GetByName("Trading Account")).Returns(MockAccount.Object);
            return this;
        }
        public AccountServiceBuilder AddTransactionOfValue(decimal transactionValue)
        {
            MockAccount.Setup(a => a.AddTransaction(200m)).Verifiable();
            return this;
        }
        public AccountService Build()
        {
            return _accountService;
        }
    }
}
