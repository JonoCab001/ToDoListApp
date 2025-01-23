using System.Collections.Generic;

List<string> toDoList = new List<string>();

while (true)
{
    Console.WriteLine("1. Add a Task");
    Console.WriteLine("2. Quit");

    int choice = int.Parse(Console.ReadLine());

    if (choice == (int)UserChoice.AddTask)
    {
        Console.Write("Please Enter Task here: ");
        string task = Console.ReadLine();
        toDoList.Add(task);
        Console.Clear();
        Console.WriteLine("Task has been added successfully! :)");
    }
    else if (choice == (int)UserChoice.Exit) {
        break;
    }
}

enum UserChoice
{
    AddTask = 1,
    Exit
}