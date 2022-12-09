using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Transaction
{
    public class Fungible_asset_transaction : Transactions
    {
        public Decimal InitialBalanceOfWalletSending { get; }
        public Decimal FinalBalanceOfWalletSending { get; }
        public Decimal InitialBalanceOfWalletReceiving { get; }
        public Decimal FinalBalanceOfWalletReceiving { get; }
        public Fungible_asset_transaction(DateTime dateTime, Guid adressOfWalletSending, Guid adressOfWalletReceiving, Decimal initialBalanceOfWalletSending, Decimal finalBalanceOfWalletSending, Decimal initialBalanceOfWalletReceiving, Decimal finalBalanceOfWalletReceiving, Decimal value) : base(dateTime, adressOfWalletSending, adressOfWalletReceiving, value)
        {
            InitialBalanceOfWalletSending = initialBalanceOfWalletSending;
            FinalBalanceOfWalletSending = finalBalanceOfWalletSending;
            InitialBalanceOfWalletReceiving = initialBalanceOfWalletReceiving;
            FinalBalanceOfWalletReceiving = finalBalanceOfWalletReceiving;

        }
    }
}
