using System;

class Library
{
    private string[] books = new string[3];

    public string this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library lib = new Library();

        lib[0] = "C#";
        lib[1] = "Java";
        lib[2] = "Python";

        Console.WriteLine("Books:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(lib[i]);
        }
    }
}