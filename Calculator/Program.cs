Console.WriteLine("Hello!");

bool shouldStillRun = true;

while(shouldStillRun) {
    // Store the first number.
    Console.WriteLine("Input your first number:");
    int num1 = int.Parse(Console.ReadLine());

    // Store the second number.
    Console.WriteLine("Input your second number:");
    int num2 = int.Parse(Console.ReadLine());

    // Write the menu to the console.
    Console.WriteLine("What calculation would you like to perform?");
    Console.WriteLine("[A]dd numbers together.");
    Console.WriteLine("[S]ubtract numbers from one another.");
    Console.WriteLine("[M]ultiply numbers together.");
    Console.WriteLine("[D]ivide numbers by one another.");

    // Read in the operator.
    string operation = Console.ReadLine().ToUpper();
    string operand = "";

    int value = DetermineValue(num1, num2, operation);

    int DetermineValue(int num1, int num2, string operation) {
        switch (operation)
        {
            case "A":
                operand = "+";
                return num1 + num2;
            case "S":
                operand = "-";
                return num1 - num2;
            case "M":
                operand = "*";
                return num1 * num2;
            case "D":
                operand = "/";
                return num1 / num2;
            default:
                return -1;
        }
    }

    void PrintMessage(int num1, int num2, int value, string operand)
    {
        Console.WriteLine($"{num1} {operand} {num2} = {value}");
    }

    if (value != -1) {
        PrintMessage(num1, num2, value, operand);
    }


    // Determine if the user is done or wants to continue.
    Console.WriteLine("Press 'C' to continue or any other key to exit.");

    string response = Console.ReadLine().ToUpper();

    shouldStillRun =  response == "C";
}

