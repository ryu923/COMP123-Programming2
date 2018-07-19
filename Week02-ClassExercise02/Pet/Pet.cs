using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Pet
    {
        // FIELDS (INSTANCE VARIABLES)
        private string name;
        private string owner;
        private int age;
        private string description;
        private bool isHouseTrained;

        // CONSTRUCTOR
        public Pet(string name, int age, string description)
        {
            this.name = name;
            this.age = age;
            this.description = description;

            this.owner = "No one";
            this.isHouseTrained = false;
        }

        // ToString Method
        public override string ToString()
        {
            return string.Format("\n[Pet Information]" +
                                 "\n- Name: " + name +
                                 "\n- Owner: " + owner +
                                 "\n- Age: " + age +
                                 "\n- Description: " + description +
                                 "\n- House Trained: " + isHouseTrained);
        }

        // PUBLIC Method
        // This Method is needed for modifying owner
        public void modifyOwner(string ownerName)
        {
            this.owner = ownerName;
        }

        // This Method is needed for picking particular owner up.
        public string choiceOwner()
        {
            return owner;
        }
    }
}
