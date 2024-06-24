// Declare variables
using System.Linq.Expressions;
using System.Net.Http.Headers;

int num1 = 0;
int num2 = 0;

// Prompt user for input
Console.WriteLine("Please enter first number");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter second number");
num2 = Convert.ToInt32(Console.ReadLine());



//Decide wich operation is needed  based on selected option

//Process the data
//int addition = num1 + num2;
//int multiplication = num1 * num2;
//int devision = num1 / num2;
//int subtraction = num1 - num2;
//int modulus = num1 % num2;

//Output the result to the user
//Console.WriteLine($"The result of addition is {addition}");
//Console.WriteLine($"The result of multiplication is {multiplication}");
//Console.WriteLine($"The result of devision is {devision}");
//Console.WriteLine($"The result of subtraction is {subtraction}");
//Console.WriteLine($"The result of modulus is {modulus}");
int choice = 0;
while (choice != -1)
{
    //Show calculator options / Show menu
    PrintMenue();

    try
    {
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == -1)
        {
            break;
        }
        Console.WriteLine("Please enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter second number");
        num2 = Convert.ToInt32(Console.ReadLine());


        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = addition(num1, num2);
                break;
            case 2:
                answer = subtraction(num1, num2);
                break;
            case 3:
                answer = multiplication(num1,num2);
                break;
            case 4:
                 answer = devision(num1, num2);
                 break;
            case 5:
                answer = modulus(num1, num2);
                break;
            case 6:
                answer = Fibonacci(num1, num2);
                break;
            default:
                throw new Exception("Invalid menu item selected.");
                Console.WriteLine("Invalid choice");
                break;
        }
        Console.WriteLine($"The result is {answer}");
    }

    catch (DivideByZeroException)
    {
        Console.WriteLine("Can not divide by zero");
    }

    catch (Exception ex)
    {
        Console.WriteLine("Invalid input, press any key to try again");
    }
    finally
    {
        Console.ReadLine();
        Console.Clear();
    }
    
}

void PrintMenue()
{
    Console.WriteLine("Please select en operation (-1 to exit program)");
    Console.WriteLine("1 -  addition");
    Console.WriteLine("2 - multiplication");
    Console.WriteLine("3 - devisio");
    Console.WriteLine("4 - subtraction");
    Console.WriteLine("5 - modulus");
    Console.WriteLine("6- Fibonacci sequence");
}

// Methods
int addition(int num1, int num2)
{
    return num1 + num2;
}
int multiplication(int num1, int num2)
{
    return num1 * num2;
}
int devision(int num1, int num2)
{
    return num1 / num2;
}
int subtraction(int num1, int num2)
{
    return num1 - num2;
}
int modulus(int num1, int num2)
{
    return num1 % num2;
}
int Fibonacci(int num1, int num2)
{
    int answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}
