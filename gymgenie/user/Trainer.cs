using System;

namespace GymGenie.user
{
    [Serializable]
    class Trainer : User
    {

        public Trainer(string name, string password, string email) : base(name, password, email)
        {
            Role = 1;
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }
    }

}