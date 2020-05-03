using System;
using System.Collections.Generic;
using System.Text;

namespace GymGenie.user
{
    [Serializable]
    class Customer : User
    {
        private bool _isMember;

        public Customer(int id, string name, string password, string email) : base(id, name, password, email)
        {
            Role = 2;
            _isMember = false;
        }
        
        public override string ToString()
        {
            string res = base.ToString();
            if (_isMember) {
                res = res + "o|";
            }
            else
            {
                res = res + "x|";
            }
            return res;
        }
    }
}
