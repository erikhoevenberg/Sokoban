namespace Sokoban.Models;

public class Tile
{
  public MovableObject? ObjectOnTop { get; set; }

  public Tile? Up { get; set; }

  public Tile? Down { get; set; }

  public Tile? Left { get; set; }

  public Tile? Right { get; set; }

  public virtual bool CanMoveTo()
  {
    throw new NotImplementedException();
  }

  public virtual void MoveOnto(MovableObject movableObject)
  {
    this.ObjectOnTop = movableObject;
    movableObject.CurrentTile = this;
  }

  public virtual char GetDisplayCharacter()
  {
    throw new NotImplementedException();
  }
}