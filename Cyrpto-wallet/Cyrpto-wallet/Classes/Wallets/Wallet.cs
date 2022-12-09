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
        public string Type ="";
        public List<(Guid name, Decimal amount)> BalanceOfFungibleAsset { get; }= new List<(Guid name, Decimal amount)>();
        public List<Guid> AdressesOfSuportedAssets=new List<Guid>();
        public List<Guid> AdressesOfTransactions=new List<Guid>();
        public Decimal LastPrintingValue=0;
        
        public Wallet(List<Guid> adressesOfSuportedAssets)
        {
            Adress = Guid.NewGuid();
            AdressesOfSuportedAssets = adressesOfSuportedAssets;
        }

        public virtual Decimal GetValue()
        {
            decimal br=0;
            foreach(var el in BalanceOfFungibleAsset)
            {
               br+=Storage.FungibleAssets.Find(item=>item.Adress==el.name).Value*el.amount;
            }
            return br;
        }


        public virtual void PrintWallet()
        {
            Console.WriteLine($"Adresa: {Adress}\n{GetValue()}");
            if (LastPrintingValue != 0) 
            { 
                Console.WriteLine(GetValue()/LastPrintingValue*100-100);
            } 
            Console.WriteLine("---------------------------------------");
            LastPrintingValue=GetValue();
        }

        public virtual void PortofolioPrint()   
        {
            Console.WriteLine($"Ukupna vrijednost: {GetValue()} $");
            foreach(var el in BalanceOfFungibleAsset)
            {
                    var asset=Storage.FungibleAssets.Find(item => item.Adress==el.name);
                    Console.WriteLine($"Adresa: {el.name} \n"+
                        $"Ime: {asset.Name}\n"+
                        $"Ime: {asset.Label}\n"+
                        $"Ime: {asset.Value*el.amount}\n"+
                        $"Ime: {asset.OldValue/asset.Value*100-100}%");
            }
        }
        public virtual void AddTransaction(Guid adressOfTransaction)
        {
            AdressesOfTransactions.Add(adressOfTransaction);
        }

        public virtual void PrintTrasactions()
        {
            foreach(var el in AdressesOfTransactions)
            {
                var transaction=Storage.AllTransactions.Find(item => item.Id == el);
                Console.WriteLine($"Id: {transaction.Id}");
                Console.WriteLine($"Datum i vrijeme transakcije: {transaction.Date}");
                Console.WriteLine($"Adresa walleta koji šalje: {transaction.AdressOfWalletSending}");
                Console.WriteLine($"Adresa walleta koji šalje: {transaction.AdressOfWalletReceiving}");
                if(Storage.FungibleTransactions.FindIndex(item => item.Id == el) != -1)
                {
                    Console.WriteLine($"Količina u USD: {transaction.Value}");
                    Console.WriteLine($"Fungible asset ime: {Storage.FungibleAssets.Find(item=>item.Adress==transaction.AdressOfAsset)}");
                } else
                {
                    Console.WriteLine($"Non fungible asset ime: {Storage.NonFungibleAssets.Find(item=>item.Adress==transaction.AdressOfAsset)}"); 
                }
                Console.WriteLine($"Opozvana: {transaction.IsRevoked}");
            }
        }
    }
}
