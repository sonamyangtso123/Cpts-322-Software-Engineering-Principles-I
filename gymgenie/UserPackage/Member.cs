using System;
using System.Collections.Generic;
using System.Text;

namespace GymGenie.UserPackage
{
    [Serializable]
    class Member : User
    {
        public Member(string name, string password, string email) : base(name, password, email)
        {
        }
    }
}
