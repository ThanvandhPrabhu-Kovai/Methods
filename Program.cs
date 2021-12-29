using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            userDefinedFunction();
            Console.Write("\n\n\n");
            userDefinedFunctionWithParameters("John");
            Console.Write("\n\n\n");
            getSumOfTwoNumbers();
            Console.Write("\n\n\n");
            countWhiteSpacesInAString();
            Console.Write("\n\n\n");
            getSumOfAllArrayElements();
            Console.Write("\n\n\n");
            swapTwoIntegers();
            Console.Write("\n\n\n");
            getResutWhenANumberRaisedToThePowerOfAnother();
            Console.Write("\n\n\n");
            getNNumberOfFibonacciSequence();
            Console.Write("\n\n\n");
            checkForPrimeNumber();
            Console.Write("\n\n\n");
            getSumOfDigitsOfNumber();
            Console.Write("\n\n\n");
            Console.ReadLine();
        }

        static string getUserInputString() => Console.ReadLine();

        static int getUserInput() => Convert.ToInt32(getUserInputString());

        static void showOutput(string input) => Console.Write("\n\n{0}", input);

        //program to create a user define function
        static void userDefinedFunction()
        {
            showOutput("Welcome Friends!");
            showOutput("Have a nice day!");
        }

        //program to create a user define function with parameters.  
        static void userDefinedFunctionWithParameters(string name)
        {
            string statement1 = $"Welcome friend {name}!";
            showOutput(statement1);
            showOutput("Have a nice day!");
        }

        //program to create a function for the sum of two numbers.  
        static void getSumOfTwoNumbers()
        {
            showOutput("Enter a number : ");
            int i = getUserInput();
            showOutput("Enter another number : ");
            int j = getUserInput();

            int sum = i + j;
            string result = $"The sum of two numbers is : {sum}";
            showOutput(result);
        }

        //program to create a function to input a string and count number of spaces are in the string
        static void countWhiteSpacesInAString()
        {
            showOutput("Please input a string : ");
            string input = getUserInputString();
            char[] stringAsChar = input.ToCharArray();

            int count = stringAsChar.Count(item => item == ' ');

            showOutput($"\"{input}\" contains {count} spaces");
        }

        //program to calculate the sum of elements in an array.  
        static void getSumOfAllArrayElements()
        {
            int[] array = new int[0];
            showOutput("To calculate the sum of elements in an array.");
            showOutput("-------------------------------");

            showOutput("Input number of array elements : ");
            int n = getUserInput();

            Array.Resize(ref array, n);

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("element {0} - ", i);
                int item = getUserInput();
                sum += item;
            }

            string result = $"The sum of the elements of the array is {sum}";
            showOutput(result);
        }

        //program to create a function to swap the values of two integer numbers.
        static void swapTwoIntegers()
        {
            showOutput("Enter a number : ");
            int a = getUserInput();

            showOutput("Enter another number : ");
            int b = getUserInput();

            string result = $"Now the 1st number is {b}, and the 2nd number is {a}";
            showOutput(result);
        }

        //program to create a function to calculate the result of raising an integer number to another.
        static void getResutWhenANumberRaisedToThePowerOfAnother()
        {
            showOutput("Input base number : ");
            int number = getUserInput();

            showOutput("Input the exponent : ");
            int exponent = getUserInput();

            int result = 1;
            for (int i = 0; i < exponent; i++)
                result *= number;

            showOutput($"So, the number {number} to the power (^) {exponent} is {result}");
        }

        //program to create a function to display the n number Fibonacci sequence
        static void getNNumberOfFibonacciSequence()
        {
            showOutput("Function : To display the n number Fibonacci series : ");
            showOutput("-----------------------------------------------------");
            showOutput("Input number of Fibonacci Series : ");
            int n = getUserInput();

            showOutput($"The Fibonacci series of {n} numbers is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibo(i) + "  ");
            }

            int Fibo(int nno)
            {
                int num1 = 0;
                int num2 = 1;

                for (int i = 0; i < nno; i++)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp + num2;
                }
                return num1;
            }
        }

        //program to create a function to check whether a number is prime or not.  
        static void checkForPrimeNumber()
        {
            showOutput("Function : To check a number is prime or not : ");
            showOutput("--------------------------------------------------");
            showOutput("Input a number : ");
            int n = getUserInput();

            bool isPrime = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                showOutput(n + " is a prime number");
            }
            else
            {
                showOutput(n + " is not a prime number");
            }

        }

        //program to create a function to calculate the sum of the individual digits of a given number
        static void getSumOfDigitsOfNumber()
        {
            showOutput("Function : To calculate the sum of the individual digits of a number : ");
            showOutput("-----------------------------------------------------------------------");
            showOutput("Enter a number: ");
            int num = getUserInput();

            int sum = 0;
            string convertNumToStr = num.ToString();

            for (int i = 0; i < convertNumToStr.Length; i++)
                sum += Convert.ToInt32(convertNumToStr.Substring(i, 1));

            showOutput($"The sum of the digits of the number {num} is : {sum}");
        }
    }
}
