using RationalNS;

Rational r1 = new Rational();

Rational r2 = new Rational(3, 4);


Console.WriteLine(r1);
Console.WriteLine(r2);

Rational r3 = new Rational(6, 8);
Console.WriteLine(r3);

Rational r4 = r2 + r3;


Console.WriteLine();

List<Rational> lst = new List<Rational>();
lst.Add(new Rational(1, 2));
lst.Add(new Rational(3, 8));
lst.Add(new Rational(3, 4));
lst.Add(new Rational(1, 1));
lst.Add(new Rational(1, 8));
lst.Add(new Rational(7, 8));


lst.Sort();
foreach (var rational in lst)
{
    Console.WriteLine(rational);
}

Console.WriteLine();
lst.Sort((x, y) =>  -x.CompareTo(y));
foreach (var rational in lst)
{
    Console.WriteLine(rational);
}


Console.WriteLine();
lst.Sort(Rational.DescendingSort);
foreach (var rational in lst)
{
    Console.WriteLine(rational);
}