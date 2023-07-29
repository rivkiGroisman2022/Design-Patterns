using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class Client
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool HaveAClub { get; set; }
        public Client(string name, string phoneNumber, bool haveAClub)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            HaveAClub = haveAClub;
        }
    }
}
