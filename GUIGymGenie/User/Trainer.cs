using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    [Serializable]
    class Trainer : _User
    {
        public Trainer(int id, string name, string email, string password) : base(id, name, email, password)
        {
            Role = 1;
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }
    }
}
