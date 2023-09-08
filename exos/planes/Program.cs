using planes;





Plane avion1 = new Plane();
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;
    
    //(int Left, int Top) cursorPosition = Console.GetCursorPosition();

    // avion1.move(cursorPosition.Left, cursorPosition.Top);

Console.Clear();
while (true)
{
    Console.Clear();
    avion1.update();
    avion1.show();
    Thread.Sleep(5);
}
Console.Read();