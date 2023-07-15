//Console.WriteLine("Hello!");

//bool shouldStillRun = true;

//while(shouldStillRun) {
//    // Store the first number.
//    Console.WriteLine("Input your first number:");
//    int num1 = int.Parse(Console.ReadLine());

//    // Store the second number.
//    Console.WriteLine("Input your second number:");
//    int num2 = int.Parse(Console.ReadLine());

//    // Write the menu to the console.
//    Console.WriteLine("What calculation would you like to perform?");
//    Console.WriteLine("[A]dd numbers together.");
//    Console.WriteLine("[S]ubtract numbers from one another.");
//    Console.WriteLine("[M]ultiply numbers together.");
//    Console.WriteLine("[D]ivide numbers by one another.");

//    // Read in the operator.
//    string operation = Console.ReadLine().ToUpper();
//    string operand = "";

//    int value = DetermineValue(num1, num2, operation);

//    int DetermineValue(int num1, int num2, string operation) {
//        switch (operation)
//        {
//            case "A":
//                operand = "+";
//                return num1 + num2;
//            case "S":
//                operand = "-";
//                return num1 - num2;
//            case "M":
//                operand = "*";
//                return num1 * num2;
//            case "D":
//                operand = "/";
//                return num1 / num2;
//            default:
//                return -1;
//        }
//    }

//    void PrintMessage(int num1, int num2, int value, string operand)
//    {
//        Console.WriteLine($"{num1} {operand} {num2} = {value}");
//    }

//    if (value != -1) {
//        PrintMessage(num1, num2, value, operand);
//    } else {
//        Console.WriteLine("Whoops, it looks like you selected an invalid option.");
//    }


//    // Determine if the user is done or wants to continue.
//    Console.WriteLine("Press 'C' to continue or any other key to exit.");

//    string response = Console.ReadLine().ToUpper();

//    shouldStillRun =  response == "C";
//}


// Array Notes
// int[] declares a type of "Integer Array"
// numbers is the name give to the variable.
// new int[3]; initializes the array to a size of three.
// new is a keyword used to create a new instance of a class.
// In this case we are creating and a new instance of the interger array class.

// Array initializers can be used to initalize an array with given values.
// By default arrays are initialized with the value 0.
//int[] numbers = new int[5];
//int[] numbers = new int[] { 0, 0, 0, 22, 17 };

//Console.WriteLine("Element at index 0 is: " + numbers[0]);
//Console.WriteLine("Element at index 1 is: " + numbers[1]);
//Console.WriteLine("Element at index 2 is: " + numbers[2]);

//numbers[3] = 42;
//numbers[4] = 99;

//// ^operator will allow you to access an offset from the end of the array.
//// The following lines of code are equalivant.
//Console.WriteLine("Element at index 4 is: " + numbers[numbers.Length - 1]);
//Console.WriteLine("Element at index 4 is: " + numbers[^1]);

//// Calculate the sum of the array.

// 2-dimensional arrays.
//char[,] letters = new char[2, 3];

//letters[0, 0] = 'A';
//letters[0, 1] = 'B';
//letters[0, 2] = 'C';
//letters[1, 0] = 'D';
//letters[1, 1] = 'E';
//letters[1, 2] = 'F';

//for(int i = 0; i < letters.Length; i++) {

//}

//Console.ReadKey();

//// ForEach Loop
//var words = new string[] { "one", "two", "three", "four" };

//foreach(var word in words) {
//    Console.WriteLine(word);
//}

//// LISTS
//List<string> words = new List<string>() { "one", "two", "three" };
//Console.WriteLine("Count of elements is: " + words.Count);

//words.Add("Hello");
//Console.WriteLine("Count of elements is: " + words.Count);

//// Remove an element from the list.
//// If no matching element is found, nothing happens.
//words.Remove("two");

//// AddRange() -> Adds another collection to a list.
//words.AddRange(new string[] { "two", "three" });

//// RemoveAt() -> removes an element at a specified position.
//words.RemoveAt(1);

//foreach(string word in words)
//{
//    Console.WriteLine(word);
//}

//Console.ReadKey();

//// OUT KEYWORD

//List<int> GetPositiveNumbers(int[] numbers, out int countOfNonPositives) {
//    List<int> positiveNumbers = new List<int>();

//    foreach (int number in numbers) {
//        if(number >= 0) {
//            positiveNumbers.Add(number);
//        }
//    }

//    countOfNonPositives = numbers.Length - positiveNumbers.Count;

//    return positiveNumbers;
//}

//int[] numbers = new int[] { 10, -8, 2, 12, -17, 0, 18, -100, -2};

//int countOfNonPositives = 0;
//List<int> positiveNumbers = GetPositiveNumbers(numbers, out countOfNonPositives);

//foreach(int positiveNumber in positiveNumbers) {
//    Console.WriteLine(positiveNumber);
//}

//Console.WriteLine($"The number of non-positive integers is: {countOfNonPositives}");

// TryParse() -> Uses the out parameter to safely parse your value or return an error.


bool isParsingSuccessful = false;
do
{
    Console.WriteLine("Enter a number:");
    string userInput = Console.ReadLine();

    isParsingSuccessful = int.TryParse(userInput, out int number);

    if (isParsingSuccessful) {
        Console.WriteLine($"Great job, you entered {number}");
    }
    else {
        Console.WriteLine($"Parsing was not successful, '{userInput}' is not a number.");
    }
} while (!isParsingSuccessful);





Console.ReadKey();

