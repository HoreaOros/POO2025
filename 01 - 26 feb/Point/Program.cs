Point p1 = new Point(3, 4);
Console.WriteLine(p1);

Point p2 = new Point(4, 5);
Console.WriteLine($"Distanta euclidiana intre {p1} si {p2} este {p1.EuclideanDistance(p2)}");
Console.WriteLine($"Distanta Manhattan intre {p1} si {p2} este {p1.ManhattanDistance(p2)}");