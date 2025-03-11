using _03___11_mar;
Rational r1 = new Rational();
Rational r2 = new Rational(6, 9);
Rational r3 = new Rational(2, 3);

Console.WriteLine(r2);
Console.WriteLine(r3);

Rational sum = r2.Add(r3);
Console.WriteLine($"{r2} + {r3} = {sum}");

sum = r2 + r3;


List<Rational> lst = new List<Rational>();
lst.Add(new Rational(3, 4));
lst.Add(new Rational(1, 2));
lst.Add(new Rational(3, 8));
lst.Add(new Rational(5, 6));
lst.Add(new Rational(1, 4));
lst.Add(new Rational(7, 8));

lst.Sort();

foreach(var r in lst)
    Console.WriteLine(r);
Console.WriteLine();

//lst.Sort(Rational.DescendingSort);

lst.Sort((x, y) => -x.CompareTo(y));
foreach (var r in lst)
    Console.WriteLine(r);








