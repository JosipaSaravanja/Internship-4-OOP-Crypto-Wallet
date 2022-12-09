using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Wallets
{
    public class Ethereum_wallet : Wallet
    {
        public List<Guid> AdressesOfNonFunglibleAssets { get; private set; } = new List<Guid>();
        public Ethereum_wallet(List<Guid> adressesOfSuportedAssets) : base(adressesOfSuportedAssets)
        {
        }
        public override void PrintWallet()
        {
            Console.WriteLine("Tip: Ethereum Wallet");
            base.PrintWallet();
        }
        public override Decimal GetValue()
        {
            Decimal a= base.GetValue();
            foreach(var el in AdressesOfNonFunglibleAssets)
            {
                a+=Storage.NonFungibleAssets.Find(item=>item.Adress==el).Value;
            }
            return a;
        }
        
        public override void PortofolioPrint()
        {
            base.PortofolioPrint();
            foreach(var assets in AdressesOfNonFunglibleAssets)
            {
                    var nonFungible=Storage.NonFungibleAssets.Find(item => item.Adress==assets).AdressOfFungibleAssetOfValue;
                    var fungible=Storage.NonFungibleAssets.Find(item => item.Adress==assets);
                    Console.WriteLine($"Adresa: {assets} \nIme: {fungible.Name}");
                    Console.WriteLine($"Vrijednost u fungible asset: {fungible.Value}");
                    Console.WriteLine($"Vrijednost u dolarima: {fungible.Value*Storage.FungibleAssets.Find(item=>item.Adress==nonFungible).Value}");
                    Console.WriteLine($"Ime: {100*Storage.FungibleAssets.Find(item=>item.Adress==nonFungible).Value/Storage.FungibleAssets.Find(item=>item.Adress==nonFungible).OldValue}"); //ne znam moze li se sama vrijednost non fungible asseta mjenjat kao u fungible asset vrijednostima a ne u odnosu na dolare
            }
            
        }
    }
}
