using System;

namespace GymGenie.user
{
    [Serializable]
    class Admin : User
    {
        public Admin() 
        { 
        
        }
        public Admin(int id, string name, string password, string email) : base(id, name, password, email)
        {
            Role = 0;
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }

        /// <summary>
        /// This function will let the admin to view the list of users of the program.
        /// </summary>
        public void printList() 
        {
            string userInput;
            int res;
            Console.WriteLine("Do you want to view the list\n");
            Console.WriteLine("1.Yes\n");
            Console.WriteLine ("2.No\n");
            userInput = Console.ReadLine();
            res = Convert.ToInt32(userInput);
            if (res == 1)
            {
                UserMgmt myUser = new UserMgmt();
                myUser.PrintUserList();
            }
            else 
            {
                System.Environment.Exit(0);
            }
        }

    }

}