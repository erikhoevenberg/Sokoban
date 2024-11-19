namespace Sokoban.Models;

public class Box : MovableObject
{
  public bool CanMove(Direction direction)
  {
    var destination = this.GetDestination(direction); // Afkomstig van de baseclass "MovableObject"
    throw new NotImplementedException();
  }
}