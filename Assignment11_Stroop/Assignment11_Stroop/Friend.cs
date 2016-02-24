using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_Stroop
{
    class Friend
    {
        // fields
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        // override ToString method
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", FirstName, LastName, PhoneNumber, Month, Day);
        }
    }
}
