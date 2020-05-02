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

        /// <summary>
        /// Let the trainer chose any option
        /// </summary>
        public void ShowOptionsForTrainer()
        {
            string userInput;
            int res;
            do
            {
                Console.WriteLine("1.Create BMI Report\n");
                Console.WriteLine("2.Add Training Session\n");
                userInput = Console.ReadLine();
                res = Convert.ToInt32(userInput);
                switch (res)
                {
                    case 1:
                        CreateBMIReport();
                        break;
                    case 2:
                        ShowTrainingSession();
                        break;

                }

            } while (res != 2);  
        }

        public override string ToString()
        {
            return base.ToString() + " |";
        }

        /// <summary>
        /// Create the BMI report.
        /// </summary>
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

        /// <summary>
        /// Show training sessions
        /// </summary>
        public void ShowTrainingSession()
        {
            Console.WriteLine("Day 1:Chest, Back, Shoulders, Legs, Biceps, Triceps\n" +
                              "Chest – Barbell Bench Press – 4 sets of 8 reps\n" +
                              "Back – Lat - pulldowns – 4 sets of 10 reps\n" +
                              "Shoulders – Seated Dumbbell Press – 4 sets of 10 reps\n" +
                              "Legs – Leg Extensions – 4 sets of 10 reps\n" +
                              "Biceps – Barbell Bbicep Curls – 3 sets of 10 reps\n" +
                              "Triceps – Triceps Rope Pushdowns – 3 sets of 15 reps\n\n");
            Console.WriteLine("Day 2: Legs, Triceps, Biceps, Chest, Back, Shoulder \n" +
                              "Legs – Leg Press Machine – 4 sets of 8 reps\n" +
                              "Triceps – Overhead Bar Extensions – 3 sets of 20 reps\n" +
                              "Biceps – EZ Bar Curls – 4 sets of 10 reps\n" +
                              "Chest – Machine Chest Press – 4 sets of 10 reps\n" +
                              "Back – T - Bar Row – 4 sets of 10 reps\n" +
                              "Shoulders – Lateral Raises – 3 sets of 20 reps\n\n");
            Console.WriteLine("Day 3: Shoulders, Back, Chest, Legs, Triceps, Biceps\n" +
                              "Shoulders – EZ Bar Upright Rows – 3 sets of 15 reps\n" +
                              "Back – Close - Grip Pulldowns – 4 sets of 12 reps\n" +
                              "Chest – Cable Fly – 4 sets of 10 reps\n" +
                              "Legs – Lunges – 3 sets of 10 reps per leg\n" +
                              "Triceps – Skullcrushers – 3 sets of 15 reps\n" +
                              "Biceps – Hammer Curls – 3 sets of 12 reps\n");
        }
    }

}