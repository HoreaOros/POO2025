/**** POINT ***************************/
Point p1 = new Point(1, 2);
Console.WriteLine(p1);

Point p2 = new Point(4, 5);
Console.WriteLine(p2);

Point p3 = new Point();
Console.WriteLine(p3);
/*******************************/


/**** Rectangle ***************************/
Rectangle rectangle = new Rectangle(p1, p2);
Rectangle rectangle2 = new Rectangle(p1, 5, 6);
/*******************************/


/**** Circle ***************************/
Circle circle = new Circle(new Point(3, 4), 42);
Circle circle2 = new Circle();
/*******************************/

circle.Color = Color.Yellow;


Shape shape = new Circle(new Point(3, 4), 42);
shape.Color = Color.Red;

