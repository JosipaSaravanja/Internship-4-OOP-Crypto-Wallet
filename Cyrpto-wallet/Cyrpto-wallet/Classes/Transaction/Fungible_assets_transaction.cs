using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Transaction
{
    public class Fungible_asset_transaction : Transaction
    {
        public Decimal InitialBalanceOfWalletSending { get; }
        public Decimal FinalBalanceOfWalletSending { get; }
        public Decimal InitialBalanceOfWalletReceiving { get; }
        public Decimal FinalBalanceOfWalletReceiving { get; }
        public Fungible_asset_transaction(DateOnly date, Guid adressOfWalletSending, Guid adressOfWalletReceiving, Decimal initialBalanceOfWalletSending, Decimal finalBalanceOfWalletSending, Decimal initialBalanceOfWalletReceiving, Decimal finalBalanceOfWalletReceiving) : base(date, adressOfWalletSending, adressOfWalletReceiving)
        {
            InitialBalanceOfWalletSending = initialBalanceOfWalletSending;
            FinalBalanceOfWalletSending = finalBalanceOfWalletSending;
            InitialBalanceOfWalletReceiving = initialBalanceOfWalletReceiving;
            FinalBalanceOfWalletReceiving = finalBalanceOfWalletReceiving;

        }
    }
}
