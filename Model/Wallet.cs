using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Domain.Model
{
    public class Wallet
    {
        [Key]
        public string WalletAddress { get; set; }
        public DateTime DateCreated { get; set; } 
        public double Balance { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }
        

    }
}
