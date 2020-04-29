using System;

namespace GymGenie.UserPackage
{
    [Serializable]
    class Trainer : User
    {
        private bool _isTrainer;

        public Trainer(string name, string password, string email) : base(name, password, email)
        {
            this._isTrainer = true;
        }
    }

}