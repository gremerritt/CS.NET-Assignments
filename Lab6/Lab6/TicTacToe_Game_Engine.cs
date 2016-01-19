using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab6
{
    class TicTacToe_Game_Engine
    {
        private const int dim = 3;
        private CellSelection[,] board = new CellSelection[3, 3];
        private bool gameover = false;

        //-----------------------------------------------------------
        // This function clears the gameboard and starts the game over.
        //-----------------------------------------------------------
        public void clear()
        {
            gameover = false;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    board[i, j] = CellSelection.N;
                }
            }
        }

        //-----------------------------------------------------------
        // This function returns whether or not the game is over
        //
        // Return:
        //      true - the game is over (is either won or tried)
        //      false - the game is still in progress
        //-----------------------------------------------------------
        public bool isGameover()
        {
            return gameover;
        }

        //-----------------------------------------------------------
        // This function returns the player holding the given cell
        //
        // Input:
        //		row - cell row
        //      col - cell column
        //
        // Return:
        //      player currently holding the square
        //-----------------------------------------------------------
        public CellSelection getCell(int row, int col)
        {
            return board[row, col];
        }

        //-----------------------------------------------------------
        // This function makes a move for the given 'player' in the
        // given 'square'.
        //
        // Input:
        //		row - cell row
        //      col - cell column
        //      player - player making the move
        //-----------------------------------------------------------
        public void makeMove(int row, int col, CellSelection player)
        {
            board[row, col] = player;
        }

        //-----------------------------------------------------------
        // This function checks if the player given by 'player' input
        // won the game.
        //
        // Input:
        //		player - the player to check for a win
        //
        // Returns:
        //		true  - 'player' won
        //		false - 'player' didn't win
        //-----------------------------------------------------------
        public bool isWin(CellSelection player)
        {
            // check horizontals
            for (int i=0; i<dim; i++)
            {
                if (board[i, 0] == player)
                {
                    for (int j=1; j<dim; j++)
                    {
                        if (board[i, j] != player) { break; }

                        if (j == (dim - 1))
                        {
                            gameover = true;
                            return true;
                        }
                    }
                }
            }

            // check verticals
            for (int j=0; j<dim; j++)
            {
                if (board[0, j] == player)
                {
                    for (int i=1; i<dim; i++)
                    {
                        if (board[i, j] != player) { break; }

                        if (i == (dim - 1))
                        {
                            gameover = true;
                            return true;
                        }
                    }
                }
            }

            // check diagonals
            for (int i=0; i<dim; i++)
            {
                if (board[i, i] != player) { break; }

                if (i == (dim - 1))
                {
                    gameover = true;
                    return true;
                }
            }

            for (int i=0; i<dim; i++)
            {
                if (board[dim - 1 - i, i] != player) { break; }

                if (i == (dim - 1))
                {
                    gameover = true;
                    return true;
                }
            }

            return false;
        }

        //-----------------------------------------------------------
        // This function determines if the game is a tie. This occurs
        // when each row, column, and diagonal has both an X and an 0
        //
        // Returns:
        //		true  - tie
        //		false - not a tie
        //-----------------------------------------------------------
        public bool isTie()
        {
            //  taken is a multi dimensional array tracking which row/column/diagonals
            //  have X's and O's.
            //  for example, on a 3x3 board
            //      taken[0][1] = true means that row 0 has a computer pawn
            //      taken[3][0] = false means that column 1 doesn't have a user pawn
            //      taken[7][0] = true means that the lower-left to upper right diagonal has a user pawn
            bool[,] taken = new bool[ ( dim * 2 ) + 2 , 2 ];

            for (int i=0; i<dim; i++)
            {
                for (int j=0; j<dim; j++)
                {
                    switch (board[i, j]) {
                        case CellSelection.X:
                            taken[i, 0] = true;
                            taken[j+dim, 0] = true;
                            if (i == j) { taken[dim * 2, 0] = true; }
                            if ((i + j) == (dim - 1)) { taken[(dim * 2) + 1, 0] = true; }
                            break;
                        case CellSelection.O:
                            taken[i, 1] = true;
                            taken[j+dim, 1] = true;
                            if (i == j) { taken[dim * 2, 1] = true; }
                            if ((i + j) == (dim - 1)) { taken[(dim * 2) + 1, 1] = true; }
                            break;
                        default:
                            break;
                    }
                }
            }

            for (int i=0; i<(( dim * 2 ) + 2); i++)
            {
                if ( ( !taken[i, 0] ) || ( !taken[i, 1] ) )
                    return false;
            }

            gameover = true;
            return true;
        }

        //-----------------------------------------------------------
        // This function generates the computers move
        //
        // The basic strategy is:
        //		- If the computer can win, it will
        //      - If the user is about to win, the computer will block
        //		- Else, the computer will pick a random move out the optimal choices
        //-----------------------------------------------------------
        public void computerTurn()
        {
            Point coord = new Point();

            // check if the computer can win
            coord = isOneAway(CellSelection.O);
            if (coord.X != -1)
            {
                board[coord.X, coord.Y] = CellSelection.O;
                return;
            }

            // then check if the computer can tie
            coord = isOneAway(CellSelection.X);
            if (coord.X != -1) {
                board[coord.X, coord.Y] = CellSelection.O;
                return;
            }

            // else make a move in an optimal spot
            coord = computerMove();
            board[coord.X, coord.Y] = CellSelection.O;
            return;
        }

        //-----------------------------------------------------------
        // This function makes a move for the computer. It finds the
        // rows/columns/diagonals that have the fewest open spots and
        // randomly chooses one of them.
        //
        // Returns:
        //		Point - coordinate point that the computer should
        //-----------------------------------------------------------
        private Point computerMove()
        {
            // this will be very similar to the isOneAway function
            // except instead of stopping if we find more than one
            // empty space, we'll keep the count, and check if it's
            // greater than the max.

            // the 'which' variable will tell us which row/column/diagonal have already been assessed.
            // 		the indexes are as follows:
            //			0 - [dim-1] 		= rows 0 through [dim-1]
            //			dim - [(dim*2) - 1]	= columns dim through [(dim*2) - 1]
            //			dim*2				= upper-left to bottom right diagonal
            //			(dim*2) + 1			= bottom-left to upper-right diagonal
            bool[] which = new bool[ ( dim * 2 ) + 2 ];		// defaults to false
            int count = 0;									// count of empty spots in a given row/col/diagonal
            int min = dim;									// the current lowest number of free spaces
            int[,] tmpBestSpots = new int[ (dim * dim), 2];
            int[,] bestSpots = new int[ (dim * dim), 2];
            int bestSpotsLength = 0;
            int[,] availableSpots = new int[ (dim * dim), 2];
            int availableSpotsLength = 0;
            Point coord = new Point();

            for (int i=0; i<dim; i++)
            {
                for (int j=0; j<dim; j++)
                {
                    if ( board[i, j] == CellSelection.O )
                    {
                        // first see how close we can get in a vertical
                        for (int k=0; k<dim; k++)
                        {
                            if ( k == i )
                                continue;

                            if ( ( board[k, j] == CellSelection.X ) || ( which[dim + j] ) )
                            {
                                count = 0;
                                break;
                            }
                            else if ( board[k, j] == CellSelection.N )
                            {
                                tmpBestSpots[count, 0] = k;
                                tmpBestSpots[count, 1] = j;
                                count++;
                            }
                        }
                        if ( ( count < min ) && ( count > 0 ) )
                        {
                            min = count;
                            bestSpotsLength = count;
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[k, 0] = tmpBestSpots[k, 0];
                                bestSpots[k, 1] = tmpBestSpots[k, 1];
                            }
                            which[dim + j] = true;
                        }
                        else if ( count == min )
                        {
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[bestSpotsLength, 0] = tmpBestSpots[k, 0];
                                bestSpots[bestSpotsLength, 1] = tmpBestSpots[k, 1];
                                bestSpotsLength++;
                            }
                            which[dim + j] = true;
                        }

                        // then check how close we can get in a horizontal
                        count = 0;
                        for (int k=0; k<dim; k++)
                        {
                            if ( k == j )
                                continue;

                            if ( ( board[i, k] == CellSelection.X ) || ( which[i] ) )
                            {
                                count = 0;
                                break;
                            }
                            else if ( board[i, k] == CellSelection.N )
                            {
                                tmpBestSpots[count, 0] = i;
                                tmpBestSpots[count, 1] = k;
                                count++;
                            }
                        }
                        if ( ( count < min ) && ( count > 0 ) )
                        {
                            min = count;
                            bestSpotsLength = count;
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[k, 0] = tmpBestSpots[k, 0];
                                bestSpots[k, 1] = tmpBestSpots[k, 1];
                            }
                            which[i] = true;
                        }
                        else if ( count == min )
                        {
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[bestSpotsLength, 0] = tmpBestSpots[k, 0];
                                bestSpots[bestSpotsLength, 1] = tmpBestSpots[k, 1];
                                bestSpotsLength++;
                            }
                            which[i] = true;
                        }

                        // then check how close we can get in a diagonal
                        // upper-left to bottom-right diagonal
                        count = 0;
                        if ( i == j )
                        {
                            for (int k=0; k<dim; k++)
                            {
                                if ( k == i )
                                    continue;

                                if ( ( board[k, k] == CellSelection.X ) || ( which[ ( dim * 2 ) ] ) )
                                {
                                    count = 0;
                                    break;
                                }
                                else if ( board[k, k] == CellSelection.N )
                                {
                                    tmpBestSpots[count, 0] = k;
                                    tmpBestSpots[count, 1] = k;
                                    count++;
                                }
                            }
                        }
                        if ( ( count < min ) && ( count > 0 ) )
                        {
                            min = count;
                            bestSpotsLength = count;
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[k, 0] = tmpBestSpots[k, 0];
                                bestSpots[k, 1] = tmpBestSpots[k, 1];
                            }
                            which[ ( dim * 2 ) ] = true;
                        }
                        else if ( count == min )
                        {
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[bestSpotsLength, 0] = tmpBestSpots[k, 0];
                                bestSpots[bestSpotsLength, 1] = tmpBestSpots[k, 1];
                                bestSpotsLength++;
                            }
                            which[ ( dim * 2 ) ] = true;
                        }

                        // bottom-left to upper-right diagonal
                        count = 0;
                        if ( ( i + j ) == ( dim - 1) )
                        {
                            for (int k=0; k<dim; k++)
                            {
                                if ( k == j )
                                    continue;

                                if ( ( board[dim - 1 - k, k] == CellSelection.X ) || ( which[ ( dim * 2 ) + 1 ] ) )
                                {
                                    count = 0;
                                    break;
                                }
                                else if ( board[dim - 1 - k, k] == CellSelection.N )
                                {
                                    tmpBestSpots[count, 0] = dim - 1 - k;
                                    tmpBestSpots[count, 1] = k;
                                    count++;
                                }
                            }
                        }
                        if ( ( count < min ) && ( count > 0 ) )
                        {
                            min = count;
                            bestSpotsLength = count;
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[k, 0] = tmpBestSpots[k, 0];
                                bestSpots[k, 1] = tmpBestSpots[k, 1];
                            }
                            which[ ( dim * 2 ) + 1 ] = true;
                        }
                        else if ( count == min )
                        {
                            for (int k=0; k<count; k++)
                            {
                                bestSpots[bestSpotsLength, 0] = tmpBestSpots[k, 0];
                                bestSpots[bestSpotsLength, 1] = tmpBestSpots[k, 1];
                                bestSpotsLength++;
                            }
                            which[ ( dim * 2 ) + 1 ] = true;
                        }
                    }
                    else if ( board[i, j] == CellSelection.N )
                    {
                        availableSpots[availableSpotsLength, 0] = i;
                        availableSpots[availableSpotsLength, 1] = j;
                        availableSpotsLength++;
                    }
                }
            }

            Random rand = new Random();
            int randomNum;
            if ( bestSpotsLength == 0 )
            {
                randomNum = rand.Next(availableSpotsLength);		// this gets a random number between 0 and availableSpotsLength
                coord.X = availableSpots[randomNum, 0];
                coord.Y = availableSpots[randomNum, 1];
            }
            else
            {
                randomNum = rand.Next(bestSpotsLength);			// this gets a random number between 0 and bestSpotsLength
                coord.X = bestSpots[randomNum, 0];
                coord.Y = bestSpots[randomNum, 1];
            }
            return coord;
        }


        //-----------------------------------------------------------
        // This function determines if the computer can either win
        // the game, or block the user from winning the game.
        //
        // Input:
        //		player - CellSelection.X or CellSelection.O.
        //               This is the player to check if they're one
        //               away.
        //
        // Returns:
        //		Point - coordinate point that the computer should
        //              play in to win or block the player from winning.
        //              This will be (-1, -1) if the computer cannot
        //              win or block.
        //-----------------------------------------------------------
        private Point isOneAway(CellSelection player)
        {
            Point coord = new Point();
            bool canWin = false;

            CellSelection opponent;
            if (player == CellSelection.O) { opponent = CellSelection.X; }
            else { opponent = CellSelection.O; }

            for (int i=0; i<dim; i++)
            {
                for (int j=0; j<dim; j++)
                {
                    if ( board[i, j] == player )
                    {
                        // check the verticals
                        for (int k=0; k<dim; k++)
                        {
                            if ( k == i )
                                continue;

                            if ( board[k, j] == opponent )
                            {
                                canWin = false;
                                break;
                            }
                            else if ( board[k, j] == CellSelection.N )
                            {
                                if ( canWin )
                                {
                                    canWin = false;
                                    break;
                                }
                                canWin = true;
                                coord.X = k;
                                coord.Y = j;
                            }
                        }
                        if ( canWin )
                            break;

                        // check the horizontals
                        for (int k=0; k<dim; k++)
                        {
                            if ( k == j )
                                continue;

                            if ( board[i, k] == opponent )
                            {
                                canWin = false;
                                break;
                            }
                            else if ( board[i, k] == CellSelection.N )
                            {
                                if ( canWin )
                                {
                                    canWin = false;
                                    break;
                                }
                                canWin = true;
                                coord.X = i;
                                coord.Y = k;
                            }
                        }
                        if ( canWin )
                            break;

                        // if the square is on a diagonal, check it
                        if ( i == j )
                        {
                            // upper-left to bottom-right diagonal
                            for (int k=0; k<dim; k++)
                            {
                                if ( k == i )
                                    continue;

                                if ( board[k, k] == opponent )
                                {
                                    canWin = false;
                                    break;
                                }
                                else if ( board[k, k] == CellSelection.N )
                                {
                                    if ( canWin )
                                    {
                                        canWin = false;
                                        break;
                                    }
                                    canWin = true;
                                    coord.X = k;
                                    coord.Y = k;
                                }
                            }
                        }
                        if ( canWin )
                            break;

                        // bottom-left to upper-right diagonal
                        if ( ( i + j ) == ( dim - 1) )
                        {
                            for (int k=0; k<dim; k++)
                            {
                                if ( k == j )
                                {
                                    continue;
                                }

                                if ( board[dim - 1 - k, k] == opponent )
                                {
                                    canWin = false;
                                    break;
                                }
                                else if ( board[dim - 1 - k, k] == CellSelection.N )
                                {
                                    if ( canWin )
                                    {
                                        canWin = false;
                                        break;
                                    }
                                    canWin = true;
                                    coord.X = dim - 1 - k;
                                    coord.Y = k;
                                }
                            }
                        }
                    }
                }
                if (canWin) { break; }
            }

            if (!canWin) {
                coord.X = -1;
                coord.Y = -1;
            }
            return coord;
        }

        //-----------------------------------------------------------
        // This function checks if the space is available to play.
        // This is specifically designed for a 3x3 board and will
        // not work otherwise
        //
        // Input:
        //		row - cell row
        //      col - cell column
        //
        // Returns:
        //		true  - space can be played
        //		false - space is taken and cannot be played
        //-----------------------------------------------------------
        public bool isOpen(int row, int col)
        {
            if ( board[row, col] != CellSelection.N ) { return false; }
			else { return true; }
        }
    }
}
