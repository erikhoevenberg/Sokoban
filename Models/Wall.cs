namespace Sokoban.Models;

public class Wall : Tile
{
  public override bool CanMoveTo()
  {
    throw new NotImplementedException();
  }

  public override void MoveOnto(MovableObject movableObject)
  {
    throw new Exception("Invalid move");
  }
  
  public override char GetDisplayCharacter()
  {
    return '█';
  }
}