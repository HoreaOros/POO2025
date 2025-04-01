
//Queue<int> Q =  new Queue<int>();
//for(int i = 1; i <= 10; i++)
//    Q.Enqueue(i);

//while (Q.Count > 0)
//    Console.WriteLine(Q.Dequeue());




PriorityQueue<int, int> PQ = new PriorityQueue<int, int>();


for (int i = 2; i <= 100; i++)
    PQ.Enqueue(i, -NDiv(i));

while(PQ.Count > 0)
{
    int nr = PQ.Dequeue();
    Console.WriteLine($"{nr} - {NDiv(nr)}");
}

int NDiv(int nr)
{
    int r = 0;
    int d;
    for(d = 1; d * d < nr; d++)
        if (nr % d == 0)
        {
            r += 2;
        }
    if (d * d == nr)
        r++;
    return r;
}