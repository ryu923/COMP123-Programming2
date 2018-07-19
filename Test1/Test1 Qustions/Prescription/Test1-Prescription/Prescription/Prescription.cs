using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prescription
{
    // 3. Prescription class: 40 Marks
    class Prescription
    {
        // FIELDS
        private List<Drug> drugs = new List<Drug>() { }; // 3 Marks

        // PROPERTIES
        public string Name { get; private set; } // 2 Marks
        public bool ForRepeat { get; private set; } // 2 Marks
        public string Address { get; private set; } // 2 Marks

        // CONSTRUCTOR
        public Prescription(string name, string address, bool forRepeat = false) // 3 Marks
        {
            Name = name;
            Address = address;
            ForRepeat = forRepeat;
        }

        // METHODS
        public void InsertDrug(Drug drug) // 3 Marks *
        {
            drugs.Add(drug);
        }

        public void RemoveDrug(string din) // 10 Marks ** - 5
        {
            bool checkDin = true;

            for (int i = 0; i < drugs.Count; i++)
            {
                if (drugs[i].Din.Contains(din))
                {
                    drugs.RemoveAt(i);
                    checkDin = false;
                }
            }

            if(checkDin)
            throw new Exception("Error: drug " + din + " not be found");
        }

        private string GetDrugs() // 8 Marks * - 4
        {
            string drugList = "";

            foreach (Drug x in drugs)
            {
                drugList += " " + x + "\n";
            }

            return drugList;
        }

        public override string ToString() // 6 Marks *
        {
            return String.Format(Name + ", " + Address + "\nList of drugs: \n" + GetDrugs());
        }
    }
}
