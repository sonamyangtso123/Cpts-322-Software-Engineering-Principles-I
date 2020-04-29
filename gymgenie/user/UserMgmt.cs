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
        private int _id;
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
                _id = (Users[Users.Count-1].Id)+1;
                _s.Close();
            }
            // if not, it creates new List and add sample accounts
            else
            {
                Users = new List<User>();
                Users.Add(new Admin(0, "Admin K", "0000", "admin@gmail.com"));
                Users.Add(new Trainer(1, "Trainer S", "0000", "trainer@gmail.com"));
                Users.Add(new Customer(2, "Customer A", "0000", "customer@gmail.com"));
                _id = 3;
            }
        }

        public int Size()
        {
            // retrun number of account
            return Users.Count;
        }

        public bool AddUser(string name, string password, string email)
        {   
            // check empty entires
            if(name.Length == 0 || password.Length == 0 || email.Length == 0)
            {
                Console.WriteLine("Empty is not allowed");
                return false;
            }

            // create user object
            User newUser = new Customer(_id, name, password, email);

            // Check the user and if it exists, return false
            foreach (User user in Users)
            {
                if (user.Equals(newUser))
                {
                    Console.WriteLine("The email already exists.");
                    return false;
                }
            }

            // then, add user into list and save the user list file
            Users.Add(newUser);
            _id++;
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

        public void PrintUserList()
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
