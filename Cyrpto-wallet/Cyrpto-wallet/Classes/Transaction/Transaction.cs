using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Transaction
{
    public class Transaction
    {
        public Guid Id { get; }
        public Guid AdressOfAsset { get; }
        public DateOnly Date { get; }
        public Guid AdressOfWalletSending { get; }
        public Guid AdressOfWalletReceiving { get; }
        public bool IsRevoked { get; }
        public Transaction(DateOnly date, Guid adressOfWalletSending, Guid adressOfWalletReceiving)
        {
            Id = Guid.NewGuid();
            AdressOfAsset = Guid.NewGuid();
            Date = date;
            AdressOfWalletSending = adressOfWalletReceiving;
            AdressOfWalletReceiving = adressOfWalletSending;
            IsRevoked = false;
        }
        //print transactions()???
    }
}
