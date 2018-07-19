using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide18_20
{
    // Slide 18
    public class AddClass_Binary
    {
        public int val;

        public static AddClass_Binary operator +(AddClass_Binary op1, AddClass_Binary op2)
        {
            AddClass_Binary returnVal = new AddClass_Binary();
            returnVal.val = op1.val + op2.val;

            return returnVal;
        }
    }
}
