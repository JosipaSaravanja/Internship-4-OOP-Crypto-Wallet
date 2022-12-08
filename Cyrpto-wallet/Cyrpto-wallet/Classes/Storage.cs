using Cyrpto_wallet.Classes.Assets;
using Cyrpto_wallet.Classes.Wallets;
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

        public static List<Fungible_asset> FungibleAssets { get; private set; } = new List<Fungible_asset>();
        public static List<Non_Fungible_asset> NonFungibleAssets { get; private set; } = new List<Non_Fungible_asset>();
        //dodati još listu/e transakcija
        //dodati stvarne informacije
        static Storage()
        {
            BitcoinWallets.Add(new Bitcoin_wallet());
            BitcoinWallets.Add(new Bitcoin_wallet());
            BitcoinWallets.Add(new Bitcoin_wallet());
            EthereumWallets.Add(new Ethereum_wallet());
            EthereumWallets.Add(new Ethereum_wallet());
            EthereumWallets.Add(new Ethereum_wallet());
            SolanaWallets.Add(new Solana_wallet());
            SolanaWallets.Add(new Solana_wallet());
            SolanaWallets.Add(new Solana_wallet());

            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));
            FungibleAssets.Add(new Fungible_asset(" ", 0, ""));

            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));
            NonFungibleAssets.Add(new Non_Fungible_asset("", 0, FungibleAssets[0].Adress));

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
                    var Bitcoin=new Bitcoin_wallet();
                    BitcoinWallets.Add(Bitcoin);
                    Wallets.Add(Bitcoin);
                    break;
                case "Ethereum":
                    var Ethereum=new Ethereum_wallet();
                    EthereumWallets.Add(Ethereum);
                    Wallets.Add(Ethereum);
                    break;
                case "Solana":
                    var Solana=new Solana_wallet();
                    SolanaWallets.Add(Solana);
                    Wallets.Add(Solana);
                    break;

            }
        }
    }
}
