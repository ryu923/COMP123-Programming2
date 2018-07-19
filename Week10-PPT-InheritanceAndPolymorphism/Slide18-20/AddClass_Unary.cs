using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide18_20
{
    // Slide 19
    public class AddClass_Unary
    {
        public int val;

        public static AddClass_Unary operator +(AddClass_Unary op1, AddClass_Unary op2)
        {
            AddClass_Unary returnVal = new AddClass_Unary();

            returnVal.val = op1.val + op2.val;

            return returnVal;
        }

        public static AddClass_Unary operator -(AddClass_Unary op1)
        {
            AddClass_Unary returnVal = new AddClass_Unary();

            returnVal.val = -op1.val;

            return returnVal;
        }
    }
}
