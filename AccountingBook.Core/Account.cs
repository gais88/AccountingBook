using AccountingBook.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingBook.Core
{
    public class Account:EntityBase
    {
        public string AccountName { get; set; } = string.Empty;
        public string AccountCode { get; set; } = string.Empty;
        public DeOrCrSide DeOrCrSide  { get; set; }
        public AccountType AccountType { get; set; }

        public long? ParentAccountId { get; set; }
        public virtual Account ParentAccount { get; set; } = default!;

        public virtual ICollection<Account> ChildAccounts { get; set; } = default!;
        public void AddChildAccount(Account account)
        {

        }
        public bool CanPost()
        {
            return false;
        }
    }
}
