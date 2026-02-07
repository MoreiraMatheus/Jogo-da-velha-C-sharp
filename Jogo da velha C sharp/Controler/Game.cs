namespace TicTacToe;
public static class Game {
    public static void start() {
        string[,] testeGrid = {
            { "O", "O", "O" },
            { "X", "X", "X" },
            { ".", ".", "." }
        };

        Console.WriteLine("Game iniciado.");
        Grid.showGrid(testeGrid);
    }
}