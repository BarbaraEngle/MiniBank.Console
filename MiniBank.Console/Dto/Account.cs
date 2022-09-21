using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Console.Dto
{
    internal class Account
    {

        public Account()
        {
            FirstName = String.Empty;
            Surname = String.Empty;
            AccountNo = String.Empty;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string AccountNo { get; set; }
    }
}
