using System;
using System.Collections.Generic;
using System.Text;
using User;

namespace Training
{
    [Serializable]
    class TS
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public string DateTime { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public bool IsFull { get; set; }
        public List<string> Participants { get; }

        public TS(int id, int trainerId, string dateTime, string location, int capacity)
        {
            Id = id;
            TrainerId = trainerId;
            DateTime = dateTime;
            Capacity = capacity;
            Location = location;
            IsFull = false;
            Participants = new List<string>();
        }

        public bool AddParticipant(string name)
        {
            if (!IsFull)
            {
                foreach (string participant in Participants)
                {
                    if (participant == name)
                    {
                        Console.WriteLine("Already assgined.");
                        return false;
                    }
                }
                Participants.Add(name);
                if(Participants.Count == Capacity)
                {
                    IsFull = true;
                }
                return true;
            }
            else
            {
                Console.WriteLine("The training session is full");
                return false;
            }

        }

        public string[] outputTS()
        {
            var participantsList = new StringBuilder();
            foreach (string participant in Participants)
            {
                participantsList.Append(participant + ", ");
            }
            string[] res = { "0" ,DateTime, Location, "" + Capacity, (IsFull ? "o" : "x"), participantsList.ToString()};
            return res;
        }
    }
}
