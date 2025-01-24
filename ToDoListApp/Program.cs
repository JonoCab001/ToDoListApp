using System.Collections.Generic;

List<string> toDoList = new List<string>();

while (true)
{
    // Display the tasks in the to-do list
    if (toDoList.Count > 0)
    {
        Console.WriteLine("** To-do list **");

        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine("- " + toDoList[i]);
        }

        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("No tasks are currently in the list");
        Console.WriteLine("");
    }

    Console.WriteLine("1. Add a Task");
    Console.WriteLine("2. Delete Task");
    Console.WriteLine("3. Quit");

    int choice = int.Parse(Console.ReadLine());

    // Add a Task to the to-do list
    if (choice == (int)UserChoice.AddTask)
    {
        Console.Write("Please Enter Task here: ");
        string task = Console.ReadLine();
        toDoList.Add(task);
        Console.Clear();
        Console.WriteLine("Task has been added successfully! :)");
    }
    // Delete a task from the list by entering a Task number
    else if (choice == (int)UserChoice.DeleteTask)
    {
        if (toDoList.Count > 0)
        {
            Console.WriteLine("Please enter the number of a task you want to delete: ");

            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
            }

            int taskNumb = int.Parse(Console.ReadLine());
            taskNumb--;

            if (taskNumb >=  0 && taskNumb < toDoList.Count)
            {
                toDoList.RemoveAt(taskNumb);
                Console.Clear();
                Console.WriteLine("Successfully Deleted Task!");
                Console.WriteLine("");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, task number is invalid :(");
                Console.WriteLine("");
            }
        }
    }
    // Exit the application
    else if (choice == (int)UserChoice.Exit) {
        break;
    }
}

// User Choices
enum UserChoice
{
    AddTask = 1,
    DeleteTask,
    Exit
}