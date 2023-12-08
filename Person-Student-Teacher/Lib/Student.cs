namespace Lib;

public abstract class Student:Person {
    public Student(int age, string firstName, string lastName) : base(age, firstName, lastName){}
    public Student(Guid id, int age, string firstName, string lastName) : base(id, age, firstName, lastName){}
}