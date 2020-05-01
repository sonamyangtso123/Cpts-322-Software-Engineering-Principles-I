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
        public int DateTime { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public bool IsFull { get; set; }
        private List<_User> participants;

        public TS(int id, int trainerId, int dateTime, int capacity, string location)
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
            foreach(_User user in participants)
            {
                if (user.Equals(participant))
                {
                    Console.WriteLine("Already assgined.");
                    return false;
                }
            }

            participants.Add(participant);
            return true;
        }
    }
}
