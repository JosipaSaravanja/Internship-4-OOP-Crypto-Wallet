using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Wallets
{
    public class Solana_wallet : Wallet
    {
        public static List<Guid> AdressesOfSuportedAssets = new List<Guid>()
        {
            //pronaći podatke
        };
        public List<Guid> AdressesOfNonFunglibleAssets { get; private set; }
        public Solana_wallet() : base(AdressesOfSuportedAssets)
        {
        }
        public override void PrintWallet()
        {
            Console.WriteLine("Tip: Solana Wallet");
            base.PrintWallet();
        }
    }
}
