namespace Sokoban;

public class LevelViewer
{
  public void PrintLevel(PlayingField playingField)
  {
    Console.Clear();
    for (var i = 0; i < playingField.Tiles.GetLength(0); i++)
    {
      for (var j = 0; j < playingField.Tiles.GetLength(1); j++)
      {
        var currectTile = playingField.Tiles[i, j];
        Console.Write(currectTile.GetDisplayCharacter());
      }

      Console.WriteLine();
    }
  }
}