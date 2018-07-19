using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Pet
    {
        // FIELDS
        private string name;
        private string owner;
        private int age;
        private string description;
        private bool isHouseTrained;

        // PROPERTIES
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        // CONSTRUCTOR
        public Pet(string name, int age, string description)
        {
            this.name = name;
            this.age = age;
            this.description = description;

            this.owner = "No one";
            this.isHouseTrained = false;
        }

        // METHODS
        public override string ToString()
        {
            return string.Format("[" + name + "]" + "\n" + 
                                 " - Owner: " + owner + "\n" + 
                                 " - Age: " + age + "\n" + 
                                 " - Description: " + description + "\n" +
                                 " - House Trained: " + isHouseTrained + "\n\n");
        }

        // This Method is needed for modifying owner
        public void modifyOwner(string owner)
        {
            this.owner = owner;
        }
    }
}
