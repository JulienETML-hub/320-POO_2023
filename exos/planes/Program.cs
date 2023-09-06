using planes;





Plane avion1 = new Plane();
for (int o = 0; o < 60; o++) 
{
    (int Left, int Top) cursorPosition = Console.GetCursorPosition();

    avion1.move(cursorPosition.Left, cursorPosition.Top);
    avion1.show();
}
Console.Read();