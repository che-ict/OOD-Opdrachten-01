using NUnit.Framework;
using StudentEnDocent;

namespace TeacherAndStudentsTest
{
    public class Tests
    {
        [Test]
        public void VoegStudentAanDocentToe()
        {
            // Arrange
            var docent = new Docent { Name = "David" };
            var student = new Student { Name = "Jantje" };

            // Act
            docent.VoegStudentToe(student);

            // Assert
            Assert.That(docent.Studenten, Has.Count.EqualTo(1));
            Assert.That(docent.Studenten[0], Is.EqualTo(student));
        }
    }
}
