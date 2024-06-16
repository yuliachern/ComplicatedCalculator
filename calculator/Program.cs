// Declare variables
int num1 = 0;
int num2 = 0;

// Prompt the user for input

Console.WriteLine("Please enter first number");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number");
num2 = Convert.ToInt32(Console.ReadLine());

//Process the data
int addition = num1 + num2;
int multiplication = num1 * num2;
int devision = num1 / num2;
int subtraction = num1 - num2;
int modulus = num1 % num2;

//Output the result to the user
Console.WriteLine($"The result of addition is {addition}");
Console.WriteLine($"The result of multiplication is {multiplication}");
Console.WriteLine($"The result of devision is {devision}");
Console.WriteLine($"The result of subtraction is {subtraction}");
Console.WriteLine($"The result of modulus is {modulus}");


