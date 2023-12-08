namespace Lib;

public class Person
{
    static Person[] people = new Person[] {
        new Person(21, "Анатолий", "Логинов"),
        new Person(19, "Станислав", "Новиков"),
        new Person(25, "Григорий", "Макаров")
    };
    static Random random = new Random();
    public Guid ID;
    private int age;
    public int Age {
    get { return age; }
    set { 
            if (value < 0) value = 0; 
            age = value; 
        }
    }
    private string firstName;
    public string FirstName {
    get { return firstName; }
    set { 
            if (String.IsNullOrEmpty(value)) value = ""; 
            firstName = value; 
        }
    }
    private string lastName;
    public string LastName {
    get { return lastName; }
    set { 
            if (String.IsNullOrEmpty(value)) value = ""; 
            lastName = value; 
        }
    }

    public Person(int age, string firstName, string lastName) {
        ID = Guid.NewGuid();
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }

    public Person(Guid id, int age, string firstName, string lastName) {
        ID = id;
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Фамилия {LastName} Имя {FirstName} Возраст {Age}";
    }

    public override int GetHashCode()
    {
        return $"Person {ID}".GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj != null && obj.GetType() == this.GetType() && obj.GetHashCode() == this.GetHashCode();
    }

    public virtual void Print() => Console.WriteLine(this.ToString());

    public static Person RandomPerson() {
        return people[random.Next(people.Length)];
    }

    public virtual Person Clone() => new Person(ID, Age, FirstName, LastName);

    public string GetName() => $"{FirstName} {LastName}";
}
