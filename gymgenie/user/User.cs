using System;
using System.Collections.Generic;
using System.Text;

namespace GymGenie.user
{
    [Serializable]
    abstract class User
    {
        private static int _idSeed = 0;

        public string Id { get; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }

        protected User(string name, string password, string email)
        {
            Id = _idSeed.ToString();
            _idSeed++;
            Name = name;
            Password = password;
            Email = email;
        }

        public bool Equals(User obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(Email == obj.Email)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format($"|{Id,-3}|{ Role,-4}|{Name,-20}|{Email, -30}|");
        }
    }

}