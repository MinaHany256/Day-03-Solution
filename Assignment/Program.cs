using System.Numerics;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Please Enter a Number can be divided By 3 and 4 : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //if (number % 3 == 0 && number % 4 ==0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("no");

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write("Please Enter a Number : ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if(number < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Postitive");
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.WriteLine("Enter First Number");
            //int.TryParse(Console.ReadLine(), out int number01);

            //Console.WriteLine("Enter Second Number");
            //int.TryParse(Console.ReadLine(), out int number02);

            //Console.WriteLine("Enter Third Number");
            //int.TryParse(Console.ReadLine(), out int number03);

            //if (number01 > number02)
            //{
            //    if (number01 > number03)
            //        Console.WriteLine($"Max Number is {number01}");
            //    else
            //        Console.WriteLine($"Max Number is {number03}");
            //    if (number02 > number03)
            //        Console.WriteLine($"Min Number is {number03}");
            //    else
            //        Console.WriteLine($"Min Number is {number02}");
            //}
            //else
            //{
            //    if (number02 > number03)
            //        Console.WriteLine($"Max Number is {number02}");
            //    else
            //        Console.WriteLine($"Max Number is {number03}");
            //    if (number01 > number03)
            //        Console.WriteLine($"Min Number is {number03}");
            //    else
            //        Console.WriteLine($"Min Number is {number01}");
            //}


            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter a Number");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number % 2 == 0)
            //    Console.WriteLine("Even Number");
            //else
            //    Console.WriteLine("Odd Number");
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.Write("Please Enter any char : ");
            //char character = char.Parse(Console.ReadLine());

            //switch(character)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Constant");
            //        break;
            //}


            #endregion

            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Please Enter any Number : ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //    Console.WriteLine(i);

            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Please Enter any Number : ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i < 12; i++) 
            //    Console.Write($" {number * i} ");
            #endregion

            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Please Enter any Number : ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 2; i < number ; i+=2)
            //    Console.Write($" {i} ");

            #endregion

            #region 9- Write a program that takes two integers then prints the power.

            //Console.Write("Please Enter any Number : ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter Power : ");
            //int power = int.Parse(Console.ReadLine());

            //int answer = 1;

            //for (int i = 0; i < power; i++)
            //    answer *= number;

            //Console.WriteLine(answer);

            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] Grade = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"please Enter Mark of Subject ({i + 1})");
            //    Grade[i] = int.Parse(Console.ReadLine());
            //}

            //int total = 0;

            //for (int i = 0; i < 5; i++)
            //    total += Grade[i];


            //int percentage = (total * 100) / 500;
            //int average = total / Grade.Length;

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"percentage of marks = {percentage}");
            //Console.WriteLine($"Average marks = {average}");


            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.

            //Console.WriteLine("Please Enter a Month Number : ");
            //int number = int.Parse(Console.ReadLine());

            //switch(number)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month is 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month is 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month is 28");
            //        break;
            //    default:
            //        Console.WriteLine("Enter a valid Month Number");
            //        break;


            //}

            #endregion

            #region 12- Write a program to create a Simple Calculator.

            //Console.Write("Write the First Number : ");
            //double number01 = double.Parse(Console.ReadLine());

            //Console.Write("Write the Operatot : ");
            //char operator01 = char.Parse(Console.ReadLine());

            //Console.Write("Write the Second Number : ");
            //double number02 = double.Parse(Console.ReadLine());
            //double answer = 0;

            //switch (operator01)
            //{
            //    case '+':
            //        answer = number01 + number02;
            //        Console.Clear();    
            //        Console.WriteLine($"{number01} + {number02} = {answer}");
            //        break;
            //    case '-':
            //        answer = number01 - number02;
            //        Console.Clear();
            //        Console.WriteLine($"{number01} - {number02} = {answer}");
            //        break;
            //    case '*':
            //        answer = number01 * number02;
            //        Console.Clear();
            //        Console.WriteLine($"{number01} * {number02} = {answer}");
            //        break;
            //    case '/':
            //        answer = number01 / number02;
            //        Console.Clear();
            //        Console.WriteLine($"{number01} / {number02} = {answer}");
            //        break;
            //    default:
            //        Console.Clear();
            //        Console.WriteLine("Invalid operator");
            //        break;
            //}

            #endregion

            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("Please Enter any String");
            //string name = Console.ReadLine();

            //string reverse = string.Empty;
            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    reverse += name[i];
            //}

            //Console.WriteLine(reverse);

            #endregion

            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.WriteLine("Enter starting number of range:");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter ending number of range:");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    bool isPrime = true;

            //    if (i < 2)
            //    {
            //        isPrime = false; 
            //    }
            //    else
            //    {

            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }


            //    if (isPrime)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}

            #endregion

            #region 16- Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a decimal number:");
            //int Number = int.Parse(Console.ReadLine());

            //int quotient = Number;
            //string binaryNumber = "";

            //while (quotient > 0)
            //{
            //    int remainder = quotient % 2;
            //    binaryNumber = remainder + binaryNumber;
            //    quotient /= 2;
            //}

            //Console.WriteLine(binaryNumber);

            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Enter Points 1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates for Points 2 : ");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates for Points 3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());

            //double slope01 = (y2 - y1) / (x2 - x1);
            //double slope02 = (y3 - y2) / (x3 - x2);


            //if (slope01 == slope02)
            //{
            //    Console.WriteLine("lies on the same straight line");
            //}
            //else
            //{
            //    Console.WriteLine("not lies on the same straight line");
            //}

            #endregion

            #region Question 18
            ////18 - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 
            ////- If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            ////- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            ////- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            ////- If the worker takes more than 5 hours, they are required to leave the company.
            ////To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //Console.Write("Please Enter the taken by the worker for the task : ");
            //int time  = int.Parse(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //    Console.WriteLine("Highly efficient worker");
            //else if (time >= 3 && time <= 4)
            //    Console.WriteLine("The Worker should increase the speed");
            //else if (time >= 4 && time <= 5)
            //    Console.WriteLine("The worker Should take training.");
            //else if (time >= 5)
            //    Console.WriteLine("Worker needs to leave the company");
            //else
            //    Console.WriteLine("Invalid input");

            #endregion

            #region 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter the size identity matrix:");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1  ");
            //        else
            //            Console.Write("0  ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"Sum Of The Array : {sum}");

            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr01 = { 1, 2, 5, 4, 3 };
            //int[] arr02 = { 7, 8, 9, 10, 6 };
            //int[] Merge = new int[arr01.Length + arr02.Length];



            //Array.Copy(arr01,Merge,arr01.Length);
            //Array.Copy(arr02, 0, Merge, arr01.Length, arr02.Length);
            //Array.Sort(Merge);

            //foreach (int number in Merge)
            //    Console.WriteLine(number);

            #endregion

            #region 22- Write a program in C# Sharp to count the frequency of each element of an array.



            #endregion

            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 9 };

            //int maxNumber = arr[0];
            //int minNumber = arr[0];

            //foreach (int number in arr)
            //{
            //    if (number > maxNumber)
            //        maxNumber = number;

            //    if (number < minNumber)
            //        minNumber = number;
            //}

            //Console.WriteLine($"Maximum element: {maxNumber}");
            //Console.WriteLine($"Minimum element: {minNumber}");

            #endregion

            #region 24- Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 3, 7, 1, 9, 5, 2, 8, 4, 6 };

            //int firstMax = 0; 
            //int secondMax = 0; 


            //foreach (int number in arr)
            //{
            //    if (number > firstMax)
            //    {
            //        secondMax = firstMax; 
            //        firstMax = number;
            //    }
            //    else if (number > secondMax)
            //    {
            //        secondMax = number;
            //    }
            //}

            //Console.WriteLine($"Second largest element: {secondMax}");

            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter a list of words : ");

            //string input = Console.ReadLine();


            //string[] words = input.Split();

            //Array.Reverse(words);

            //string reversedSentence = string.Join(" ", words);

            //Console.WriteLine("Reversed order of words:");
            //Console.WriteLine(reversedSentence);
            #endregion

            #region 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

           
            //Console.Write("Number of Rows of First Array: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Number of Columns of First Array: ");
            //int columns = int.Parse(Console.ReadLine());

           
            //int[,] firstArray = new int[rows, columns];
            //int[,] secondArray = new int[rows, columns];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Enter value for element ({i},{j}): ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
           
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            
            //Console.WriteLine("Second Array : ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
        }
    }
}
