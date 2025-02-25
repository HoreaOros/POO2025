Point p = new Point(3, 4);
Console.WriteLine(p);


Point p2 = new Point(1, 5);

Console.WriteLine($"Distanta euclidiana dintre {p} si {p2} este {p.EuclideanDistanceTo(p2)}");
Console.WriteLine($"Distanta Manhattan dintre {p} si {p2} este {p.ManhattanDistanceTo(p2)}");