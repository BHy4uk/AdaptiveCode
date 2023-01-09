using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Interfaces
{
    public interface IAccountRepository
    {
        public string GetByName(string uniqueAccountName);

        public int AddTransaction(decimal transactionAmount);
    }
}
