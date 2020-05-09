using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    [Serializable]
    class Customer : _User
    {
        public bool IsMember { get; set; }

        public Customer(int id, string name, string email, string password) : base(id, name, email, password)
        {
            Role = 2;
            IsMember = false;
        }

        public override string ToString()
        {
            string res = base.ToString();
            if (IsMember)
            {
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
