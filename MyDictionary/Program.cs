using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, string> members = new MyDictionary<int, string, string>();
            members.Add(123456, "Ahsen Çelen", "Engineer");
            members.Add(456789, "Anıl Ateş", "Doctor");
            members.Add(789456, "Elif Topaç", "Teacher");
            members.Add(456123, "Furkan Küçük", "Engineer");

            Console.WriteLine("total number of members: " + members.Length);

            Console.WriteLine("--- Members ID cards ---");
            foreach (var Id in members.Id)
            {
                Console.WriteLine(Id);
            }
            Console.WriteLine("-----Members Name----");
            foreach (var name in members.Name)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----Members Job-----");
            foreach (var jobs in members.Job)
            {
                Console.WriteLine(jobs);
            }

        }
    }
}
