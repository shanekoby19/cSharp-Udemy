//////////////////////////////// DATEIME OBJECT ////////////////////////////////
//DateTime someDay = new DateTime(2023, 2, 9);
//Console.WriteLine("The datetime object you created is: " + someDay.ToLongDateString());
//Console.WriteLine("Year is: " + someDay.Year);
//Console.WriteLine("Month is: " + someDay.Month);
//Console.WriteLine("Day is: " + someDay.Day);
//Console.WriteLine("The day of the week for this date is: " + someDay.DayOfWeek);
//Console.WriteLine("Exactly one year from today, the day of the week for this date will be " + someDay.AddYears(1).DayOfWeek);

///////////////////////////////// ABSTRACTION /////////////////////////////////
// Definition - Hides the implementation details from the user. Allows the user
// to use the class without knowing how it works in detail.
// Analogy - Driving a car - You don't need to know how the engine works, you
// you only need to know how to control it. (steering, gas, ect).
// Public Interface - All of the fields and methods available on an object.

/////////////////////////////// OUR FIRST CLASS ///////////////////////////////
var rectangle1 = new Rectangle(3, 7);
var circumference1 = rectangle1.CalculateCircumference();
var area1 = rectangle1.CalculateArea();

Console.WriteLine("The width of rectangle 1: " + rectangle1.Width);
Console.WriteLine("The height of rectangle 1: " + rectangle1.Height);
Console.WriteLine("The circumference of rectangle 1: " + circumference1);
Console.WriteLine("The area of rectangle 1: " + area1);

var rectangle2 = new Rectangle(8, 30);
var circumference2 = rectangle2.CalculateCircumference();
var area2 = rectangle2.CalculateArea();
Console.WriteLine("The width of rectangle 2: " + rectangle2.Width);
Console.WriteLine("The height of rectangle 2: " + rectangle2.Height);
Console.WriteLine("The circumference of rectangle 2: " + circumference2);
Console.WriteLine("The area of rectangle 2: " + area2);

// Static property
Console.WriteLine("The number of rectangles created so far is: " + Rectangle.NumberOfRectanglesCreated);


// Medical Appointment
MedicalAppointment myMedicalAppointment = new MedicalAppointment("Shane Kobylecky", new DateTime(2023, 7, 18));
MedicalAppointmentPrinter myMedicalAppointmentPrinter = new MedicalAppointmentPrinter();

MedicalAppointmentPrinter.Print(myMedicalAppointment);


// Calculator - Static methods
// Static methods are called on the class definiton.
// The do NOT require an instance of the class to be made.
// Static methods belong to the class not any particular instance of that class.
Console.WriteLine($"The sum of 1 + 2 = {Calculator.Add(1, 2)}");
Console.WriteLine($"The sum of 1 - 2 = {Calculator.Subtract(1, 2)}");
Console.WriteLine($"The product of 1 * 2 = {Calculator.Multiply(1, 2)}");


Console.ReadLine();

class Rectangle {
    // Fields
    // Fields that are uninitialized are set to the default value for that type.
    // For integers the value will be 0.
    // All members of a class (fields, methods, ect) are private by default.
    // A member should only be made public if absolutely necessary.

    // Naming Conventions
    // Public fields should start with a capital letter.
    // Private fields should start with a _ and a lowercase letter.
    // (i.e int _width, int _height)
    // Default values can be set for fields in a class. The constructor is ran
    // after the fields have been initialized.
    // readonly fields can only be set in the initilaization of the class or in
    // the class constructor.
    public int Width { get; private set; }
    public int Height { get; private set; }
    public static int NumberOfRectanglesCreated { get; private set; }

    // Constructor
    // 1.) Constructor method must have the same name as the class.
    // 2.) Constructor does not specify the return type.
    // 3.) Constructor can only be called in the moment of the object creation.

    public Rectangle(int width, int height) {
        Width = width;
        Height = height;
        NumberOfRectanglesCreated += 1;
    }

    // Methods
    // Should always start with a verb.

    public int CalculateCircumference() {
        return (2 * Width) + (2 * Height);
    }

    // Expression-Bodied Methods (similar to arrow function is javascript)
    // Expression - A line of code that evalutates to a value. (1 + 2)
    // Statement - A line of code that does not evaluate to a value. (if statement)

    // Before
    //public int CalculateArea()
    //{
    //    return Width * Height;
    //}
    public int CalculateArea() => Width * Height;
}

///////////////////////////// TOP-LEVEL STATEMENTS /////////////////////////////
// In C#, all code must live within a class.
// Before top-level statements were introduced you would have to manually write
// a boiler-plate top-level class.
// Now, it is done behind the scenes and includes the following code.
// using Namespace;
//
// namespace Rectangles {
//
//   internal class Program {
//
//      static void Main(string[] args) {
//          Console.WriteLine("Hello World!"
//      }
//
//   }
//
// }

///////////////////////////////// THIS KEYWORD /////////////////////////////////
public class MedicalAppointmentPrinter
{
    public static void Print(MedicalAppointment medicalAppointment) {
        Console.WriteLine($"Your next appointment is: {medicalAppointment.Date}");
    }
}


////////////////////////////// METHOD OVERLOADING //////////////////////////////
public class MedicalAppointment {
    public string PatientName { get; private set; }
    public DateTime Date { get; private set; }

    // Overloading Constructors
    // Follow the same rules as overloading methods.
    public MedicalAppointment(string patientName, DateTime date) {
        PatientName = patientName;
        Date = date;
    }

    // Optional Parameters -> daysFromNow is optional, if it's not provided the
    // default value of 7 is used.
    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        PatientName = patientName;
        Date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date) {
        Date = date;
    }

    public DateTime getDate() => Date;

    // Here we overload the "Reschedule" method for our class.
    // You can only overload a method if it can be distinguished from the other
    // methods in the class.
    // Parameter count, type, or order of params.
    public void Reschedule(int month, int day) {
        Date = new DateTime(Date.Year, month, day);
    }
}


/////////////////////////// STATIC CLASSES & METHODS ///////////////////////////
// static classes can be created when all methods of the class are static and
// the class doesn't need any stateful data.
// This class will not be able to instanciate objects. You can't: new Calculator()
static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}