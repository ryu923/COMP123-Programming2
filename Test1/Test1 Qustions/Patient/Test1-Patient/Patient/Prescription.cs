using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient
{
    // Prescription class: 30 Marks
    class Prescription
    {
        // FIELDS
        private static int CURRENT_NUMBER = 100; // 3 Marks
        public readonly string ID; // 2 Marks

        // PROSPERITIES
        public bool ForRepeat { get; private set; } // 2 Marks
        public string Doctor { get; private set; } // 2 Marks
        public string Name { get; private set; } // 2 Marks
        public int Length { get; private set; } // 2 Marks

        // CONSTRUCTOR
        public Prescription(string doctor, string name, int length, bool forRepeat = false) // 10 Marks
        {
            Doctor = doctor;
            Name = name;
            Length = length;
            ForRepeat = forRepeat;

            ID = Convert.ToString(CURRENT_NUMBER);
            CURRENT_NUMBER++;
        }

        // METHODS
        public override string ToString() // 7 Marks
        {
            return string.Format("#{0} {1} prescribed by {2} for {3}days {4}", ID, Name, Doctor, Length, ForRepeat? "(Repeat)" : "(No repeat)");
        }
    }
}
