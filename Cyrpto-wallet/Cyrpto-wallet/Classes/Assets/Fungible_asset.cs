using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrpto_wallet.Classes.Assets
{
    public class Fungible_asset : Asset
    {
        public string Label { get; }

        public Fungible_asset(string name, Decimal value, string label) : base(name, value)
        {
            Label = label;
        }
    }
}
