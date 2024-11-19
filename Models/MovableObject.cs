namespace Sokoban.Models;

public abstract class MovableObject
{
  public Tile CurrentTile { get; set; } = null!;

  public virtual void Move(Direction direction)
  {
    // Tip: Tile heeft een method "MoveOnto"
    throw new NotImplementedException();
  }

  protected Tile? GetDestination(Direction direction)
  {
    Tile? destination;
    switch (direction)
    {
      case Direction.Up:
        destination = this.CurrentTile.Up;
        break;
      case Direction.Right:
        destination = this.CurrentTile.Right;
        break;
      case Direction.Down:
        destination = this.CurrentTile.Down;
        break;
      case Direction.Left:
        destination = this.CurrentTile.Left;
        break;
      default:
        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
    }

    return destination;
  }
}