using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Domain.Model
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
        public string TransactionType { get; set; }
        public double Amount { get; set; }
        public DateTime TransanctionDate {get; set; }
        public string Description { get; set; }

        [ForeignKey (nameof(Wallet))]  
        public string WalletAddress { get; set; }
        public Wallet Wallet { get; set; }
    }
}
