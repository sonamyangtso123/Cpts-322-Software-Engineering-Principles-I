using System;

namespace GymGenie.user
{
    [Serializable]
    class Admin : User
    {
        public Admin(int id, string name, string password, string email) : base(id, name, password, email)
        {
            Role = 0;
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }

    }

}