public class Grid {
    public static void showGrid(string[,] grid) {
        for (int linha = 0; linha < grid.GetLength(0); linha++) { 
            for (int coluna = 0; coluna < grid.GetLength(1); coluna++) {
                colorPlayerChose(grid[linha, coluna]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void colorPlayerChose(string playerChose) {
        if (playerChose == "X") {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (playerChose == "O") {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.Write(playerChose);
        Console.ResetColor();
    }
}