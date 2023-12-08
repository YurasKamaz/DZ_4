using System.Drawing;

namespace Lib;

public class TriangleColor:Triangle {
    private Color color;
    public Color Color {
    get { return color; }
    set { 
            if (value == color) return; 
            color = value; 
        }
    }

    public TriangleColor(int a, int b, int c, Color color, string name = "Треугольник") : base(a, b, c, name) {Color = color;}

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Цвет {Color}");
    }
}