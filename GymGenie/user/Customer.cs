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

        public void ShowOptionsForCustomer()
        {
            string userInput;
            int res;
            Console.WriteLine("1.View BMI Report\n");
            Console.WriteLine("2.Add Training Session\n");
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
            }
        }

        public void ViewReport() 
        {
            Trainer trainer = new Trainer();
            trainer.CreateBMIReport();
        }

        public void CustomerAddTraining()
        {
            Trainer trainer = new Trainer();
            trainer.ShowTrainingSession();
        }
    }
}
