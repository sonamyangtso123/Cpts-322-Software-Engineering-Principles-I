using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Training
{
    public class TSMgmt
    {
        private int _id;
        private string _tsList = "tsList.bin";
        private IFormatter _bf;
        private Stream _s;
        private List<TS> tss;

        public TSMgmt()
        {
            _bf = new BinaryFormatter();
            if (File.Exists(_tsList))
            {
                _s = new FileStream(_tsList, FileMode.Open, FileAccess.Read, FileShare.None);
                tss = (List<TS>)_bf.Deserialize(_s);
                _id = (tss[tss.Count - 1].Id) + 1;
            }
            else
            {
                tss = new List<TS>();
                _id = 1;
            }
        }

        public int Size()
        {
            return tss.Count;
        }

        public bool AddTS(int trainerId, int dateTime, int capacity, string location)
        {
            if (location.Length==0)
            {
                Console.WriteLine("Empty is not allowed");
                return false;
            }
            TS ts = new TS(_id, trainerId, dateTime, capacity, location);
            tss.Add(ts);
            _id++;
            _s = new FileStream(_tsList, FileMode.Create, FileAccess.Write, FileShare.None);
            _bf.Serialize(_s, tss);
            _s.Close();

            return true;
        }
    }
}
