using System;

class EventProgram
{
    public event Action MyEvent;

    static void Main(string[] args)
    {
        EventProgram obj = new EventProgram();
        obj.MyEvent += obj.ShowMessage;
        obj.MyEvent();
    }

    void ShowMessage()
    {
        Console.WriteLine("Event triggered!");
    }
}