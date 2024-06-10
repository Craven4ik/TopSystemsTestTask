namespace TopSystemTestTask.Figures;

public class Ellipse : FigureBase
{
    private readonly float _verticalRadius;
    private readonly float _horizontalRadius;

    public Ellipse(float startX, float startY, float verticalRadius, float horizontalRadius) : base(startX, startY)
    {
        _verticalRadius = verticalRadius;
        _horizontalRadius = horizontalRadius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Эллипс: начало ({_startX}:{_startY}), вертикальный радиус {_verticalRadius}, горизонтальный радиус {_horizontalRadius}");
    }
}
