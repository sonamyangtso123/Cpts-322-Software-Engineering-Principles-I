using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    [Serializable]
    class Customer : _User
    {
        private bool _isMember;

        public Customer(int id, string name, string email, string password) : base(id, name, email, password)
        {
            Role = 2;
            _isMember = false;
        }

        public override string ToString()
        {
            string res = base.ToString();
            if (_isMember)
            {
                res = res + "o|";
            }
            else
            {
                res = res + "x|";
            }
            return res;
        }

        public string getMember()
        {
            if (_isMember)
            {
                return "o";
            }
            else
            {
                return "x";
            }
        }
    }
}
