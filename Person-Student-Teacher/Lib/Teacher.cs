namespace Lib;

public class Teacher:Person {
    static Teacher[] people = new Teacher[] {
        new Teacher(45, "Эдуард", "Кузьмин"),
        new Teacher(34, "Борис", "Потапов"),
        new Teacher(63, "Святослав", "Данилов")
    };
    static Random random = new Random();

    public List<Student>? Students;

    public Teacher(int age, string firstName, string lastName, List<Student> students = null!) : base(age, firstName, lastName) {SetStudents(students);}

    public Teacher(Guid id, int age, string firstName, string lastName, List<Student> students = null!) : base(id, age, firstName, lastName) {SetStudents(students);}

    public void SetStudents(List<Student> students) {
        if (students==null) return;
        if (Students==null) Students = new List<Student>();
        foreach(Student student in students) {
            Students.Add(student);
        }
    }

    public static Teacher RandomTeacher() {
        return people[random.Next(people.Length)];
    }

    public override int GetHashCode()
    {
        return $"Teacher {ID}".GetHashCode();
    }

    public override string ToString()
    {
        string res = base.ToString();
        res += "\nСтуденты:";
        if(Students != null)
            foreach(Student student in Students) res += $"\n{student.GetName()}";
        else res += " Не назначены";
        return res;
    }

    public override Person Clone() {
        List<Student> students = new List<Student>();
        if(Students != null) 
            foreach (var student in Students) students.Add(student.Clone() as Student);
        else students = null!;
        return new Teacher(ID, Age, FirstName, LastName, students!);
    }

    public override bool Equals(object? obj)
    {
        bool res = base.Equals(obj);
        if(res) {
            Teacher temp = (Teacher)obj!;
            if(Students == null) res = temp.Students == Students;
            else res = temp!.Students!.SequenceEqual(Students!);
        }
        return res;
    }
}