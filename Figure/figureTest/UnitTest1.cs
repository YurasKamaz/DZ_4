using System.Drawing;
using Lib;

namespace figureTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CreateTriangle()
    {
        Triangle triangle = new Triangle(4, 4, 4);

        int a,b,c;
        triangle.GetABC(out a, out b, out c);
        Assert.AreEqual(4, a);
        Assert.AreEqual(4, b);
        Assert.AreEqual(4, c);
    }

    [TestMethod]
    public void CreateColorTriangle()
    {
        TriangleColor triangle = new TriangleColor(4, 4, 4, Color.AliceBlue);

        int a,b,c;
        triangle.GetABC(out a, out b, out c);
        Assert.AreEqual(4, a);
        Assert.AreEqual(4, b);
        Assert.AreEqual(4, c);
        Assert.AreEqual(System.Drawing.Color.AliceBlue, triangle.Color);
    }

    [TestMethod]
    public void SetABC()
    {
        Triangle triangle = new Triangle(4, 4, 4);

        Assert.ThrowsException<ArgumentException>(() => triangle.SetABC(3, 2, 6));
        Assert.ThrowsException<ArgumentException>(() => triangle.SetABC(0, 2, 2));
        Assert.ThrowsException<ArgumentException>(() => triangle.SetABC(0, 0, 0));
    }

    [TestMethod]
    public void GetArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);

        Assert.AreEqual(6, triangle.Area2);
    }
}