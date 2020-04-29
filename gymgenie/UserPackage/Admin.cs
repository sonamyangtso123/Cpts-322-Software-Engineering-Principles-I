using System;

namespace GymGenie.UserPackage
{
    [Serializable]
    class Admin : User
    {
        private bool _isAdmin;

        public Admin(string name, string password, string email) : base(name, password, email)
        {
            _isAdmin = true;
        }


    }

}