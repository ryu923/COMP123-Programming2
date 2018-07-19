using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide07_10
{
    // Slide 7
    public interface IPersistable
    {
        object Read(string id);
        bool Save(object o);
        bool HasChanges
        {
            get;
            set;
        }
    }
}
