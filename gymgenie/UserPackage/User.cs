using System;
using System.Collections.Generic;
using System.Text;

namespace GymGenie.UserPackage
{
    [Serializable]
    abstract class User
    {
        private static int _idSeed = 1;

        public string Id { get; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        protected User(string name, string password, string email)
        {
            Id = _idSeed.ToString();
            _idSeed++;
            Name = name;
            Password = password;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return string.Format($"|{Id,-3}|{Name,-20}|{Email, -20}");
        }
    }

}