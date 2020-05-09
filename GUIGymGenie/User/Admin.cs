using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    [Serializable]
    class Admin : _User
    {
        public Admin(int id, string name, string email, string password) : base(id, name, email, password)
        {
            Role = 0;
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }
    }
}
