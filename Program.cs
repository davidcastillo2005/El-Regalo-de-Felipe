namespace Exam;

public static class Program
{
    static void Main(string[] args)
    {
        char[,] board = new char[,]
        {
            {'A', 'N', 'B', 'A', 'E'},
            {'A', 'A', 'D', 'X', 'O'},
            {'X', 'B', 'C', 'F', 'R'},
            {'D', 'C', 'H', 'A', 'D'},
            {'J', 'D', 'T', 'B', 'L'},
        };

        Direcctions[][] paths = new Direcctions[][]
        {
            new Direcctions[]{Direcctions.Down, Direcctions.Down, Direcctions.Down},
            new Direcctions[]{Direcctions.Down, Direcctions.Down, Direcctions.Left},
            new Direcctions[]{Direcctions.Down, Direcctions.Right, Direcctions.Up},
            new Direcctions[]{Direcctions.Right},
        };
        
        string message = "ABCD";
        int solve = Solution.FindNumber(board, paths, message);
        System.Console.WriteLine(solve);
        //Respuesta esperada 4
    }
}