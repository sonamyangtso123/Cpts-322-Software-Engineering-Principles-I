using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    [Serializable]
    class Trainer : _User
    {

        public Trainer(int id, string name, string email, string password) : base(id, name, email, password)
        {
            Role = 1;
        }


        public override string ToString()
        {
            return base.ToString() + " |";
        }

        public void CreateBMIReport()
        {
            Console.WriteLine("User's BMI Report:");
            Console.WriteLine(" Result: BMI Index = 26 You are overweight.");
        }

        public void AddTrainingSession()
        {
            T1 = "Date: 05-08-2022, Location: Weight Room, Workout: Resistance Training";
            Console.WriteLine(T1);
            Console.WriteLine("Training Session successfully added!");
        }

    }

   

}
