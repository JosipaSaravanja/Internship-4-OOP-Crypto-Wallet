using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Wallets
{
    public class Wallet
    {
        public Guid Adress { get; }
        public List<(Guid, Decimal)> BalanceOfFungibleAsset { get; }
        public static List<Guid> AdressesOfSuportedAssets;
        public List<Guid> AdressesOfTransactions;
        public Decimal ValueOfWallet=0;
        public Decimal LastPrintingValue=0;
        
        public Wallet(List<Guid> adressesOfSuportedAssets)
        {
            Adress = Guid.NewGuid();
            AdressesOfSuportedAssets = adressesOfSuportedAssets;
        }
        public void Transaction(Decimal amount, Decimal value)
        {
            ValueOfWallet+=amount*value;
        }
        public virtual void PrintWallet()
        {
            Console.WriteLine($"Adresa: {Adress}\n{ValueOfWallet}");
            if (LastPrintingValue != 0) 
            { 
                Console.WriteLine(ValueOfWallet/LastPrintingValue*100);
            } else
            {
                Console.WriteLine("Ovo je prvi ispis");
            }
            Console.WriteLine("---------------------------------------");
            LastPrintingValue=ValueOfWallet;
        }
        public void AddFungibleAssetsTransaction()
        {

        }
    }
}
