using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Wallets
{
    public class Bitcoin_wallet : Wallet
    {
        public Bitcoin_wallet(List<Guid> adressesOfSuportedAssets) : base(adressesOfSuportedAssets)
        {
            Type="Bitcoin_wallet";

        }     

        public override void PrintWallet()
        {
            Console.WriteLine("Tip: "+Type);
            base.PrintWallet();
        }
        
    }
}
//41988bba-59ee-4748-9f11-f2fe447bd70e