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


//Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("Hello World!");

Random rnd = new Random();
List<Shape> shapes = new List<Shape>();
for(int i = 0; i < 10; i++)
{
    int r = rnd.Next(2);
    switch(r)
    {
        case 0:
            shapes.Add(
                new Circle(
                    center: new Point(rnd.NextDouble() * 100, rnd.NextDouble() * 100), 
                    radius: rnd.NextDouble() * 100));
            break;
        case 1:
            shapes.Add(new Rectangle(
                origin: new Point(rnd.Next(1, 20), rnd.Next(1, 20)), 
                width: rnd.NextDouble() * 100, 
                height: rnd.NextDouble() * 100));
            break;
    }
}

foreach(var item in shapes)
    item.Draw();

Console.WriteLine($"Total area: {shapes.Sum(item => item.Area())}");

