namespace Exam;

public static class Solution
{
    public static int FindNumber(char[,] board, Direcctions[][] paths, string message)
    {
        int contador = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                foreach (var directionArray in paths)
                {
                    string str = board[i, j].ToString();
                    (int i, int j) actualPos = (i, j);
                    foreach (Direcctions direction in directionArray)
                    {
                        if (direction is Direcctions.Down)
                        {
                            if (actualPos.i + 1 < board.GetLength(1))
                            {
                                str += board[actualPos.i + 1, actualPos.j];
                                actualPos.i += 1;
                            }
                        }
                        else if (direction is Direcctions.Up)
                        {
                            if (actualPos.i - 1 >= 0)
                            {
                                str += board[actualPos.i - 1, actualPos.j];
                                actualPos.i -= 1;
                            }
                        }
                        else if (direction is Direcctions.Left)
                        {
                            if (actualPos.j - 1 >= 0)
                            {
                                str += board[actualPos.i, actualPos.j - 1];
                                actualPos.j -= 1;
                            }
                        }
                        else if (direction is Direcctions.Right)
                        {
                            if (actualPos.j + 1 < board.GetLength(0))
                            {
                                str += board[actualPos.i, actualPos.j + 1];
                                actualPos.j += 1;
                            }
                        }
                    }

                    if (str == message)
                    {
                        contador++;
                    }
                }
                
            }
        }
        return contador;
    }
}

public enum Direcctions
{
    Up, Down, Left, Right,
}