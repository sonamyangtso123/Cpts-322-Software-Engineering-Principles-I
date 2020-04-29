using GymGenie.user;
using System;

namespace GymGenie
{
    class Program
    {
        public static UserMgmt UM = new UserMgmt();

        public static void Main(string[] args)
        {
            UM.PringUserList();


            bool isQuit = false;
            string answer;
            while (!isQuit)
            {
                answer = MainMenu();
                User loggedinUser = null;
                switch (answer)
                {
                    case "1":
                        loggedinUser = LoginMenu();
                        break;
                    case "2":
                        RegisterMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Type wrong.");
                        break;
                }

                if (loggedinUser != null)
                {
                    switch (loggedinUser.Role)
                    {
                        case 0:
                            Console.WriteLine("you are admin.");
                            break;
                        case 1:
                            Console.WriteLine("you are trainer.");
                            break;
                        case 2:
                            Console.WriteLine("you are customer.");
                            break;
                    }
                }



                if (answer == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for using Gym Genie.");
                    isQuit = true;
                }
            }


        }


        public static string MainMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Gym Management App - Gym Genie");
            Console.WriteLine("1. login");
            Console.WriteLine("2. register");
            Console.WriteLine("3. Exit");
            Console.Write(">");
            string answer = Console.ReadLine();

            return answer;
        }

        public static void AdminMenu() { }
        public static void TrainermMenu() { }
        public static void CustomerMenu() { }
        public static User LoginMenu()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Login Page");
                Console.Write("Email   : ");
                string em = Console.ReadLine();
                Console.Write("Password: ");
                string pw = Console.ReadLine();

                User loggedInUser = UM.Login(em, pw);

                if (loggedInUser != null)
                {
                    Console.WriteLine($"Welcome {loggedInUser.Name}");
                    return loggedInUser;
                }
            }
            Console.Clear();
            return null;
        }
        public static void RegisterMenu()
        {
            bool res = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Register Page");
                Console.Write("Name    : ");
                string nm = Console.ReadLine();
                Console.Write("Email   : ");
                string em = Console.ReadLine();
                Console.Write("Password: ");
                string pw = Console.ReadLine();

                res = UM.AddUser(nm, pw, em);
                if (res)
                {
                    break;
                }
            }
            if (!res)
            {
                Console.Clear();
                Console.WriteLine("Cannot create new account.");
                Console.WriteLine("Go back to main menu.");
            }
            else
            {
                
            }
        }
    }
}