using System;
using System.Collections.Generic;
using System.Text;

namespace GymGenie.user
{
    [Serializable]
    class Customer : User
    {
        private bool _isMember;

        public Customer() 
        { 
        
        }
        public Customer(int id, string name, string password, string email) : base(id, name, password, email)
        {
            Role = 2;
            _isMember = false;
        }
        
        public override string ToString()
        {
            string res = base.ToString();
            if (_isMember) {
                res = res + "o|";
            }
            else
            {
                res = res + "x|";
            }
            return res;
        }

        /// <summary>
        /// This function show options for customer.
        /// </summary>
        public void ShowOptionsForCustomer()
        {
            string userInput;
            int res;
            do
            {
                Console.WriteLine("1.View BMI Report\n");
                Console.WriteLine("2.Add Training Session\n");
                Console.WriteLine("3.Log out\n");
                userInput = Console.ReadLine();
                res = Convert.ToInt32(userInput);
                switch (res)
                {
                    case 1:
                        ViewReport();
                        break;
                    case 2:
                        CustomerAddTraining();
                        break;
                    case 3:
                        Program.MainMenu();
                        break;
                }
            }while (res != 3) ;
        }

        /// <summary>
        /// Helps the customer to open the BMI report.
        /// </summary>
        public void ViewReport() 
        {
            Trainer trainer = new Trainer();
            trainer.CreateBMIReport();
        }

        /// <summary>
        /// Helps the customer to add training.
        /// </summary>
        public void CustomerAddTraining()
        {
            Trainer trainer = new Trainer();
            trainer.ShowTrainingSession();
            int res = 0;
            do
            {
                Console.WriteLine("Is this the correct session you want?\n");
                Console.WriteLine("1.Confirm\n" +
                                  "2.Cancel\n");
                string userInput = Console.ReadLine();
                res = Convert.ToInt32(userInput);
                switch (res)
                {
                    case 1:
                        Console.WriteLine("Saved.\n");
                        ShowOptionsForCustomer();
                        break;
                    case 2:
                        Console.WriteLine("Canceled\n");
                        ShowOptionsForCustomer();
                        break;
                }
            } while (res != 2);
        }
    }
}
