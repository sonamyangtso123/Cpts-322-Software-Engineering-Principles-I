using GymGenie.UserPackage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace GymGenie
{
    class Program
    {
        public static void Main(string[] args)
        {
            User u1 = new Admin("Andrew", "123456", "andrew@gmail.com");
            User u2 = new Trainer("John", "123456", "john@gmail.com");

            Console.WriteLine(u1);
            Console.WriteLine(u2);

            var users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("userList.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, users);
            stream.Close();

            Stream stream2 = new FileStream("userList.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            var users2 = (List<User>)formatter.Deserialize(stream2);
            stream2.Close();

            Console.WriteLine(users2[0].GetType());
            Console.WriteLine(users2[1].GetType());
        }
    }
}
