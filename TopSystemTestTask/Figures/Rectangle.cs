namespace TopSystemTestTask.Figures;

public class Rectangle : FigureBase
{
    private readonly float _sideA;
    private readonly float _sideB;

    public Rectangle(float startX, float startY, float sideA, float sideB) : base(startX, startY)
    {
        _sideA = sideA;
        _sideB = sideB;
    }

    public override void Draw()
    {
        Console.WriteLine($"Прямоугольник: начало ({_startX}:{_startY}), стороны {_sideA}, {_sideB}");
    }
}
