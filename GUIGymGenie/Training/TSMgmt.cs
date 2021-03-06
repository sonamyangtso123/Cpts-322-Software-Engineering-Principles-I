﻿using System;
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
                _s.Close();
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

        public void Save()
        {
            _s = new FileStream(_tsList, FileMode.Create, FileAccess.Write, FileShare.None);
            _bf.Serialize(_s, tss);
            _s.Close();
        }

        public bool AddTS(int trainerId, string dateTime, string location, int capacity )
        {
            if (location.Length==0)
            {
                Console.WriteLine("Empty is not allowed");
                return false;
            }
            TS ts = new TS(_id, trainerId, dateTime, location, capacity);
            tss.Add(ts);
            _id++;
            Save();

            return true;
        }

        public void AddPartInTS(int trainerId, int tsId, string name)
        {
            foreach(TS ts in tss)
            {
                if(ts.TrainerId == trainerId)
                {
                    if(ts.Id == tsId)
                    {
                        ts.AddParticipant(name);
                        Save();
                        break;
                    }
                }
            }
        }

        public int getSizeTS(int trainerId)
        {
            int res=0;
            foreach(TS ts in tss)
            {
                if(ts.TrainerId == trainerId)
                {
                    res++;
                }
            }
            return res;
        }


        public List<string[]> outputDataGrid(int trainId)
        {
            List<string[]> res = new List<string[]>();
            foreach(TS ts in tss)
            {
                if(ts.TrainerId == trainId)
                {
                    res.Add(ts.outputTS());
                }
            }
            return res;
        }
    }
}
