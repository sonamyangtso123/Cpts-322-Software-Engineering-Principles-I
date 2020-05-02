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
        private List<_User> participants;

        public TS(int id, int trainerId, string dateTime, string location, int capacity)
        {
            Id = id;
            TrainerId = trainerId;
            DateTime = dateTime;
            Capacity = capacity;
            Location = location;
            IsFull = false;
            participants = new List<_User>();
        }

        public bool AddParticipant(_User participant)
        {
            if (!IsFull)
            {
                foreach (_User user in participants)
                {
                    if (user.Equals(participant))
                    {
                        Console.WriteLine("Already assgined.");
                        return false;
                    }
                }
                participants.Add(participant);
                if(participants.Count == Capacity)
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
            foreach (_User user in participants)
            {
                participantsList.Append(user.Name + ", ");
            }
            string[] res = { "0" ,DateTime, Location, "" + Capacity, (IsFull ? "o" : "x"), participantsList.ToString()};
            return res;
        }
    }
}
