//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//var userChoice = Console.ReadLine();

//// todo: Handle user input.)
//if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO.");
//}
//else if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs.");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO.");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit.");
//}

//void PrintSelectedOption(string selectedOption) {
//    Console.WriteLine("User selected: " + selectedOption);
//}

//Console.WriteLine("User Input: " + userChoice);


//// Add method
//int Add(int num1, int num2)
//{
//    return num1 + num2;
//}

//int result = Add(23, 23);

//Console.WriteLine("The result is: " + result);

//// Is longer than 10 characters method

//bool result2 = IsLongerThan10Characters("My longest message.");

//bool IsLongerThan10Characters(string message)
//{
//    return message.Length > 10;
//}

//Console.WriteLine("Is your message longer than 10 characters? " + result2);

//Console.ReadKey();


//Console.WriteLine("Provide a number.");

//int number = int.Parse(Console.ReadLine());

//Console.WriteLine("The number you entered is: " + number);

//Console.ReadKey();

/*  
 *  This 
 *  is 
 *  a 
 *  multi-line
 *  comment
*/

// Variable Declaration and Initialization
//string userInput = "A";
//Console.WriteLine(userInput);

//userInput = "B";
//Console.WriteLine(userInput);

//int number = 0;
//number = 7;
//number = 8;
//number = 9;

//int num1 = 1, num2 = 5;

//string fName, lName;

//Console.WriteLine(number);

// Naming variables in C#
// Cannot use reserved words as a variable name.
// int int = 100; --> Fails

// The first character cannot be a digit.
// int 2num = 2; --> Fails

// C# is case sensitive so count and Count are two difference variables.
//int count = 2;
//Count = 2;
// Fails --> Count is not defined.



////////////////////////////// OPERATORS ///////////////////////////////
//int a = 5;
//a++;
//int b = 20;
//b--;

//Console.WriteLine("ADDITION: " + (a + b));
//Console.WriteLine("SUBTRACTION: " + (a - b));
//Console.WriteLine("MULTIPLICATION: " + a * b);
//Console.WriteLine("DIVISION: " + a / b);

//Console.WriteLine("Shane" + " " + "Kobylecky," + " I am " + 23 + " years old.");

//// Implicity Typed Variables.
//// Must be initialized. The complier has to be able to infer the type.
//var fName = "Shane";
//var age = 26;

//fName = "Kobylecky";