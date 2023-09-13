using planes;
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;




Plane avion1 = new Plane();
Para para1 = new Para();
Para para2 = new Para();
Para para3 = new Para();
avion1.paraList.Add(para1);
avion1.paraList.Add(para2);
avion1.paraList.Add(para3);
List<Para> ParaAir = new List<Para>();

//(int Left, int Top) cursorPosition = Console.GetCursorPosition();

// avion1.move(cursorPosition.Left, cursorPosition.Top);

Console.Clear();
while (true)
{
    if (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Escape:
                System.Environment.Exit(0);
                break;
            case ConsoleKey.Spacebar:
                ParaAir.Add(avion1.jump());

                break;
        }
    }

    // Modèle
    avion1.update();
    foreach (Para para in ParaAir)
    {
        para.update();

    }

    // Affichage
    Console.Clear();
    avion1.show();
    foreach (Para para in ParaAir)
    {
        para.show();
    }

    // Vitesse

    Thread.Sleep(50);
}
Console.Read();