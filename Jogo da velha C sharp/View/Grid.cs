public class Grid {
    public static void showGrid(string[,] grid, int row, int col) {
        int quantidadeLinhas = grid.GetLength(0);
        int quantidadeColunas = grid.GetLength(1);

        for (int linha = 0; linha < quantidadeLinhas; linha++) { 
            for (int coluna = 0; coluna < quantidadeColunas; coluna++) {
                bool destacaLinha = row == linha && col == coluna;

                colorPlayerChose(grid[linha, coluna], destacaLinha);

                if (coluna < grid.GetLength(1) -1) {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (linha < quantidadeLinhas - 1) { 
                Console.WriteLine("---+---+---");            
            }
        }
    }

    public static void colorPlayerChose(string playerChose, bool backColor) {
        if (backColor) {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (playerChose == "X") {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (playerChose == "O") {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.Write($" {playerChose} ");
        Console.ResetColor();
    }
}