using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    [Serializable]
    public abstract class _User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // 0: admin, 1:trainer, 2:customer;
        public int Role { get; set; }

        protected _User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public bool Equals(_User obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (Email == obj.Email)
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
            return string.Format($"|{Id,-3}|{ Role,-4}|{Name,-20}|{Email,-30}|");
        }
    }
}
