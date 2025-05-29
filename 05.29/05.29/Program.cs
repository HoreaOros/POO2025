// Demonstrating passing by value and by reference in C#
// This example shows how passing by value and by reference works in C#.

// Passing by value means that a copy of the variable is made,
// while passing by reference
// means that a reference to the original variable is passed.


int n = 42;

Console.WriteLine($"Before ValueByValue() n =  {n}.");

ValueByValue(n);

Console.WriteLine($"After ValueByValue() n =  {n}.");
Console.WriteLine($"n =  {n}.");




ValueByReference(ref n);
Console.WriteLine($"After ValueByReference() n =  {n}.");





void ValueByReference(ref int n)
{
    n++;
}

void ValueByValue(int n)
{
    n++;
}



Point point = new Point { x = 1, y = 2 };


Console.WriteLine($"Before PointValueByValue() point =  {point.x}, {point.y}.");

PointValueByValue(point);
Console.WriteLine($"After PointValueByValue() point =  {point.x}, {point.y}.");

void PointValueByValue(Point point)
{
    point.x = 4;
    point.y = 5;
}



/*****************************************/
// Passing by reference with a class
// Classes are reference types, so when you pass a class instance,
// you are passing a reference to the original object.

Person person = new Person { age = 30, name = "John" };
Console.WriteLine($"Before PersonValueByReference() person =  {person.age}, {person.name}.");
PersonByValue(person);
Console.WriteLine($"After PersonValueByReference() person =  {person.age}, {person.name}.");




PersonByReference(ref person);
Console.WriteLine($"After PersonByReference() person =  {person.age}, {person.name}.");

void PersonByReference(ref Person person)
{
    //person.age++;
    //person.name = "Doe";

    person = new Person { age = 35, name = "Bill" }; // Reassigning the reference
}

void PersonByValue(Person person)
{
    person.age++;
    person.name = "Jane";

    person = new Person { age = 25, name = "Alice" }; // This does not affect the original object
}

class Person
{
    public int age;
    public string name;
}

struct Point
{
    public int x, y;
}
