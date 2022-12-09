using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Wallets
{
    public class Solana_wallet : Wallet
    {
        public List<Guid> AdressesOfNonFunglibleAssets { get; private set; } = new List<Guid>();
        public Solana_wallet(List<Guid> adressesOfSuportedAssets) : base(adressesOfSuportedAssets)
        {
        }
        public override void PrintWallet()
        {
            Console.WriteLine("Tip: Solana Wallet");
            base.PrintWallet();
        }
    }
}
