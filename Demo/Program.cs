using System.Globalization;
using System.Text;

namespace Demo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            #region Control Statment  1. Conditional Satement [If - Switch]

            #region Example 01 [Numberic Type : Equality]
            //Console.WriteLine("Please Enter a month Numbers Existed in 1st Qurater: ");
            //int.TryParse(Console.ReadLine(), out int MonthNumber);

            //if ( MonthNumber == 1 )
            //{
            //    Console.WriteLine("Hello January");
            //} 
            //else if ( MonthNumber == 2 )
            //{
            //    Console.WriteLine("Hello February");
            //}
            //else if( MonthNumber == 3 )
            //{
            //    Console.WriteLine("Hello March");
            //}
            //else
            //{
            //    Console.WriteLine("You Entered a month not in the 1st Quarter");
            //}

            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Hello January");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello February");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello March");
            //        break;
            //    default:
            //        Console.WriteLine("You Entered a month not in the 1st Quarter");
            //        break;

            //} 
            #endregion

            #region Exampe 02 [Numeric Type : Comparison]
            //Console.WriteLine("Please Enter Your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //if (Age > 22)
            //{
            //    Console.WriteLine("Your Age is Greater Than 22");
            //}
            //else if (Age < 22)
            //{
            //    Console.WriteLine("Your Age is Less Than 22");
            //}
            //else
            //{
            //    Console.WriteLine("Your Age is 22");
            //}


            //switch(Age)
            //{
            //    case > 22:
            //        Console.WriteLine("Your Age is Greater Than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Your Age is Less Than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Your Age is 22");
            //        break;
            //} 
            #endregion

            #region Example 03 [String : Equality]
            //Console.WriteLine("Enter Your Name: ");
            //string Name  = Console.ReadLine() ?? "No Name";

            //if (Name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if (Name == "Maged")
            //    Console.WriteLine("Hello Maged");
            //else if (Name == "Yassmin")
            //    Console.WriteLine("Hello Yassmin");
            //else if (Name == "Aya")
            //    Console.WriteLine("Hello Aya");


            //switch(Name)
            //{
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Maged":
            //        Console.WriteLine("Hello Maged");
            //        break;
            //    case "Yassmin":
            //        Console.WriteLine("Hello Yassmin");
            //        break;
            //    case "Aya":
            //        Console.WriteLine("Hello Aya");
            //        break;
            //} 
            #endregion

            #region Evoultion of switch in C# 7.0

            //object input = new object();
            //input = 5;

            //switch(input)
            //{
            //    case int localinput when localinput > 1 :
            //        Console.WriteLine("integer input");
            //        break;
            //     case double:
            //        Console.WriteLine("double input");
            //        break;
            //    default:
            //        Console.WriteLine("unkown input");
            //        break;  

            //}

            //Console.WriteLine("Please Enter Your Budgte: ");
            //int.TryParse(Console.ReadLine(), out int budget);

            //switch (budget)
            //{
            //    case 3000:
            //        {
            //            Console.WriteLine("Option 03");
            //            //Console.WriteLine("Option 02");
            //            //Console.WriteLine("Option 01");
            //            goto case 2000;
            //            //break;
            //        }
            //    case 2000:
            //        {
            //            Console.WriteLine("Option 02");
            //            //Console.WriteLine("Option 01");
            //            goto case 1000;
            //            //break;
            //        }
            //    case 1000:
            //        {
            //            Console.WriteLine("Option 01");
            //            break;
            //        }
            //}

            ////Multi Condtion in same case

            //Console.WriteLine("Please Enter Your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //switch (Age)
            //{
            //    case int when Age > 22 && Age < 25 :
            //        Console.WriteLine("Your Age is Greater Than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Your Age is Less Than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Your Age is 22");
            //        break;
            //}

            #endregion

            #region Evolution of Switch in C# 8.0

            #region Example01
            //String option = Console.ReadLine() ?? "0";

            //string message = string.Empty;

            //switch (option)
            //{
            //    case "1":
            //        message = "using option 1";
            //        break;
            //    case "2":
            //        message = "using option 2";
            //        break;
            //    case "3":
            //        message = "using option 2";
            //        break;
            //    default:
            //        message = "unsupported option";
            //        break;

            //}

            //Console.WriteLine(message);


            //message = option switch
            //{
            //    "1" => "using option 1",
            //    "2" => "using option 2",
            //    "3" => "using option 3",
            //    _ => "unsupported option"
            //};
            #endregion

            #region Example02
            //Person person = new Person() { Id: 10, Name: "Mina Hany",Age: 21};

            //switch(person)
            //{
            //    case {Id :10 , Name:"Mina Hany"}:
            //          Console.WriteLine("Hello MIna");
            //            break;
            //    default:
            //    break;
            //} 
            #endregion

            #endregion

            #region Evolution of Switch in C# 9.0

            //Person person = new Person() { Id = 10, Name = "Mina Hany", Age = 21 };

            //switch (person)
            //{
            //    case Person when person.Id == 10 && person.Name == "Mina Hany" && person.Age == 21:
            //        Console.WriteLine("Hello Mina Hany");
            //        break;
            //    case { Id: 10, Name: "Mina Hany", Age: > 21 and < 30 }:
            //        Console.WriteLine("Hello Mina Hany Your Age is 21");
            //        break;
            //    case { Age: 21 }:
            //        Console.WriteLine("HEllo Your Age is 21");
            //        break;
            //    default:
            //        break;
            //}
            #endregion



            #endregion

            #region Control Statments  2. Loop Statments [For/ForEach/While/DoWhile]

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Control Statments  2. Loop Statments [For/ForEach]
            //                0  1  2  3  4
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("******************");

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Control Statments  2. Loop Statments [DoWhile/While]

            #region DoWhile
            //int Number;
            //bool Flag;

            //do
            //{
            //    Console.Write("Please Enter an Even Number: ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //while (Number % 2 == 1 || !Flag);
            #endregion



            #endregion

            #region String

            #region Example01
            //string Name;
            //Name = new string("Ahmed");
            //Name = "Ahmed";   //(Syntax Sugar) 
            #endregion

            #region Example02

            //string Name01 = "Ahmed";
            //string Name02 = "Omar";

            ////Console.WriteLine($"Name01 = {Name01}");
            ////Console.WriteLine($"HashCode of Name01 = {Name01.GetHashCode()}");
            ////Console.WriteLine($"Name02 = {Name02}");
            ////Console.WriteLine($"HashCode of Name01 = {Name02.GetHashCode()}");

            //Name02 = Name01;

            //Name01 = "yassmin";
            //Console.WriteLine(Name02);

            ////Console.WriteLine("********After Name01 = Name02********");
            ////Console.WriteLine($"Name01 = {Name01}");
            ////Console.WriteLine($"HashCode of Name01 = {Name01.GetHashCode()}");
            ////Console.WriteLine($"Name02 = {Name02}");
            ////Console.WriteLine($"HashCode of Name01 = {Name02.GetHashCode()}");
            #endregion

            #region Example03
            //string message = "Hello";
            //Console.WriteLine($"Message:{message}");
            //Console.WriteLine($"Hashcode of message: {message.GetHashCode()}");

            //message += "Ahmed"; 
            //Console.WriteLine("*************After change message***************");

            //Console.WriteLine($"Message:{message}");
            //Console.WriteLine($"Hashcode of message: {message.GetHashCode()}"); 
            #endregion


            #endregion

            #region String Builder

            //StringBuilder message;

            //message = new StringBuilder("hello");

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //message.Append(" Ahmed");

            //Console.WriteLine("****************************");
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            #endregion

            #region StringBuilder Methods
            //StringBuilder message = new StringBuilder("Hello");

            //message.Append(" Ahmed");
            //message.AppendLine(" Nasr");
            //message.Append("Age is 22");
            //Console.WriteLine(message);

            //message.Remove(0, 5);  //From First index and remove 5 chars
            //Console.WriteLine(message);
            //message.Insert(0, "Hi");
            //Console.WriteLine(message);
            ////message.Clear();
            //message.AppendFormat("{0}:{1}",true,'A');
            //message.AppendJoin(" ; ", "mina", "Hany");
            //Console.WriteLine(message);

            #endregion

            #region Arrays - One D Array

            //int[] numbers;
            //numbers = new int[3] { 1 , 2 , 3 };
            ////numbers[0] = 1;
            ////numbers[1] = 2;
            ////numbers[2] = 3;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //int[] numbers;

            //numbers = new int[3];

            //int[] numbers02 = new int[3] { 1, 2, 3 };
            //int[] numbers03 = new int[] { 1, 2, 3 };
            //int[] numbers04 = { 1, 2, 3 };  //only with initialization

            //numbers04 = new int[] { 4, 5, 6 };  // to update
            ////
            ////Console.WriteLine(numbers04[0]);

            //Console.WriteLine(numbers04.Length);
            //Console.WriteLine($"Numbers of D = {numbers04.Rank}");
            #endregion

            #region Arrays - Two D Array [Rectangular]

            //int[,] Marks = new int[3, 5] /*{ { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } }*/;
            //CLR will allocate 60 bytes at HEAP
            //Intialized with default vlaue of int = 0

            //Marks[0, 1] = 1;
            //Marks[0, 2] = 2;
            //Marks[0, 3] = 3;
            //Marks[0, 4] = 4;

            //Marks[1, 0] = 1;
            //Marks[1, 1] = 2;
            //Marks[1, 2] = 3;
            //Marks[1, 3] = 4;

            //Console.WriteLine($"Length of Array : {Marks.Length} , The Count Of D : {Marks.Rank}");

            //bool flag;

            //for (int i = 0; i < Marks.GetLength(0) /*3*/; i++)
            //{
            //    Console.WriteLine($"Please Enter Grades of Student No. {i+1}");
            //    for(int j = 0; j < Marks.GetLength(1)/*5*/;)
            //    {
            //        Console.WriteLine($"Please Enter Grade Of Subject No. : {j+1}");

            //        //flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        //if (flag)
            //        //    j++;
                     
            //        j = int.TryParse(Console.ReadLine(), out Marks[i, j]) ? ++j : j;

            //    }
            //}

            //Console.Clear();

            //for(int i = 0;i < Marks.GetLength(0) ;i++)
            //{
            //    Console.WriteLine($"Student Number {i + 1}");
            //    for (int j = 0;j < Marks.GetLength(1) ;j++)
            //    {
            //        Console.WriteLine($"Grade Of Subject No({j+1}) : {Marks[i,j]}");
            //    }
            //    Console.WriteLine("==============================================");
            //}


            #endregion

        }
    }
}
