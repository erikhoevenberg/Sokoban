using Sokoban.Models;

namespace Sokoban;

public class PlayingField
{
  public PlayingField(
    Tile[,] tiles,
    List<Finish> finishTiles)
  {
    Tiles = tiles;
    FinishTiles = finishTiles;
  }

  public Tile[,] Tiles { get; set; }

  public List<Finish> FinishTiles { get; set; }
}