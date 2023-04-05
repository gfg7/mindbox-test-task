using Mindbox.Interfaces;

namespace Mindbox;
public class MindboxLibrary
{
    public double GetArea(IBaseFigure figure) => figure.GetArea();

    public bool IsTriangleSquare(ITriangle triangle) => triangle.IsSquare();
}
