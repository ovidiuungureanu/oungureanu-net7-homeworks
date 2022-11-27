
// Declare a bi-dimensional array {123, 345, 567}, {12, 56, -12}, {34, -98, 65}, {765, 543, 321}
// Print the two elements in the center of the matrix using position indexes (56, -98)

using System.Runtime.CompilerServices;

int[,] Array = new int[4, 3]
{
    {123, 345, 567},
    {12, 56, -12},
    {34, -98, 65},
    {765, 543, 321}
};

int rows = Array.GetLength(0);
int cols = Array.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(Array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(Array[1, 1]);
Console.WriteLine(Array[2, 1]);


// Create a list of names.
// Check if that list has "Ana" (or any other name read from the user) as an element,
// if not add it to the list and print it

Console.WriteLine("Insert name");
List<string> Names = new List<string> {"Ovidiu", "Vlad", "Alina", "Nicoleta", "Gabriel"};
string Name = Console.ReadLine();

if (Names.Contains(Name))
{
    Console.WriteLine("The list has " + Name);
}
else
{
    Names.Add(Name);
    Names.ForEach(Name => Console.WriteLine(Name + " "));
}


// Create a stack that has two integer elements which are read from the user one by one.
// Check the two given integers, and print "true" if one of them is 30 or if their sum is 30.
// Otherwise print "false"

Console.WriteLine("Insert First Element");
int w = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert Second Element");
int e = Convert.ToInt32(Console.ReadLine());

Stack<int> stack = new Stack<int>();
stack.Push(w);
stack.Push(e);

foreach (int o in stack)
    Console.WriteLine(o + "");

if (w == 30 || e == 30 || w + e == 30)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}


// Using a queue which has 5 elements (read from the user and added to the queue one by one).
// Check if the top of the queue is a positive number and a multiple of 3 or a multiple of 7.
// If not remove the top of the queue and print the new top of the queue.

Console.WriteLine("Insert 5 numbers");
int el1 = Convert.ToInt32(Console.ReadLine());
int el2 = Convert.ToInt32(Console.ReadLine());
int el3 = Convert.ToInt32(Console.ReadLine());
int el4 = Convert.ToInt32(Console.ReadLine());
int el5 = Convert.ToInt32(Console.ReadLine());

Queue<int> Elements = new Queue<int>();
Elements.Enqueue(el1);
Elements.Enqueue(el2);
Elements.Enqueue(el3);
Elements.Enqueue(el4);
Elements.Enqueue(el5);

if (el1 >= 0 && el1 % 3 == 0 || el1 % 7 == 0)
{
    Console.WriteLine("checked");
}
else
{
    Elements.Dequeue();
    Console.WriteLine("The new top is: " + Elements.Peek());
}









































































