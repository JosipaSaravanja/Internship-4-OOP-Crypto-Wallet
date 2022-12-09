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
        /*
        public void PortofolioPrint()
            
        {
            Console.WriteLine($"Ukupna vrijednost: {ValueOfWallet} $");
            if (ValueOfWallet!=0) 
            { foreach(var assets in BalanceOfFungibleAsset)
            {
                    Console.WriteLine($"Adresa: {assets.name} \n"+
                        $"Ime: {Storage.FungibleAssets.Find(item => item.Adress==assets.name).Name}\n"+
                        $"Ime: {Storage.FungibleAssets.Find(item => item.Adress==assets.name).Label}\n"+
                        $"Ime: {Storage.FungibleAssets.Find(item => item.Adress==assets.name).Value}\n"+
                        $"Ime: {Storage.FungibleAssets.Find(item => item.Adress==assets.name).OldValue}");

            }
                
            }*/
            /*
            Decimal sum=0;
            foreach(var assets in AdressesOfSuportedAssets)
            {
                var asset=Storage.FungibleAssets.Find(item => item.Adress==assets).ValueInDolars;
                var amount=BalanceOfFungibleAsset.Find(item => item.name==assets).amount;
                sum+=asset*amount;
            }
            Console.WriteLine($"ukupna vrijedonst: {sum}");
            
            foreach(var assets in AdressesOfSuportedAssets)
            {
                var asset=Storage.FungibleAssets.Find(item => item.Adress==assets).ValueInDolars;
                var amount=BalanceOfFungibleAsset.Find(item => item.name==assets).amount;
                sum+=asset*amount;
            }*/
        
    }
}
