
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;

// Loops - homework

// Exercise 1
// Given an array of integer numbers, print the total of all the values that are even numbers.
// [1, 2, 3, 4, 5] -> total = 6

int[] Array = { 1, 2, 3, 4, 5 };
int sum = 0;

foreach (int i in Array)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}
Console.WriteLine("Total of all even values is " + sum);

// Exercise 2
// Find if an array of integer numbers contains duplicates and display them if so.
// [1, 2, 3, 3, 4] -> 3

int[] Array1 = { 1, 2, 3, 3, 4 };

for (int i = 0; i < Array1.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < Array1.Length; j++)
    {
        if (Array1[i] == Array1[j])
        {
            count++;
        }
    }
    if (count > 1)
    {
        Console.WriteLine("Duplicate number is " + Array[i]);
    }
}


// Exercise 3
// Check if there are duplicates in a list of strings. If yes, remove them.
// {"a", "b", "b", "c", "c", "d"} -> {"a", "b", "c", "d"}

List<string> x = new List<string>() { "a", "b", "b", "c", "c", "d" };
List<string> n = new List<string>();

foreach (string value in x)
{
    if (!n.Contains(value))
    {
        n.Add(value);
    }
}
foreach (string value in n)
{
    Console.WriteLine(value);
}


// Exercise 4
// Write a program to count the frequency of each element in an array.
// [1, 4, 5, 2, 1, 4, 3, 1, 2] -> 1- 3 times, 4- 2 times, 5- one time, 2- 2 times, 3- one time

int[] Array2 = { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
int[] dup = new int[Array2.Length];
int a, b;

for ( a = 0; a < Array2.Length; a++)
{
    int count = 0;
    for ( b = 0; b < Array2.Length; b++)
    {
        if (Array2[a] == Array2[b])
        {
            count++;
        }
    }
    if (count != 1)
    {
        Console.WriteLine("Number " + Array2[a] + "  " + count + " times");
    }
    else
    {
        Console.WriteLine("Number " + Array2[a] + "  one time");
    }
}

// Exercise 5
// Read an array from the console and separate odd and even values into 2 arrays.
// [3, 4, 5, 6, 7, 8] -> Odd array: [3, 5, 7]    Even array: [4, 6, 8]

int[] arr = new int[6];
int[] even = new int[6];
int[] odd = new int[6];
Console.WriteLine("Enter 6 array values");
for (int i = 0; i < 6; i++)
{
    Console.Write("Value  ", i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int o = 0;
int e = 0;
for (int i= 0; i < 6; i++)
{
    if (arr[i] % 2 == 0)
    {
        even[e] = arr[i];
        e++;
    }
    else
    {
        odd[o] = arr[i];
        o++;
    }
}

Console.WriteLine("Odd array: ");
for (int i= 0; i < o; i++)
{
    Console.Write("{0}, ", odd[i]);
}

Console.WriteLine();
Console.WriteLine("Even array: ");
for (int i= 0; i < e; i++)
{
    Console.Write("{0}, ", even[i]);
}






















































































































































































