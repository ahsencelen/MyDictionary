using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1, T2, T3>
    {
        T1[] Ids;
        T2[] names;
        T3[] jobs;

        public MyDictionary()
        {
            Ids = new T1[0];
            names = new T2[0];
            jobs = new T3[0];
        }
        public void Add(T1 Id, T2 name, T3 job)
        {
            T1[] tempArray = Ids;
            T2[] tempArray2 = names;
            T3[] tempArray3 = jobs;

            Ids = new T1[Ids.Length + 1];
            names = new T2[names.Length + 1];
            jobs = new T3[jobs.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                Ids[i] = tempArray[i];
                names[i] = tempArray2[i];
                jobs[i] = tempArray3[i];
            }

            Ids[Ids.Length - 1] = Id;
            names[names.Length - 1] = name;
            jobs[jobs.Length - 1] = job;
        }
        public int Length
        {
            get { return jobs.Length; }
        }
        public T1[] Id
        {
            get { return Ids; }
        }
        public T2[] Name
        {
            get { return names; }
        }
        public T3[] Job
        {
            get { return jobs; }
        }
    }
}
