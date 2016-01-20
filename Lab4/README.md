In this assignment you will implement the eight queens puzzle. This is a classic problem devised in the 1800's. The first thing you should do is read the article at http://en.wikipedia.org/wiki/Eight_queens_puzzle.

Board
  - The chess board is located at (100, 100). Each square is 50 x 50.
  - The squares (cells) are filled rectangles with a black boarder. The boarder is more obvious when hints are turned on (see below).
  - Size the form to accommodate the board centered.
  - The form title should be Eight Queens by <your name>.

Placing or Removing a Queen
  - A left click in a cell places a queen there if there isn't one there already AND it is a safe cell. A safe cell is one that if a queen is placed there it can't be captured by any queen already on the board.
  - If the cell is occupied or not safe a beep is sounded (see Programming Hints below).
  - Any click outside the board is ignored and no sound is played.
  - A queen is indicated by a large centered Q. The color needs to be set for the black or white squares.
  - A right click in a cell with a queen removes the queen otherwise it is ignored and no sound is played.
  - The count of the number of queens on the board is displayed at the top of the form next to the controls. This count must always be accurate.
  - Add a button in the upper left labeled "Clear" that removes all queens.
  - Display a message indicating that the eighth queen has been added. Enter a valid solution to my example to see the message pop up.

Hints Feature
  - Place a check box in the upper left corner of the form with the label "Hints."
  - When this box is checked all unsafe cells are colored red. See my solution for how this works.
  - You will need to implement the check changed event to cause an instant update when turning this feature on and off.
