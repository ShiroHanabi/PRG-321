using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessCopy
{
    public interface IContactable
    {
        string PhoneNumber
        {
            get;
            set;
        }

        string Email
        {
            get;
            set;
        }
    }
}
