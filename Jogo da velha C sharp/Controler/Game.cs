namespace TicTacToe;
public static class Game {
    public static void start() {
        string[,] gameGrid = {
            { " ", " ", " " },
            { " ", " ", " " },
            { " ", " ", " " }
        };

        Console.WriteLine("Game iniciado.");

        Grid.showGrid(gameGrid, 0, 0);
    }
}