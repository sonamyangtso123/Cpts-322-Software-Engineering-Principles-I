using GymGenie.user;
using System;

namespace GymGenie
{
    class Program
    {
        public static UserMgmt UM = new UserMgmt();

        public static void Main(string[] args)
        {
            bool isQuit = false;
            while (!isQuit)
            {
                string res = MainMenu();
                User loggedinUser = null;
                switch (res)
                {
                    case "1":
                        loggedinUser = LoginMenu();
                        break;
                    case "2":
                        loggedinUser = RegisterMenu();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Thanks for using Gym Genie.");
                        isQuit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Type wrong number.");
                        break;
                }

                if(loggedinUser != null)
                {
                    switch (loggedinUser.Role)
                    {
                        case 0:
                            AdminMenu(loggedinUser);
                            break;
                        case 1:
                            TrainermMenu();
                            break;
                        case 2:
                            CustomerMenu();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        // ============================================================================
        // need to implement admin dashboard
        public static void AdminMenu(User admin)
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Admin Page: " + admin.Name);
            string stop = Console.ReadLine();
        }

        // need to implement trainer dashboard
        public static void TrainermMenu() { }

        // need to implement customer dashboard
        public static void CustomerMenu() { }
        // ============================================================================

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
                    Console.Clear();
                    Console.WriteLine($"Welcomem {loggedInUser.Name}");
                    return loggedInUser;
                }
            }
            Console.Clear();
            Console.WriteLine("Fail to Login.");
            return null;
        }


        public static User RegisterMenu()
        {
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

                bool res = UM.AddUser(nm, pw, em);
                if (res)
                {
                    Console.WriteLine("Welcome, ", nm);
                    return UM.Login(em, pw);
                }
            }
            Console.Clear();
            Console.WriteLine("Cannot create new account.");
            Console.WriteLine("Go back to main menu.");
            return null;
        }

        public static string MainMenu()
        {
            Console.Clear();
            UM.PrintUserList();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Gym Management App - Gym Genie");
            Console.WriteLine("1. login");
            Console.WriteLine("2. register");
            Console.WriteLine("3. Exit");
            Console.Write(">");
            string res = Console.ReadLine();
            return res;
        }
    }
}