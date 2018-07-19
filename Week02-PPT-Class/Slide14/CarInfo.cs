using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide14
{
    // [CarInfo] class inherit from [Info] class
    public class CarInfo : Info
    {
        // PROPERTIES from [Info] class
        public string GetName()
        {
            return Name;
        }
        public void SetName(string newName)
        {
            Name = newName;
        }

        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string newAddress)
        {
            Address = newAddress;
        }

        public string GetType()
        {
            return Type;
        }
        public void SetType(string newType)
        {
            Type = newType;
        }

        // CONSTRUCTOR
        public CarInfo(string name, string address, string type)
        {
            this.Name = name;
            this.Address = address;
            this.Type = type;
        }

        // Display Method
        public void DisplayCarInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Type: {0}", Type);
        }
    }
}
