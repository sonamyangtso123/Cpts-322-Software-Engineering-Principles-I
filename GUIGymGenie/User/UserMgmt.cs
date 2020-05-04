using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace User
{
    public class UserMgmt
    {
        private int _id;
        private string _userList = "userList.bin";
        private IFormatter _bf;
        private Stream _s;
        private List<_User> users;

        public UserMgmt()
        {
            // if userList exists, load the file and store into list.
            _bf = new BinaryFormatter();
            if (File.Exists(_userList))
            {
                _s = new FileStream(_userList, FileMode.Open, FileAccess.Read, FileShare.Read);
                users = (List<_User>)_bf.Deserialize(_s);
                _id = (users[users.Count - 1].Id) + 1;
                _s.Close();
            }
            // if not, it creates new List and add sample accounts
            else
            {
                users = new List<_User>();
                users.Add(new Admin(0, "Admin K", "admin@gmail.com", "0000"));
                users.Add(new Trainer(1, "Jane", "jane@gmail.com", "0000"));
                users.Add(new Trainer(2, "Andrew", "andrew@gmail.com", "0000"));
                users.Add(new Trainer(3, "Marco", "marco@gmail.com", "0000"));
                users.Add(new Trainer(4, "Sindy", "sindy@gmail.com", "0000"));
  
                _id = 5;
            }
        }

        public int Size()
        {
            // retrun number of account
            return users.Count;
        }

        public bool AddUser(string name, string email, string password)
        {
            // check empty entires
            if (name.Length == 0 || email.Length == 0 || password.Length == 0)
            {
                Console.WriteLine("Empty is not allowed");
                return false;
            }

            // create user object
            _User newUser = new Customer(_id, name, email, password);

            // Check the user and if it exists, return false
            foreach (_User user in users)
            {
                if (user.Equals(newUser))
                {
                    Console.WriteLine("The email already exists.");
                    return false;
                }
            }

            // then, add user into list and save the user list file
            users.Add(newUser);
            _id++;
            Save();

            return true;
        }

        public void Save()
        {
            _s = new FileStream(_userList, FileMode.Create, FileAccess.Write, FileShare.None);
            _bf.Serialize(_s, users);
            _s.Close();
        }

        public _User Login (string email, string pass)
        {
            foreach (_User user in users)
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

        public _User findById(int id)
        {
            foreach(_User user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            Console.WriteLine("Cannot find user");
            return null;
        }

        public void SetMember(int id)
        {
            foreach(_User user in users)
            {
                if(user.Id == id && user.Role == 2)
                {
                    if(((Customer)user).IsMember){
                        ((Customer)user).IsMember = false;
                    }
                    else
                    {
                        ((Customer)user).IsMember = true;
                    }
                    Save();

                }
            }
        }
        public bool GetMemberStatus(int id)
        {
            foreach (_User user in users)
            {
                if (user.Id == id && user.Role == 2)
                {
                    return ((Customer)user).IsMember;
                }
            }   
                    
            return false;
        }

        public List<_User> GetAllMember()
        {
            List<_User> res = new List<_User>();
            foreach(_User user in users)
            {
                if(user.Role == 2 && ((Customer)user).IsMember)
                {
                    res.Add(user);
                }
            }
            return res;
        }

        public int[] getStatistics()
        {
            int numOfAdmin = 0;
            int numOfTrainer = 0;
            int numOfCustomer = 0;
            int numOfMember = 0;

            foreach(_User user in users)
            {
                switch (user.Role)
                {
                    case 0:
                        numOfAdmin++;
                        break;
                    case 1:
                        numOfTrainer++;
                        break;
                    case 2:
                        numOfCustomer++;
                        if (((Customer)user).IsMember)
                        {
                            numOfMember++;
                        }
                        break;
                }
            }

            int[] resStatistic = { numOfAdmin, numOfTrainer, numOfCustomer, numOfMember };

            return resStatistic;
        }


        public void PrintUserList()
        {
            Console.WriteLine($"|{"Id",-3}|{"Role",-4}|{"        Name",-20}|{"             Email",-30}|M|");
            Console.WriteLine("===============================================================");
            foreach (_User user in users)
            {
                Console.WriteLine(user);
            }
        }

        public List<string[]> outputDataGrid()
        {
            List<string[]> res = new List<string[]>(); ;

            foreach(_User user in users){
                string sRole = null;
                string memberState = "";
                switch (user.Role)
                {
                    case 0:
                        sRole = "Admin";
                        break;
                    case 1:
                        sRole = "Trainer";
                        break;
                    case 2:
                        sRole = "Customer";
                        if (((Customer)user).IsMember)
                        {
                            memberState = "o";
                        }
                        else
                        {
                            memberState = "x";
                        }
                        break;
                }
                string[] row = { "" + user.Id, sRole, user.Name, user.Email, memberState };
                res.Add(row);
            }

            return res;
        } 
    }
}
