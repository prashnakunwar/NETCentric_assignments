using System;

class Week
{
    private string[] days = new string[7];

    public string this[int index]
    {
        get { return days[index]; }
        set { days[index] = value; }
    }
}

class IndexersProgram
{
    static void Main(string[] args)
    {
        Week week = new Week();
        string[] names = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        for (int i = 0; i < 7; i++)
        {
            week[i] = names[i];
        }

        Console.WriteLine("Days of the week:");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(week[i]);
        }
    }
}