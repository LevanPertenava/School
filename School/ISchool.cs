using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface ISchool
    {
        void AddPerson(string name);

        void SetPoint(int personID, int grade);

        void RemovePerson(int personID);

        int GetPersonPoint(int personID);
    }
}
