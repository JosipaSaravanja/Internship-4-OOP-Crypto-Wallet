using Cyrpto_wallet.Classes.Wallets;
using Cyrpto_wallet.Classes;

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
            {
                break;
            }
            Storage.AddWallet("Bitcoin");
            break;
        case "2":
            if (!Confirm("Želite li uistinu kreirati Ethereum wallet? (Da/Ne)"))
            {
                break;
            }
            Storage.AddWallet("Ethereum");
            break;
        case "3":
            if (!Confirm("Želite li uistinu kreirati Solana wallet? (Da/Ne)"))
            {
                break;
            }
            Storage.AddWallet("Solana");
            break;
        default:
            IncorrectEntry();
            break;
    }
    
}

void AccessWallet()
{
    Console.WriteLine("1 - Pristupi walletu");
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
            Console.ReadLine();
            break;
        default:
            IncorrectEntry();
            break;
    }

}