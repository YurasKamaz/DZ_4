namespace Lib;

public class Triangle:Figure {
    private int A,B,C;

    public Triangle(int a, int b, int c, string name = "Треугольник") : base(name) {SetABC(a, b, c);}

    public void SetABC(int a, int b, int c) {
        if (a<=0 || b<=0 || c<=0 || !((a+b >= c) && (a+c >= b) && (b+c >= a))) throw new ArgumentException("Неверные данные");
        (A, B, C) = (a, b, c);
    }

    public void GetABC(out int a, out int b, out int c) => (a,b,c) = (A, B, C);

    public override int Area2 => Area();

    public override int Area() {
        int p = (A+B+C)/2;
        return (int)Math.Sqrt(p*(p-A)*(p-B)*(p-C));
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"a = {A} b = {B} c = {C}");
    }
}