namespace TopSystemTestTask.Figures;

public class Square : FigureBase
{
    private readonly float _side;
    public Square(float x, float y, float side) : base(x, y)
    {
        _side = side;
    }

    public override void Draw()
    {
        Console.WriteLine($"Квадрат: начало ({_startX}:{_startY}), сторона {_side}");
    }
}
