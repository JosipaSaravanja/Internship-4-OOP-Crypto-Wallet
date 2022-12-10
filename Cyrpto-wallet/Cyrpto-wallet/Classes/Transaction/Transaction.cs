using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Transaction
{
    public class Transactions
    {
        public Guid Id { get; }
        public Guid AdressOfAsset { get; }
        public DateTime Date { get; }
        public Guid AdressOfWalletSending { get; }
        public Guid AdressOfWalletReceiving { get; }
        public bool IsRevoked;
        public Decimal Value; //ili amount
        public Transactions(DateTime dateTime, Guid adressOfWalletSending, Guid adressOfWalletReceiving, Decimal value)
        {
            Id = Guid.NewGuid();
            AdressOfAsset = Guid.NewGuid();
            Date = dateTime;
            AdressOfWalletSending = adressOfWalletReceiving;
            AdressOfWalletReceiving = adressOfWalletSending;
            Value=value;
            IsRevoked = false;
        }
        public void Revoke()
        {
            IsRevoked=true;
        }
    }
}
