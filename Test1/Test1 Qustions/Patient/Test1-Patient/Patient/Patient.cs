using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add a namespace
using System.IO;

namespace Patient
{
    // Patient class: 38 Marks
    class Patient
    {
        // FIELDS
        private List<Prescription> prescriptions = new List<Prescription>() { }; // 4 Marks

        // PROPERTIES
        public string Name { get; private set; } // 2 Marks
        public int Yob { get; private set; } // 2 Marks

        // CONSTRUCTORS
        public Patient(string name, int yob) // 3 Marks
        {
            Name = name;
            Yob = yob;
        }

        public void AddPrescription(Prescription prescription) // 3 Marks
        {
            prescriptions.Add(prescription);
        }

        public void RemovePrescription(string id) // 5 Marks
        {
            bool checkId = true;

            for (int i = 0; i < prescriptions.Count(); i++)
            {
                if(prescriptions[i].ID.Contains(id))
                {
                    prescriptions.RemoveAt(i);
                    checkId = false;
                }
            }

            if (checkId)
                throw new Exception("Exception: Prescription " + id + " does not exist");
        }

        private string GetPrescriptions() // 8 Marks
        {
            string prescriptionList = "";

            foreach(Prescription x in prescriptions)
            {
                prescriptionList += " " + x + "\n";
            }

            return prescriptionList;
        }

        public override string ToString() // 4 Marks
        {
            return string.Format(Name + " yob: " + Yob + "\nList of prescription:\n" + GetPrescriptions());
        }

        public void SaveAsText(string filename) // 4 Marks
        {
            TextWriter writer = new StreamWriter(filename);

            for(int i = 0; i < prescriptions.Count; i++)
            {
                writer.WriteLine(prescriptions[i].ToString());
            }

            writer.Close();
        }
    }
}
