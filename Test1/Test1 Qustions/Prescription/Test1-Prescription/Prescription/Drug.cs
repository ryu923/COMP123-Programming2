using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prescription
{
    // 2. Drug Class: 23 Marks
    class Drug
    {
        // FIELDS     
        private static int NEXT_NUMBER = 101; // 3 Marks
        public readonly string Din; // 2 Marks

        // PROPERTIES
        public int Dosage { get; private set; } // 2 Marks
        public DrugForm Form { get; private set; } // 2 Marks
        public string Name { get; private set; } // 2 Marks

        // CONSTRUCTOR
        public Drug(string name, int dosage, DrugForm form = DrugForm.Tablet) // 7 Marks *
        {
            Name = name;
            Dosage = dosage;
            Form = form;

            Din = Convert.ToString(NEXT_NUMBER);

            NEXT_NUMBER++;
        }

        // METHODS
        public override string ToString() // 5 Marks
        {
            return string.Format("{0} {1} {2}g ({3})", Din, Name, Dosage, Form);
        }
    }
}
