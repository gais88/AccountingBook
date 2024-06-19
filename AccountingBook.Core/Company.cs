using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingBook.Core
{
    public class Company:EntityBase
    {
        public Company(string comapnyName, string comapnyShortName, string comapnyCode)
        {
            ComapnyName = comapnyName;
            ComapnyShortName = comapnyShortName;
            ComapnyCode = comapnyCode;
        }

        public string ComapnyName { get; set; } = string.Empty;
        public string ComapnyShortName { get; set; } = string.Empty;
        public string ComapnyCode { get; set; } = string.Empty;
    }
}
