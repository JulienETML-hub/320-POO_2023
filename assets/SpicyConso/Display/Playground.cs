using Model;

namespace Display
{
    public class Playground
    {
        public static void Init()
        {
            Console.CursorVisible = false;
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void DrawAlien(Alien alien)
        {
            if (alien == null) return;
            Console.SetCursorPosition(alien.x, alien.y);
            Console.Write("o");
        }
        public static void DrawCanon(Canon canon)
        {
            Console.SetCursorPosition(canon.x, canon.y);
            Console.WriteLine(" _|_ ");
        }
    }
}