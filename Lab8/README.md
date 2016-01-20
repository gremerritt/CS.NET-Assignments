# Slide Show Viewer
Start by adding a list box control to your main form. This control is used to show the current file names to be viewed. An Add button and Delete button control the adding and deletion of files to your list box. Add should open a common file open dialog. Delete will delete the file or files you have selected. You should allow selection of multiple file names for the delete operation. The actual files are, of course, not deleted from the disk only from the list box control. You must also allow multiple selections at a time and add them to the existing selections in the list box. Be sure to use an appropriate file filter.

The viewer switches from file to file using a time interval you specify in a standard edit control. The default value should be five seconds. Be sure to check for invalid time intervals. Check out the timer control. It makes this task very simple.

A Show button starts the slide show. A modal window is used for the display. This window has no border, no title bar and no buttons (close, maximize etc.). Its size is set to fill the entire screen. This is easily done by setting the WindowState property to Maximized. After the images are cycled, this window closes in the standard manner for a modal dialog. A premature termination method should be provided by use of the escape key. Use the key press event to accomplish this.

Images should be scaled to fit the entire window while maintaining the aspect ratio. The images should be centered horizontally or vertically as appropriate. If a file is not a valid image file (regardless of its extension) then “Not an image file” should be displayed in its place.

Provide a menu with open and save collection items. Clicking save saves the current list of files to a file with the extension .pix. The format should be a text file with one path name per line. Open reads an existing pix file into the list after it has been cleared. Once again file filters should be used. If the list is empty a message box is displayed and no save operation is performed.

Be careful to test your program thoroughly for subtle errors such as what happens when you try to show when there are no files to show or hitting delete without a selection in the list box. You will lose points for any situation that leads to an unhandled exception.
