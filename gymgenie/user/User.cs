using System;
using System.Collections.Generic;
using System.Text;

namespace GymGenie.user
{
    [Serializable]
    abstract class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        // 0: admin, 1:trainer, 2:customer;
        public int Role { get; set; }

        protected User(int id, string name, string password, string email)
        {
            Id = id;
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