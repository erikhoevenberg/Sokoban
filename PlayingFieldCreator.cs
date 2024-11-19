using Sokoban.Models;

namespace Sokoban;

public static class PlayingFieldCreator
{
  public static PlayingField CreatePlayingField(string[,] playingFieldTemplate, Player player)
  {
    var finishTiles = new List<Finish>();

    var playingField = new Tile[playingFieldTemplate.GetLength(0), playingFieldTemplate.GetLength(1)];

    for (var i = 0; i < playingFieldTemplate.GetLength(0); i++)
    {
      for (var j = 0; j < playingFieldTemplate.GetLength(1); j++)
      {
        var newTile = CreateTile(playingFieldTemplate, finishTiles, player, i, j);
        SetDirections(newTile, playingField, i, j);
        playingField[i, j] = newTile;
      }
    }

    return new PlayingField(playingField, finishTiles);
  }

  private static Tile CreateTile(string[,] tiles, List<Finish> finishTiles, Player player, int x, int y)
  {
    Tile newTile;
    switch (tiles[x, y])
    {
      case "#":
        newTile = CreateWallTile();
        break;
      case "@":
        newTile = CreateTileWithPlayer(player);
        break;
      case "o":
        newTile = CreateTileWithBox();
        break;
      case ".":
        newTile = CreateFinishTile(finishTiles);
        break;
      case " ":
        newTile = CreateEmptyTile();
        break;
      default: 
        throw new Exception("Unkown tile");
    }

    return newTile;
  }

  private static Tile CreateEmptyTile()
  {
    throw new NotImplementedException();
  }

  private static Wall CreateWallTile()
  {
    throw new NotImplementedException();
  }

  private static Tile CreateTileWithPlayer(Player player)
  {
    throw new NotImplementedException();
  }

  private static Tile CreateTileWithBox()
  {
    throw new NotImplementedException();
  }

  private static Finish CreateFinishTile(List<Finish> finishTiles)
  {
    throw new NotImplementedException();
  }

  private static void SetDirections(Tile newTile, Tile[,] playingField, int x, int y)
  {
    throw new NotImplementedException();
  }
}