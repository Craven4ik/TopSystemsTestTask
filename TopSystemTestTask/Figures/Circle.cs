namespace TopSystemTestTask.Figures;

public class Circle : FigureBase
{
    private readonly float _radius;

    public Circle(float startX, float startY, float radius) : base(startX, startY)
    {
        _radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Круг: начало ({_startX}:{_startY}), радиус {_radius}");
    }
}
