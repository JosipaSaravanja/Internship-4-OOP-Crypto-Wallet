using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Assets
{
    public class Non_Fungible_asset : Asset
    {
        public Guid AdressOfFungibleAssetOfValue { get; }
        public Non_Fungible_asset(string name, Decimal value, Guid adressOfFungibleAssetOfValue) : base(name, value)
        {
            AdressOfFungibleAssetOfValue = adressOfFungibleAssetOfValue;
        }
    }
}
