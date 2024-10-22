using Ufar.Homework;

Console.WriteLine("Hello, World!");

EasyStack<int> easyStack = new EasyStack<int>();
easyStack.Push(1);
easyStack.Push(2);
easyStack.Push(3);
easyStack.Push(4);


easyStack.Pop();

ArrayStack<string> arrayStack = new ArrayStack<string>();

arrayStack.Push("Hello");
arrayStack.Push("World");
arrayStack.Push("!");
arrayStack.Push("!");
arrayStack.Push("!");

arrayStack.Pop();
arrayStack.Pop();
arrayStack.Pop(); 

Console.WriteLine(arrayStack.Peek()); // without removing the element

ListQueue<string> listQueue = new ListQueue<string>();
listQueue.Enqueue("I");
listQueue.Enqueue("will");
listQueue.Enqueue("be");
listQueue.Enqueue("back");
listQueue.Enqueue("soon");

Console.WriteLine(listQueue.Dequeue());
Console.WriteLine(listQueue.Dequeue());
Console.WriteLine(listQueue.Dequeue());


int[] array = { 64, 34, 25, 12, 22, 11, 90 };
SortingAlgorithms.InsertionSortRecursive(array);

// Print the sorted array
foreach (var item in array)
{
    Console.WriteLine(item);
}
