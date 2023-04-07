using Mindbox;
using Mindbox.Models.Figures;
using Mindbox.Models.Figures.Exceptions;

namespace MindboxTest;

public class MindboxUnitTest
{
    private MindboxLibrary _mindboxLibrary;
    public MindboxUnitTest()
    {
        _mindboxLibrary = new MindboxLibrary();
    }

    [Fact]
    public void Create_InvalidRadius_Circle()
    {
        var testData = 0;

        Assert.Throws<FigureCreationException>(() => new Circle(testData));
    }

    [Fact]
    public void Create_InvalidSides_Triangle()
    {
        var testData = new double[] {
            3,
            5
        };

        Assert.Throws<FigureCreationException>(() => new Triangle(testData));
    }

    [Fact]
    public void Create_Nonexistent_Triangle()
    {
        var testData = new double[] {
            4,
            3,
            7
        };

        Assert.Throws<FigureCreationException>(() => new Triangle(testData));
    }

    [Fact]
    public void GetArea_Circle()
    {
        var testData = 5;
        var expected = Math.Pow(testData, 2) * Math.PI;
        var circle = new Circle(testData);

        var result = _mindboxLibrary.GetArea(circle);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetArea_Triangle()
    {
        var testData = new double[] {
            3,
            4,
            5
        };
        var expected = 6;
        var triangle = new Triangle(testData);

        var result = _mindboxLibrary.GetArea(triangle);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Triangle_Is_Square()
    {
        var testData = new double[] {
            3,
            4,
            5
        };
        var triangle = new Triangle(testData);

        var result = _mindboxLibrary.IsTriangleSquare(triangle);
        Assert.True(result);
    }

    [Fact]
    public void Triangle_IsNot_Square()
    {
        var testData = new double[] {
            3,
            3,
            3
        };
        var triangle = new Triangle(testData);

        var result = _mindboxLibrary.IsTriangleSquare(triangle);
        Assert.False(result);
    }

}