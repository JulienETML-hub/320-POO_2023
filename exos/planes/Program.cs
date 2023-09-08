using planes;
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;




Plane avion1 = new Plane();
Para para1 = new Para();
avion1.paraList.Add(para1);


    
    //(int Left, int Top) cursorPosition = Console.GetCursorPosition();

    // avion1.move(cursorPosition.Left, cursorPosition.Top);

Console.Clear();
while (true)
{
    Console.Clear();
    avion1.update();
    avion1.show();
    Thread.Sleep(20);
}
Console.Read();