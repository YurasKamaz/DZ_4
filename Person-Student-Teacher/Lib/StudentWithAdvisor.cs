namespace Lib;

public class StudentWithAdvisor:Student {
    static StudentWithAdvisor[] people = new StudentWithAdvisor[] {
        new StudentWithAdvisor(18, "Владислав", "Трофимов", Teacher.RandomTeacher()),
        new StudentWithAdvisor(19, "Борис", "Шашков", Teacher.RandomTeacher()),
        new StudentWithAdvisor(21, "Георгий", "Ефремов", Teacher.RandomTeacher())
    };

    static Random random = new Random();

    public Teacher? Teacher;

    public StudentWithAdvisor(int age, string firstName, string lastName, Teacher teacher = null!) : base(age, firstName, lastName) {SetTeacher(teacher);}

    public StudentWithAdvisor(Guid id, int age, string firstName, string lastName, Teacher teacher = null!) : base(id, age, firstName, lastName) {SetTeacher(teacher);}

    public void SetTeacher(Teacher teacher) {
        if(teacher == null) return;
        Teacher = teacher;
    }

    public static StudentWithAdvisor RandomStudent() {
        return people[random.Next(people.Length)];
    }

    public override int GetHashCode()
    {
        return $"Student {ID}".GetHashCode();
    }

    public override string ToString()
    {
        if(Teacher!=null) return $"Фамилия {LastName} Имя {FirstName} Возраст {Age} Преподаватель {Teacher.GetName()}";
        else return $"Фамилия {LastName} Имя {FirstName} Возраст {Age} Преподаватель не назначен";
    }

    public override bool Equals(object? obj)
    {
        bool res = base.Equals(obj);
        if(res) {
            StudentWithAdvisor temp = (StudentWithAdvisor)obj!;
            res = Teacher!.Equals(temp!.Teacher!);
        }
        return res;
    }

    public override Person Clone()
    {
        StudentWithAdvisor student = new StudentWithAdvisor(ID, Age, FirstName, LastName);
        if (Teacher!=null) student.SetTeacher(Teacher.Clone() as Teacher);
        return student;
    }
}