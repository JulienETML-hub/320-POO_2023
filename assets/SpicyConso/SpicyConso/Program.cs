using Model;
using Display;
using System.Numerics;
using Storage;
using SpicyConso;
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;
uint frameNumber=0; // count the number of frames displayed

Alien alain = new Alien(0,0);
Canon canon = new Canon(Config.SCREEN_WIDTH/2, Config.SCREEN_HEIGHT);
Playground.Init();

while (true)
{
    // Actions de l'utilisateur
    if (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }

    // Déplacement au niveau du modèle (état)
    alain.Move();
    canon.deplacement();
    // Affichage
    Playground.Clear();
    Playground.DrawAlien(alain);
    Playground.DrawCanon(canon);
    frameNumber++;

    // Autosave
    if (frameNumber % 1000 == 0 )
    {
        Store.StoreAlien(alain);
    }

    // Timing
    Thread.Sleep(100);
}