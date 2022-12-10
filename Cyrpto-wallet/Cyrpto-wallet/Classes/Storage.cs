using Cyrpto_wallet.Classes.Assets;
using Cyrpto_wallet.Classes.Wallets;
using Cyrpto_wallet.Classes.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes
{
    internal class Storage
    {
        public static List<Wallet> Wallets { get; private set; } = new List<Wallet>();
        public static List<Bitcoin_wallet> BitcoinWallets { get; private set; } = new List<Bitcoin_wallet>();
        public static List<Ethereum_wallet> EthereumWallets { get; private set; } = new List<Ethereum_wallet>();
        public static List<Solana_wallet> SolanaWallets { get; private set; } = new List<Solana_wallet>();
        public static List<Guid> BitcoinFungibleAssets=new List<Guid>();
        public static List<Guid> EthereumFungibleAssets=new List<Guid>();
        public static List<Guid> SolanaFungibleAssets=new List<Guid>();
        public static List<Fungible_asset> FungibleAssets { get; private set; } = new List<Fungible_asset>();
        public static List<Non_Fungible_asset> NonFungibleAssets { get; private set; } = new List<Non_Fungible_asset>();
        public static List<Fungible_asset_transaction> FungibleTransactions { get; private set; } = new List<Fungible_asset_transaction>();
        public static List<Non_fungible_asset_transaction> NonFungibleTransactions { get; private set; } = new List<Non_fungible_asset_transaction>();
        public static List<Transactions> AllTransactions { get; private set; } = new List<Transactions>();

        static Storage()
        {
            FungibleAssets.Add(new Fungible_asset("Bitcoin", new Decimal(16923.60), "BTC"));
            FungibleAssets.Add(new Fungible_asset("Gridcoin", new Decimal(0.0457), "GRC"));
            FungibleAssets.Add(new Fungible_asset("Binance", new Decimal(1), "NMC"));
            FungibleAssets.Add(new Fungible_asset("Namecoin", new Decimal(16923.60), ""));
            FungibleAssets.Add(new Fungible_asset("Auroracoin", new Decimal(0.4411), "AUR"));
            FungibleAssets.Add(new Fungible_asset("Solana", new Decimal(14.16), "SOL"));
            FungibleAssets.Add(new Fungible_asset("Dogecoin", new Decimal(0.1), "DOGE"));
            FungibleAssets.Add(new Fungible_asset("Etherum", new Decimal(1255.55), "ETH"));
            FungibleAssets.Add(new Fungible_asset("XRP", new Decimal(0.39), "XRP"));
            FungibleAssets.Add(new Fungible_asset("Litcoin", new Decimal(79.59), "Litcoin"));
            
            
            NonFungibleAssets.Add(new Non_Fungible_asset("Yellow dress", 1, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("red cat", 2, FungibleAssets[1].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("blue dog", 3, FungibleAssets[2].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("purple desk", 4, FungibleAssets[3].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("white coat", 5, FungibleAssets[4].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("green flower", 6, FungibleAssets[5].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("yellow pencil", 7, FungibleAssets[6].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("round ball", 8, FungibleAssets[7].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("wooden stick", 9, FungibleAssets[8].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("sword", 10, FungibleAssets[9].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("apple", 11, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("orange orange", 12, FungibleAssets[1].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("banana", 13, FungibleAssets[2].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("ananans", 14, FungibleAssets[3].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("monkey", 15, FungibleAssets[4].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("russian flag", 16, FungibleAssets[5].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("medal", 17, FungibleAssets[6].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("golden ring", 18, FungibleAssets[7].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("diamond ring", 19, FungibleAssets[8].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("blue pants", 20, FungibleAssets[9].Adress));
            
            BitcoinFungibleAssets.Add(FungibleAssets[0].Adress);
            BitcoinFungibleAssets.Add(FungibleAssets[3].Adress);
            BitcoinFungibleAssets.Add(FungibleAssets[6].Adress);
            BitcoinFungibleAssets.Add(FungibleAssets[9].Adress);
            
            EthereumFungibleAssets.Add(FungibleAssets[1].Adress);
            EthereumFungibleAssets.Add(FungibleAssets[4].Adress);
            EthereumFungibleAssets.Add(FungibleAssets[7].Adress);
            
            SolanaFungibleAssets.Add(FungibleAssets[2].Adress);
            SolanaFungibleAssets.Add(FungibleAssets[5].Adress);
            SolanaFungibleAssets.Add(FungibleAssets[8].Adress);
                                                    
            BitcoinWallets.Add(new Bitcoin_wallet(BitcoinFungibleAssets));
            BitcoinWallets.Add(new Bitcoin_wallet(BitcoinFungibleAssets));
            BitcoinWallets.Add(new Bitcoin_wallet(BitcoinFungibleAssets));

            EthereumWallets.Add(new Ethereum_wallet(EthereumFungibleAssets));
            EthereumWallets.Add(new Ethereum_wallet(EthereumFungibleAssets));
            EthereumWallets.Add(new Ethereum_wallet(EthereumFungibleAssets));

            SolanaWallets.Add(new Solana_wallet(SolanaFungibleAssets));
            SolanaWallets.Add(new Solana_wallet(SolanaFungibleAssets));
            SolanaWallets.Add(new Solana_wallet(SolanaFungibleAssets));
            
            Wallets.Add(BitcoinWallets[0]);
            Wallets.Add(BitcoinWallets[1]);
            Wallets.Add(BitcoinWallets[2]);
            Wallets.Add(EthereumWallets[0]);
            Wallets.Add(EthereumWallets[1]);
            Wallets.Add(EthereumWallets[2]);
            Wallets.Add(SolanaWallets[0]);
            Wallets.Add(SolanaWallets[1]);
            Wallets.Add(SolanaWallets[2]);
        }
        public static void AddWallet(string str)
        {
            switch (str)
            {
                case "Bitcoin":
                    var Bitcoin=new Bitcoin_wallet(BitcoinFungibleAssets);
                    BitcoinWallets.Add(Bitcoin);
                    Wallets.Add(Bitcoin);
                    break;
                case "Ethereum":
                    var Ethereum=new Ethereum_wallet(EthereumFungibleAssets);
                    EthereumWallets.Add(Ethereum);
                    Wallets.Add(Ethereum);
                    break;
                case "Solana":
                    var Solana=new Solana_wallet(SolanaFungibleAssets);
                    SolanaWallets.Add(Solana);
                    Wallets.Add(Solana);
                    break;
            }
        }
        public static void FungibleTransaction(string adressOfWalletReceiving, string adressOfWalletSending, string assetId, string amoutOfAsset)
        {
            var walletA=Wallets.Find(item=> item.Adress == Guid.Parse(adressOfWalletReceiving));
            var walletB=Wallets.Find(item=> item.Adress == Guid.Parse(adressOfWalletSending));
            var asset = FungibleAssets.Find(item=>item.Adress==Guid.Parse(assetId));
            var newTransaction=new Fungible_asset_transaction(
                    DateTime.Now, 
                    Guid.Parse(adressOfWalletSending), 
                    Guid.Parse(adressOfWalletReceiving), 
                    walletA.GetValue(), 
                    (walletA.GetValue()-asset.Value*Decimal.Parse(amoutOfAsset)), 
                    walletB.GetValue(), 
                    (walletB.GetValue()+asset.Value*Decimal.Parse(amoutOfAsset)),
                    Decimal.Parse(amoutOfAsset));
            if (walletA.AdressesOfSuportedAssets.Contains(Guid.Parse(assetId)) || walletB.AdressesOfSuportedAssets.Contains(Guid.Parse(assetId))){
                FungibleTransactions.Add(newTransaction);
                AllTransactions.Add(newTransaction);
                walletA.AddTransaction(asset.Adress, Decimal.Parse(amoutOfAsset));
                walletB.AddTransaction(asset.Adress,  -1*Decimal.Parse(amoutOfAsset));

            }
            else
            {
                Console.WriteLine("Novčanici ne podržavaju taj asset");
            }
            asset.ChangeValue();
            
        }
        public static void NonFungibleTransaction(string adressOfWalletReceiving, string adressOfWalletSending, string assetId)
        {
            var walletA=Wallets.Find(item=> item.Adress == Guid.Parse(adressOfWalletReceiving));
            var walletB=Wallets.Find(item=> item.Adress == Guid.Parse(adressOfWalletSending));
            var asset=Storage.NonFungibleAssets.Find(item=> item.Adress==Guid.Parse(assetId));
            var fungible=Storage.FungibleAssets.Find(item=> item.Adress==asset.AdressOfFungibleAssetOfValue);
            var newTransaction=new Non_fungible_asset_transaction(DateTime.Now, Guid.Parse(adressOfWalletSending), Guid.Parse(adressOfWalletReceiving), (asset.Value*fungible.Value));

            NonFungibleTransactions.Add(newTransaction);
            fungible.ChangeValue();
                walletA.AddTransaction(newTransaction.Id, fungible.Value);
                walletB.AddTransaction(newTransaction.Id,  -1*fungible.Value);
        }
    }
}
