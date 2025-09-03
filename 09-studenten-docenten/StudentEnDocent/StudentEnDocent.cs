
using System.Collections.Generic;

namespace StudentEnDocent
{
    public class Student
    {
        public string Name { get; set; }
    }

    public class Docent
    {
        public string Name { get; set; }
        public List<Student> Studenten = new List<Student>();

        public void VoegStudentToe(Student student)
        {
            // TODO: implement
        }
    }
}
