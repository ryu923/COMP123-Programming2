using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide14
{
    public class MyClassInspector
    {
        // Access to privateNumber in MyClass class
        public void PrintMember(MyClass mc)
        {
            // This should be an error because of private accessibility modifier
            // Console.WriteLine("MyClass = {0}", mc.privateNumber); 

            // This should be possible code because of public accessibility modifier
            Console.WriteLine("MyClass = {0}", mc.publicNumber);
        }
    }
}
