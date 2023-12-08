using Lib;

namespace pstTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
        public void CreatePerson()
        {
            string fName = "123";
            string lName = "321";
            int age = 20;
            var person = new Person(age, fName, lName);

            Assert.AreEqual(fName, person.FirstName);
            Assert.AreEqual(lName, person.LastName);
            Assert.AreEqual(age, person.Age);
        }

    [TestMethod]
        public void CreateStudent()
        {
            string fName = "123";
            string lName = "321";
            int age = 20;
            var person = new StudentWithAdvisor(age, fName, lName);

            Assert.AreEqual(fName, person.FirstName);
            Assert.AreEqual(lName, person.LastName);
            Assert.AreEqual(age, person.Age);
        }

    [TestMethod]
        public void CreateTeacher()
        {
            string fName = "123";
            string lName = "321";
            int age = 20;
            var person = new Teacher(age, fName, lName);

            Assert.AreEqual(fName, person.FirstName);
            Assert.AreEqual(lName, person.LastName);
            Assert.AreEqual(age, person.Age);
        }

    [TestMethod]
        public void isEqual()
        {
            string fName = "123";
            string lName = "321";
            int age = 20;
            Guid id = Guid.NewGuid();
            var person1 = new Person(id, age, fName, lName);
            var person2 = new Person(id, age, fName, lName);
            var teacher = new Teacher(id, age, fName, lName);
            var person3 = new StudentWithAdvisor(id, age, fName, lName, teacher);
            var person4 = new StudentWithAdvisor(id, age, fName, lName, teacher);
            var student = new StudentWithAdvisor(age, fName, lName);
            var person5 = new Teacher(id, age, fName, lName, new List<Student>{person4});
            var person6 = new Teacher(id, age, fName, lName, new List<Student>{person4});
            var person7 = new Teacher(id, age, fName, lName, new List<Student>{student});
            var person8 = new StudentWithAdvisor(id, age, fName, lName, person5);

            Assert.IsTrue(person1.Equals(person2));
            Assert.IsTrue(person3.Equals(person4));
            Assert.IsTrue(person5.Equals(person6));

            Assert.IsFalse(person1.Equals(person3));
            Assert.IsFalse(person1.Equals(person5));
            Assert.IsFalse(person3.Equals(person5));
            Assert.IsFalse(person5.Equals(person7));
            Assert.IsFalse(person3.Equals(person8));
        }

    [TestMethod]
        public void Clone()
        {
            string fName = "123";
            string lName = "321";
            int age = 20;
            Guid id = Guid.NewGuid();
            var person = new Person(id, age, fName, lName);
            var teacher = new Teacher(id, age, fName, lName);
            var student = new StudentWithAdvisor(id, age, fName, lName, teacher);
            var teacherWithStudent = new Teacher(id, age, fName, lName, new List<Student>{StudentWithAdvisor.RandomStudent()});
            
            var clonedPerson = person.Clone();
            var clonedStudent = student.Clone();
            var clonedTeacher = teacher.Clone();
            var clonedTeacherWithStudent = teacherWithStudent.Clone();

            Assert.IsTrue(person.Equals(clonedPerson));
            Assert.IsTrue(student.Equals(clonedStudent));
            Assert.IsTrue(teacher.Equals(clonedTeacher));
            Assert.IsTrue(teacherWithStudent.Equals(clonedTeacherWithStudent));
        }
}