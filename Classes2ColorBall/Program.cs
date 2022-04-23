/*
 Try creating the two classes below, and make a simple program to work with them, as
described below
Create a Color class:
On a computer, colors are typically represented with a red, green, blue, and alpha
(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
A constructor that takes a red, green, blue, and alpha value.
A constructor that takes just red, green, and blue, while alpha defaults to 255
(opaque).
Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
A method to get the grayscale value for the color, which is the average of the red,
green and blue values.
Create a Ball class:
The Ball class should have instance variables for size and color (the Color class you just
created). Let’s also add an instance variable that keeps track of the number of times it
has been thrown.
Create any constructors you feel would be useful.
Create a Pop method, which changes the ball’s size to 0.
Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been
popped (has a size of 0).
A method that returns the number of times the ball has been thrown.
Write some code in your Main method to create a few balls, throw them around a few
times, pop a few, and try to throw them again, and print out the number of times that the
balls have been thrown. (Popped balls shouldn’t have changed.)
*/
using Classes2ColorBall;

Color white = new Color(255, 255,255, 255);
Color black = new Color(0, 0, 0, 255);
Color red = new Color(255, 0, 0, 255);
Color green = new Color(0, 255, 0);

Ball wBall = new Ball(4, white, 0);
Ball bBall = new Ball(5, black, 0);
Ball rBall = new Ball(4, red, 0);
Ball gBall = new Ball(7, green, 0);

wBall.ThrowIt();
wBall.ThrowIt();
bBall.ThrowIt();
bBall.Pop();
gBall.ThrowIt();
bBall.ThrowIt();
rBall.ThrowIt();
rBall.ThrowIt();
wBall.ThrowIt();
gBall.ThrowIt();
wBall.Pop();
bBall.ThrowIt();
rBall.ThrowIt();
wBall.ThrowIt();


Console.WriteLine($"wBall was thrown {wBall.GetThrowCount()} times");
Console.WriteLine($"bBall was thrown {wBall.GetThrowCount()} times");
Console.WriteLine($"rBall was thrown {wBall.GetThrowCount()} times");
Console.WriteLine($"gBall was thrown {wBall.GetThrowCount()} times");
