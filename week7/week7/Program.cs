
using System.Reflection.Metadata;
using week7;

// Exercise 1

new DateCheck().CheckIfDateIsInThePast();

// Exercise 2

new Names().ReadAndCheckNames();

// Exercise 3




// Exercise 4

Work.Run();
public static class Work
{
    public static void Run()
    {
        string path = @"D:\GIT\oungureanu-net7-homeworks\week7\week7\Ex4\file.txt";

        try
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch(FileNotFoundException exception)
        {
            Console.WriteLine("File does not exist");
        }
        catch(NullReferenceException exception)
        {
            Console.WriteLine("Enter text to file");
        }
        catch(IOException exception)
        {
            Console.WriteLine("I/O error");
        }
    }
}













































