using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class ContactGroup : List<Contact>
    {
        public string GroupName { get; private set; }

        public ContactGroup(string firstInitial, List<Contact> contacts) : base(contacts)
        {
            GroupName = firstInitial;
        }
    }
}
