namespace CsharpAbstractDemo;

public class GreenUnit : Unit, IClickable
{
    public GreenUnit(Vector2 startPosition, IRenderable renderer) : base(startPosition, renderer)
    {
        // _color = Color.Green;
        _speed = 60;
    }

    public void Click()
    {
        // _color = Color.Blue;        
        // if (_color.Equals(Color.Green))
        // {
        //     _color = Color.Lime;
        // }
        // else
        // {
        //     _color = Color.Green;
        // }
    }

    public bool IsHovering(Vector2 mousePos)
    {
        return Raylib.CheckCollisionPointRec(mousePos, _rect);
    }
}