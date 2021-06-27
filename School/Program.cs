using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDictionary studentDictionary = new();
            studentDictionary.AddPerson("levani");
            studentDictionary.AddPerson("nika");
            studentDictionary.SetPoint(2, 100);

            foreach (var item in studentDictionary.Students)
            {
                Console.WriteLine($"Student Name : {item.Value.Name}, Grade : {item.Value.Grade}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }

    public class StudentDictionary : ISchool
    {
        public StudentDictionary()
        {
            Students = new Dictionary<int, Person>();
        }
        public Dictionary<int, Person> Students { get; private set; }
        public void AddPerson(string name)
        {
            Students.Add(Students.Count + 1, new Person() { Name = name });
        }

        public int GetPersonPoint(int personID)
        {
            return Students[personID].Grade;
        }

        public void RemovePerson(int personID)
        {
            if (!Students.ContainsKey(personID))
            {
                throw new Exception("No student was found by this ID");
            }
            Students.Remove(personID);
        }

        public void SetPoint(int personID, int grade)
        {
            Students[personID].Grade = grade;
        }
    }
}
