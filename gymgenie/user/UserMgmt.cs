using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GymGenie.user
{
    class UserMgmt
    {
        private string _userList = "userList.bin";
        private IFormatter _bf;
        private Stream _s;
        public List<User> Users { get; set; }

        public UserMgmt()
        {
            // if userList exists, load the file and store into list.
            _bf = new BinaryFormatter();
            if (File.Exists(_userList))
            {
                _s = new FileStream(_userList, FileMode.Open, FileAccess.Read, FileShare.Read);
                Users = (List<User>)_bf.Deserialize(_s);
                _s.Close();
            }
            // if not, it creates new List and add sample accounts
            else
            {
                Users = new List<User>();
                Users.Add(new Admin("Admin K", "0000", "admin@gmail.com"));
                Users.Add(new Trainer("Trainer S", "0000", "trainer@gmail.com"));
                Users.Add(new Customer("Customer A", "0000", "customer@gmail.com"));
            }
        }

        public int Size()
        {
            return Users.Count;
        }

        public bool AddUser(string name, string password, string email)
        {
            User newUser = new Customer(name, password, email);

            // Check the user and if it exists, return false
            foreach (User user in Users)
            {
                if (user.Equals(newUser))
                {
                    Console.WriteLine("The email already exists.");
                    return false;
                }
            }

            // Save the user list to file and return true
            Users.Add(newUser);
            _s = new FileStream("userList.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            _bf.Serialize(_s, Users);
            _s.Close();

            return true;
        }

        public User Login(string email, string pass)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    if (user.Password == pass)
                    {
                        return user;
                    }
                }
            }
            Console.WriteLine("Email or Password are not invalid.");
            return null;
        }

        public void PringUserList()
        {
            Console.WriteLine($"|{"Id",-3}|{"Role",-4}|{"        Name",-20}|{"             Email",-30}|M|");
            Console.WriteLine("===============================================================");
            foreach (User user in Users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
