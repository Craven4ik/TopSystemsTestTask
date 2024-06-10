namespace TopSystemTestTask.Figures;

public class Triangle : FigureBase
{
    private readonly float _sideA;
    private readonly float _sideB;
    private readonly float _sideC;

    public Triangle(float x, float y, float sideA, float sideB, float sideC) : base(x, y)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public override void Draw()
    {
        Console.WriteLine($"Треугольник: начало ({_startX}:{_startY}), стороны {_sideA}, {_sideB}, {_sideC}");
    }
}
