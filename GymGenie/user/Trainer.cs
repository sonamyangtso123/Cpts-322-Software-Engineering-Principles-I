using System;
namespace GymGenie.user
{
    [Serializable]
    class Trainer : User
    {
        public Trainer() 
        { 
        
        }
        public Trainer(int id, string name, string password, string email) : base(id, name, password, email)
        {
            Role = 1;
        }
        public void ShowOptions()
        {
            string userInput;
            int res;
            Console.WriteLine("1.Create BMI Report\n");
            Console.WriteLine("2.Add Training Session\n");
            userInput = Console.ReadLine();
            res = Convert.ToInt32(userInput);
            switch (res) 
            {
                case 1: CreateBMIReport();
                    break;
                case 2: //Call a function for adding training session
                    break;

            }
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }
        public void CreateBMIReport() 
        {
            //Variable to calculate BMI report
            double calculateBMI = 0.0;
            double weight = 209;
            double heightInInches = 74.4;
            double valu = 703;

            //Calculate the BMI report for a customer.
            Console.WriteLine("BMI equation:BMI = (weight(lb) / height2(in2)) * 703 \n");
            calculateBMI = Convert.ToDouble((weight/Math.Pow(heightInInches,2))*valu);
            Console.WriteLine("Your BMI report is \n" + System.Math.Round(calculateBMI, 2));
            Console.WriteLine("Your BMI report indicates that you are overweight." +
                             "You might need to do some extra training sessions.\n");

        }
        public void ShowTrainingSession() 
        { 
        
        }
    }

}