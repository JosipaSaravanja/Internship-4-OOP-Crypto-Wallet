using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Transaction
{
    public class Non_fungible_asset_transaction : Transaction
    {
        public Non_fungible_asset_transaction(DateOnly date, Guid adressOfWalletSending, Guid adressOfWalletReceiving) : base(date, adressOfWalletSending, adressOfWalletReceiving)
        { }
    }
}
