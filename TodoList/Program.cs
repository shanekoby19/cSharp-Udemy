// Greeting & Initial Options

string selection = "";
List<string> todos = new List<string>();

do
{
    Console.WriteLine();
    Console.WriteLine("Hello!");
    Console.WriteLine();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");
    Console.WriteLine();


    selection = Console.ReadLine().ToUpper();

    switch(selection) {
        case "S":
            PrintTodos(todos);
            break;
        case "A":
            AddTodo(todos);
            break;
        case "R":
            RemoveTodo(todos);
            break;
        case "E":
            break;
        default:
            Console.WriteLine("Invalid option selected, please try again.");
            break;
    }
} while (selection != "E");

void PrintTodos(List<string> todos){
    Console.WriteLine("TODO List: ");
    Console.WriteLine();
    int counter = 1;
    foreach(string todo in todos) {
        Console.WriteLine($"[{counter}]: {todo}");
        counter++;
    }
}

void AddTodo(List<string> todos) {
    Console.WriteLine("Write the todo you would like to add then press 'Enter'.");
    string todo = Console.ReadLine();

    if(todos.IndexOf(todo) != -1) {
        Console.WriteLine("This todo already exists, please try again.");
    } else {
        todos.Add(todo);
        Console.WriteLine($"TODO added successfully: {todo}");
    }
}

void RemoveTodo(List<string> todos) {
    // Print a menu to show the user what they can delete.
    bool isSuccessfullyRemoved = false;
    do {
        // Check to see if there are any todos to delete.
        if(todos.Count == 0) {
            Console.WriteLine("You don't have any todos to delete at this time.");
            return;
        }

        // Print the delete menu.
        Console.WriteLine("Enter the number of the todo you would like to delete.");
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"[{i + 1}]: {todos[i]}");
        }
        string selection = Console.ReadLine();

        // Check to see if the value is numeric.
        bool isNumeric = int.TryParse(selection, out int index);

        if (!isNumeric) {
            Console.WriteLine($"The value you entered '{selection}' is not a number.");
            continue;
        }

        // Check to see if the value entered is within the bounds.
        if(index - 1 < 0 || index - 1 >= todos.Count) {
            Console.WriteLine($"The value you entered '{index}' is not in the list.");
            continue;
        }

        // Remove the item and end the loop.
        todos.RemoveAt(index - 1);
        isSuccessfullyRemoved = true;

    } while (!isSuccessfullyRemoved);
}




