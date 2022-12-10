using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Transaction
{
    public class Non_fungible_asset_transaction : Transactions
    {
        public Non_fungible_asset_transaction(DateTime dateTime, Guid adressOfWalletSending, Guid adressOfWalletReceiving, Decimal value) : base(dateTime, adressOfWalletSending, adressOfWalletReceiving, value)
        { }
    }
}
