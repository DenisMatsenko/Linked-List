public class Global {
    public static void SetConsoleColor(ConsoleColor color) {
        Console.ForegroundColor = color;
    }
    public static void ResetConsoleColor() {
        Console.ForegroundColor = ConsoleColor.White;
    }
}