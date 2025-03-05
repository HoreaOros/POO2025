Complex c1 = new Complex(3, 4);
Console.WriteLine(c1);
Complex c2 = new Complex(2, -3);
Console.WriteLine(c2);

//Complex c3 = c1.Add(c2);
//Console.WriteLine($"{c1} + {c2} = {c3}");

Complex c4 = c1.Multiply(c2);
Console.WriteLine($"{c1} * {c2} = {c4}");

Complex c5 = c1 + c2;

Console.WriteLine($"{c1} + {c2} = {c5}");

Complex c6 = new Complex(1, 2);
Complex c7 = new Complex(1, 2);
if (c6 == c7)
    Console.WriteLine("Egale");
else
    Console.WriteLine("Nu sunt egale");


string s1 = "abc";
string s2 = "abc";
if (s1 == s2)
    Console.WriteLine("Egale");
else
    Console.WriteLine("Nu sunt egale");
