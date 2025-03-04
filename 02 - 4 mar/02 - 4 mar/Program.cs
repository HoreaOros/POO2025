
Complex c1 = new Complex(3, 4); // 3 + 4i
Complex c2 = new Complex(2, -5); // 2 - 5i
Console.WriteLine(c1);
Console.WriteLine(c2);

//Complex c3 = c1.Add(c2);
//Console.WriteLine(c3);

Complex c4 = c1.Multiply(c2);
Console.WriteLine(c4);

Console.WriteLine($"Modulul lui {c1} este {c1.Modul}");
Console.WriteLine($"Argument lui {c1} este {c1.Argument}");

Complex c5 = c1 + c2;
Console.WriteLine(c5);


c1 = new Complex(1, 2);
c2 = new Complex(1, 2);
if(c1 == c2)
    Console.WriteLine("Egale");
else
    Console.WriteLine("Nu sunt egale");

string s1 = "abc";
string s2 = "abc";
if (s1 == s2)
    Console.WriteLine("Egale");
else
    Console.WriteLine("Nu sunt egale");