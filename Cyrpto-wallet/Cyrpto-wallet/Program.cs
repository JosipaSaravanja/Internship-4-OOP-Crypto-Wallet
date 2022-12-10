using Cyrpto_wallet.Classes.Wallets;
using Cyrpto_wallet.Classes;
using Cyrpto_wallet.Classes.Assets;
using Cyrpto_wallet.Classes.Transaction;

var loop = true;
string choice;
do
{
    Console.Clear();
    Console.WriteLine("1 - Kreiraj walelt \n" +
                      "2 - Pristupi walletu \n" +
                      "0 - Izlaz iz aplikacija");
    choice = Console.ReadLine();
    Console.Clear();
    switch (choice)
    {
        case "0":
            if (Confirm("Želite li uistinu kreirati Bicoin wallet? (Da/Ne)"))
                loop = false;
            break;
        case "1":
            CreateWallet();
            break;
        case "2":
            AccessWallet();
            break;
        default:
            IncorrectEntry();
            break;
    }
} while (loop);
bool Confirm(string str)
{
    Console.WriteLine(str);
    var choice = Console.ReadLine();
    return choice == "Da";
}
void IncorrectEntry()
{
    Console.WriteLine("Unjeli ste nepostojeću opciju. \nPritisnite enter za povratak na glavni izbornik.");
    Console.ReadLine();
}
void CreateWallet()
{
    Console.WriteLine("1 - Bitcoin wallet\n" +
                      "2 - Ethereum wallet\n" +
                      "3 - Solana wallet\n" +
                      "0 - Povratak na početni izbornik");
    choice=Console.ReadLine();
    switch (choice)
    {
        case "0":
            break;
        case "1":
            if (!Confirm("Želite li uistinu kreirati Bicoin wallet? (Da/Ne)"))
            {break;}
            Storage.AddWallet("Bitcoin");
            break;
        case "2":
            if (!Confirm("Želite li uistinu kreirati Ethereum wallet? (Da/Ne)"))
            {break;}
            Storage.AddWallet("Ethereum");
            break;
        case "3":
            if (!Confirm("Želite li uistinu kreirati Solana wallet? (Da/Ne)"))
            {break;}
            Storage.AddWallet("Solana");
            break;
        default:
            IncorrectEntry();
            break;
    }
}
void AccessWallet()
{
    string adress;
    Console.WriteLine("1 - Pristupi walletu \n0 - Povratak na početni izbornik");
    choice = Console.ReadLine();
    Console.Clear();
    switch (choice)
    {
        case "0":
            break;
        case "1":
            Console.Clear();
            foreach(var wallet in Storage.Wallets)
            {
                wallet.PrintWallet();
            }
            Console.WriteLine("Unesite adresu walelta:");
            adress=Console.ReadLine();
            Guid a;
            if(!Guid.TryParse(adress, out a )) { 
                IncorrectEntry();
                break;
            }
            Console.WriteLine("1 - Portofolio \n2 - Transfer \n3 - Povijest transakcija \n0 - Povratak na inicijalni menu");
            choice=Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if(Storage.Wallets.FindIndex(item=> item.Adress == Guid.Parse(adress))!=-1 && Guid.TryParse(adress, out a))
                    Storage.Wallets.Find(item=> item.Adress == Guid.Parse(adress)).PortofolioPrint();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Unesite adresu walleta kojem šalje asset:");
                    string adressOfWalletReceiving=Console.ReadLine();//provjeri je li uopce guid
                    if(!Guid.TryParse(adressOfWalletReceiving, out a )|| Storage.Wallets.FindIndex(item=> item.Adress == Guid.Parse(adressOfWalletReceiving))==-1)
                    {
                        IncorrectEntry();
                        break;
                    }

                    Console.WriteLine("Unesite adresu walleta koji šalje asset:");
                    string adressOfWalletSending=Console.ReadLine(); //provjeri je li uopce guid
                    if(!Guid.TryParse(adressOfWalletSending, out a )|| Storage.Wallets.FindIndex(item=> item.Adress == Guid.Parse(adressOfWalletSending))==-1)
                    {
                        IncorrectEntry();
                        break;
                    }

                    Console.WriteLine("Uneiste Id asseta (valjda adresu)");
                    string assetId=Console.ReadLine(); //provjeri je li uopce guid
                    if(!Guid.TryParse(assetId, out a )|| (Storage.FungibleAssets.FindIndex(item=> item.Adress == Guid.Parse(assetId))==-1 && Storage.NonFungibleAssets.FindIndex(item=> item.Adress == Guid.Parse(assetId)) == -1))
                    {
                        IncorrectEntry();
                        break;
                    }

                    if(Storage.FungibleAssets.FindIndex(item=> item.Adress == Guid.Parse(assetId))!=-1)
                    { 
                        Decimal b;
                        Console.WriteLine("Unesite količinu fungible asseta");
                        string amoutOfAsset=Console.ReadLine();
                        if(!Decimal.TryParse(amoutOfAsset, out b))
                        {
                            break;
                        }
                        Storage.FungibleTransaction( adressOfWalletReceiving,  adressOfWalletSending,  assetId,  amoutOfAsset);
                            
                    }else if(Storage.NonFungibleAssets.FindIndex(item=> item.Adress == Guid.Parse(assetId))!=-1)
                    {
                        Storage.NonFungibleTransaction(adressOfWalletReceiving, adressOfWalletSending, assetId);
                    }
                    else
                    {
                        IncorrectEntry();
                    }
                          
                    break;
                case "3":
                    choice=Console.ReadLine();
                    if(!Guid.TryParse(choice, out a ) || Storage.AllTransactions.FindIndex(item => item.Id == Guid.Parse(choice)) == -1)//provjeri sa cw
                        break;
                    if (!Confirm("Želite li uistinu opozvati ovu transakciju (Da/Ne)?"))
                        break;
                    CancelTransaction(choice);
                    break;
                default:
                    IncorrectEntry();
                    break;
            }
            break;
        default:
            IncorrectEntry();
            break;
    }

}

void CancelTransaction(string choice)
{
    var transaction=Storage.AllTransactions.Find(item=>item.Id==Guid.Parse(choice));
    if ((transaction.Date-DateTime.Now).TotalSeconds>45) { 
        Console.WriteLine("Proošlo je više od 45s od transakcije. Ne možete je opozvati");
    }
    else
    {
        transaction.Revoke();
            if (Storage.FungibleTransactions.FindIndex(item => item.Id == Guid.Parse(choice))!= -1){
                Storage.FungibleTransactions.Find(item => item.Id == Guid.Parse(choice)).Revoke();
            } else { 
                Storage.NonFungibleTransactions.Find(item => item.Id == Guid.Parse(choice)).Revoke();
            }
    }}
