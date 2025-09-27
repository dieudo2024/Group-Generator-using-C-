using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupGenerator
{
    internal interface IStudent
    {
        string ID { get; set; }

        static bool IsLastNameShort { get; set; }

        // Adds a studentObj to the list.
        void AddStudent(Student student);

        // Creates a specific number of random studentObj groups.
        List<List<Student>> CreateGroups(int numberOfGroups);
    }
}
