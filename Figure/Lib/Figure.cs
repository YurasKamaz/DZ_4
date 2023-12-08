namespace Lib;

public abstract class Figure
{
    private string? name;
    public string Name {
    get { return name!; }
    set { 
            if (String.IsNullOrEmpty(value)) value = ""; 
            name = value; 
        }
    }

    public Figure(string name) {Name = name;}

    public abstract int Area2 {get;}

    public abstract int Area();

    public virtual void Print() => Console.WriteLine(Name);
}
