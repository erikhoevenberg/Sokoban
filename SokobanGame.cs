using Sokoban.Models;

namespace Sokoban;

public class SokobanGame
{
  private readonly PlayingField playingField;
  private readonly Player player;
  private readonly LevelViewer levelViewer;

  public SokobanGame(
    PlayingField playingField,
    Player player,
    LevelViewer levelViewer)
  {
    this.playingField = playingField;
    this.player = player;
    this.levelViewer = levelViewer;
  }

  public void Start()
  {
    while (true)
    {
      this.levelViewer.PrintLevel(this.playingField);

      var inputkey = Console.ReadKey();
      
      // Beweeg de speler afhankelijk van de input
      throw new NotImplementedException();

      // Als het spel is gewonnen, print iets uit en breek de functie af
      // Hint: Op het playingField object zit een lijst van alle FinishTiles
    }
  }
}