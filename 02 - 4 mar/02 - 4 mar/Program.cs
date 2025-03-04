
Complex c1 = new Complex(3, 4); // 3 + 4i
Complex c2 = new Complex(2, -5); // 2 - 5i
Console.WriteLine(c1);
Console.WriteLine(c2);

Complex c3 = c1.Add(c2);
Console.WriteLine(c3);

Complex c4 = c1.Multiply(c2);
Console.WriteLine(c4);

Console.WriteLine($"Modulul lui {c1} este {c1.Modul}");