We gaan het spelletje Sokoban in deze repository afmaken. Het maakt niet uit in welke volgorde je dit doet. Ik raad deze volgorde aan:
1. Implementeer de methods om de verschillende soorten tegels aan te maken deze vind je in "PlayingFieldCreator"
2. Implementeer de verschillende tegels (Tile, Wall en Finish) als je dit gedaan hebt verschijnt het speelveld als je het spelletje start. Deze zijn te vinden in de folder "models". Je mag zelf kiezen welk karakter je gebruikt voor de "GetDisplayCharacter" method, je kunt ook in de Program.cs kijken.
3. Implementeer Player, Movable object and Box. Deze staan in dezelfde folder.
4. Implementeer input handling in Sokoban game. Deze moet gemaakt worden in de "SokobanGame" class in de start method.
5. Als laatst, in de "Start" method zorg ervoor dat wanneer het spel afgelopen is (alle dozen staan op een Finish tile) de loop word afgebroken. Je kunt uit de loop springen met return.
6. Bonus: Een while(true) is eigenlijk niet zo netjes pas de code zo aan dat de conditie in de while lus staat.

Op de plekken waar je iets in moet vullen staat een "NotImplementedException"

Hieronder staat een (pseudo) klasse diagram van Sokoban.

![sokobanklasse](https://github.com/user-attachments/assets/18f3bd62-c18f-43c2-9462-a9337c9aea9b)
