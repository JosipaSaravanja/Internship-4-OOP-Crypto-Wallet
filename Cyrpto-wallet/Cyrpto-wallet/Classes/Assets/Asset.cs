using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cyrpto_wallet.Classes.Assets
{
    public class Asset
    {
        public Guid Adress { get; }
        public string Name { get; }
        public Decimal Value { get; private set; }
        public Asset(string name, Decimal value)
        {
            Adress = Guid.NewGuid();
            Name = name;
            Value = value;
        }
    }
}
