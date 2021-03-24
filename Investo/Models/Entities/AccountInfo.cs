using System;
namespace Investo.Models.Entities
{
    public class AccountInfo : Details
    {

        // creating a database object

        public DateTime DateOfbirth { get; set; }

        public int IdOfAcc { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string AccountNumber { get; set; }

        public int AccountStatus { get; set; }
    }
}
