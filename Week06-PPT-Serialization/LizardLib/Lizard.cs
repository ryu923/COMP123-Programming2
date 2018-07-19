using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardLib
{
    // Jason Serialization 8: Create [LizardLib] library
    public class Lizard
    {
        // FIELDS
        public string Type;
        public int Number;
        public bool Healthy;

        // ToString() METHODS
        public override string ToString()
        {
            return string.Format("{0,-20} {1} {2}", Type, Number, Healthy? "(Healthy)" : "(Sick)");
        }

        // METHOD
        public static List<Lizard> GetLizard()
        {
            return new List<Lizard>()
            {
                new Lizard() { Type = "Leopard gecko",                  Number = 3, Healthy = true },
                new Lizard() { Type = "Bearded dragon",                 Number = 1, Healthy = true },
                new Lizard() { Type = "Crested gecko",                  Number = 4, Healthy = false },
                new Lizard() { Type = "Argentine tegu",                 Number = 4, Healthy = true },
                new Lizard() { Type = "Thorny devil",                   Number = 4, Healthy = true },
                new Lizard() { Type = "Casquehead lizard",              Number = 4, Healthy = true },
                new Lizard() { Type = "Panther chameleon",              Number = 6, Healthy = false },
                new Lizard() { Type = "Veiled chameleon",               Number = 4, Healthy = true },
                new Lizard() { Type = "Water monitor",                  Number = 4, Healthy = false },
                new Lizard() { Type = "Komodo dragon",                  Number = 4, Healthy = true },
                new Lizard() { Type = "Green iguana",                   Number = 4, Healthy = false },
                new Lizard() { Type = "Blotched blue-tongue lizard",    Number = 4, Healthy = true },
                new Lizard() { Type = "Gila monster",                   Number = 4, Healthy = true }
            };
        }

        // Add reference to the [Slide10-11-Json] - [References] *
    }
}
