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
        /// This function will show options for the admin.
        /// </summary>
        public void ShowOptionsForAdmin()
        {
            string userInput;
            int res = 0;
            do
            {
                Console.WriteLine("1.View user List\n");
                Console.WriteLine("2.Log out\n");
                userInput = Console.ReadLine();
                res = Convert.ToInt32(userInput);
                switch (res)
                {
                    case 1:
                        PrintList();
                        break;
                    case 2:
                        Program.MainMenu();
                        break;

                }
            } while (res != 2);
        }

        /// <summary>
        /// This function will let the admin to view the list of users of the program.
        /// </summary>
        public void PrintList() 
        {
            UserMgmt myUser = new UserMgmt();
            myUser.PrintUserList(); 
        }
    }

}