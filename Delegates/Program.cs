using System;

delegate int MathOperation(int a, int b);

class DelegateProgram
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main(string[] args)
    {
        MathOperation op;

        op = Add;
        Console.WriteLine("Add: " + op(10, 5));

        op = Subtract;
        Console.WriteLine("Subtract: " + op(10, 5));

        op = Multiply;
        Console.WriteLine("Multiply: " + op(10, 5));
    }
}