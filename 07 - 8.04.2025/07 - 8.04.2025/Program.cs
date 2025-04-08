int[] data = { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };
int[] data2 = { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };

MaxHeap<int> maxHeap = new MaxHeap<int>(data2);



Console.WriteLine(maxHeap);


foreach (var item in maxHeap)
{
    Console.WriteLine(item);
}

//maxHeap.HeapSort();
//Console.WriteLine("After HeapSort");
//Console.WriteLine(maxHeap);

maxHeap.HeapInsert(12);
Console.WriteLine($"After HeapInsert: {maxHeap}");

