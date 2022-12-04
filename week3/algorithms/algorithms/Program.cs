using System.Collections.Concurrent;
using System.Globalization;


// Algorithms

// 1. Bubble Sort

int[] array = new int[] {9, 22, 6, 7, 1};
int v, k, aux;

for (v = 0; v < array.Length - 1; v++)
{
    for (k = v + 1; k < array.Length; k++)
    {
        if(array[v] > array[k])
        {
            aux = array[v];
            array[v] = array[k];
            array[k] = aux;
        }
    }
}
Console.WriteLine("Sorted array:");

for (v = 0; v < array.Length; v++)
{
    Console.Write(array[v] + " ");
}


// 2. Insertion Sort

Console.WriteLine();

int[] ar = new int[] {-3, 7, 43, -8, 5, 99};
int y, z, temporary;

for (y = 1; y < ar.Length; y++)
{
    temporary = ar[y];
    z = y - 1;
    while (z >= 0 && ar[z] > temporary)
    {
        ar[z+1] = ar[z];
        z--;
    }
    ar[z+1] = temporary;
}
Console.WriteLine("Sorted array:");

for (y = 0; y < ar.Length; y++)
{
    Console.Write(ar[y] + " ");
}


// 3. Quick Sort
// 4. Merge Sort


















