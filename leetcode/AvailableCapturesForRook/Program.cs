using System;

/*
On an 8 x 8 chessboard, there is one white rook.  There also may be empty squares, white bishops, 
and black pawns.  These are given as characters 'R', '.', 'B', and 'p' respectively. 
Uppercase characters represent white pieces, and lowercase characters represent black pieces.

The rook moves as in the rules of Chess: it chooses one of four cardinal directions (north, east, 
west, and south), then moves in that direction until it chooses to stop, reaches the edge of the 
board, or captures an opposite colored pawn by moving to the same square it occupies.  
Also, rooks cannot move into the same square as other friendly bishops.

Return the number of pawns the rook can capture in one move.
 */
namespace AvailableCapturesForRook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new char[8][] {
                new char[8] { '.','.','.','.','.','.','.','.' },
                new char[8] { '.','.','.','p','.','.','.','.' },
                new char[8] { '.','.','.','p','.','.','.','.' },
                new char[8] { 'p','p','.','R','.','p','B','.' },
                new char[8] { '.','.','.','.','.','.','.','.' },
                new char[8] { '.','.','.','B','.','.','.','.' },
                new char[8] { '.','.','.','p','.','.','.','.' },
                new char[8] { '.','.','.','.','.','.','.','.' }
            };

            var solution = Solve(input);

            Console.WriteLine(solution);
        }

        static int Solve(char[][] board) {
            int rookIndexX = 0, rookIndexY = 0;
            int pawnAttack = 0;
            
            for (var i = 0; i < board.Length; i++) {
                for (var j = 0; j < board[i].Length; j++) {
                    if (board[i][j] == 'R') {
                        rookIndexX = i;
                        rookIndexY = j;
                        break;
                    }
                }
            }
            
            // NORTH
            for (var i = rookIndexX - 1; i >= 0; i--) {
                if (board[i][rookIndexY] == 'p') {
                    pawnAttack++;
                    break;
                } else if (board[i][rookIndexY] != '.') {
                    break;
                }
            }
            
            // SOUTH
            for (var i =  rookIndexX + 1; i <= board.Length - 1; i++) {
                if (board[i][rookIndexY] == 'p') {
                    pawnAttack++;
                    break;
                } else if (board[i][rookIndexY] != '.') {
                    break;
                }
            }

            // WEST
            for (var i = rookIndexY - 1; i >= 0; i--) {
                if (board[rookIndexX][i] == 'p') {
                    pawnAttack++;
                    break;
                } else if (board[rookIndexX][i] != '.') {
                    break;
                }
            }
            
            // EAST
            for (var i = rookIndexY + 1; i < board.Length ; i++) {
                if (board[rookIndexX][i] == 'p') {
                    pawnAttack++;
                    break;
                } else if (board[rookIndexX][i] != '.') {
                    break;
                }
            }
            
            return pawnAttack;
        }
    }
}
