using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide14
{
    public class MyClass
    {
        // FIELD (Instance Variables)
        // Private Accessibility Modifier
        private int privateNumber;

        // Public Accessibility Modifier
        public int publicNumber;

        // PROPERTIES for Private Accessibility Modifier
        public int PrivateNumber
        {
            get
            {
                return privateNumber;
            }
            set
            {
                privateNumber = value;
            }
        }

        // CONSTRICTOR
        public MyClass(int privateNum, int publicNum)
        {
            this.privateNumber = privateNum;
            this.publicNumber = publicNum;
        }

        // Display Method
        public void DisplayNumbers()
        {
            Console.WriteLine("Private Number: {0}", PrivateNumber);
            Console.WriteLine("Public Number: {0}", publicNumber);
        }
    }
}
