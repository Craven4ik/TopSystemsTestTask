namespace TopSystemTestTask.Figures;

public abstract class FigureBase
{
    protected readonly float _startX;
    protected readonly float _startY;

    public FigureBase(float startX, float startY)
    {
        _startX = startX;
        _startY = startY;
    }

    public abstract void Draw();
}
