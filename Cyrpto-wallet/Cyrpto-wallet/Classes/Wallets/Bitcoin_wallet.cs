using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Wallets
{
    public class Bitcoin_wallet : Wallet
    {
        public static List<Guid> AdressesOfSuportedAssets = new List<Guid>()
        {
            Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e")//pronaći stvarne podatke
        };
        public Bitcoin_wallet() : base(AdressesOfSuportedAssets)
        {
        }
        public override void PrintWallet()
        {
            Console.WriteLine("Tip: Bitcoin Wallet");
            base.PrintWallet();
        }
        
        public void AddFungibleNonAssetsTransaction()
        {

        }
    }
}
