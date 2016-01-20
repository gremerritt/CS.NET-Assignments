This assignment attempts to utilize most of the skills you have learned up to this point. It involves creating a simple drawing program. 

A number of key requirements need to be followed.

  - Use an ArrayList or generic List<> to save each graphic object for painting.
  - Undo deletes the last graphics object in the list. Be sure the program doesn’t crash if you try to undo an empty list.
  - Create a base class from which all graphics elements are derived. This class has a Draw method that is declared virtual and is overridden in each derived class. It has one argument which is a Graphics object.
  - The constructor for each derived graphic object takes arguments of your choice such as the brush, pen, dimensions and location.
  - You draw the objects with a foreach loop with a call to Draw. Polymorphism handles invoking the Draw method in the appropriate class.
  - The form consists of a menu strip, a panel docked to the top, and a panel docked with the fill style. These controls should be added in the above order to ensure correct operation.
  - The mouse event handler for the drawing panel must be created for that panel and not the main form or the mouse coordinates will not be relative to the panel.
  - You must also use a paint event handler for the panel and not the form for drawing your graphics objects.
  - All objects are drawn with two mouse clicks. This sets the boundaries of the box containing the object.
  - You should be able to click on any two opposite corners and not just the upper left and lower right.
  - You must adjust the fill of a filled object to account for the width of the border (outline). For example, if the border is 10 pixels then the dimensions of the fill must be reduced by 5 pixels along each border. Think about how to accomplish this. There is an easy and a hard way. (Z-order?)
  - If no fill or outline is specified then an object is not drawn and not added to the list.
  - You will need to keep a state variable to determine whether a mouse click is the first or second. The object is added on the second click.
