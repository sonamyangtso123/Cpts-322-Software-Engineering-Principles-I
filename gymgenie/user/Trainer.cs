using System;

namespace GymGenie.user
{
    [Serializable]
    class Trainer : User
    {
        public Trainer(int id, string name, string password, string email) : base(id, name, password, email)
        {
            Role = 1;
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }
    }

}