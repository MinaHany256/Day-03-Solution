namespace Demo
{
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


            #endregion


        }
    }
}
