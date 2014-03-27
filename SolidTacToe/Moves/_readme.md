# SolidTacToe.Moves

Contains everything you need to know about moves.

The Move class actually changes the state of the Grid, and contains information about that move.

MoveTracker keeps track of the current and next players.

MoveValidator ensures that the move can be made.

NoMoveAvailableException is hopefully self explanatory. :)

ValidMoveProvider is a IMoveProvider that guaruntees that the IMove returned is able to be applied.