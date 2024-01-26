namespace CsharpAbstractDemo;

public class Unit: GameObject
{
  private Rectangle rect;
  private Vector2 velocity;
  private float speed = 30f;
  private Color color;

  public Unit(Vector2 startPosition)
  {
    rect = new(startPosition.X, startPosition.Y, 64, 64);
    velocity = Vector2.UnitX;
    color = Color.Red;
  }

  public override void Update(float deltaTime)
  {
    rect.X += velocity.X * speed * deltaTime;

    if (rect.X + rect.Width > Raylib.GetScreenWidth())
    {
      velocity = -velocity;
    }
  }

  public override void Draw()
  {
    Raylib.DrawRectangleRec(rect, color);
  }
}
