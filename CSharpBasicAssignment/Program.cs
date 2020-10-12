using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment_CSharpGund
{
    class Program
    {
        private static void RunExerciseOne()
        {
            string firstName = "Alejandra", lastName = "Lopez";

            WriteLine($"Hi {firstName} {lastName}! I´m glad to inform you that you are the test subject of my very first assigment!");

            ReadLine();
        }

        private static void RunExerciseTwo()
        {
            WriteLine("Introduce your first name: ");
            string firstName = ReadLine();
            WriteLine("Introduce your last name: ");
            string lastName = ReadLine();

            WriteLine($"Hello {firstName} {lastName}! Have a nice day!");

            ReadLine();
        }

        private static void RunExerciseThree()
        {
            WriteLine("Introduce your date of birthday in the following format YYYY-MM-DD: ");
            DateTime birthDate = DateTime.Parse(ReadLine());
            DateTime nowDate = DateTime.Today;
            int age = nowDate.Year - birthDate.Year;

            if (nowDate.DayOfYear < birthDate.DayOfYear)
                age--;
            WriteLine($"You have {age} years old");


            ReadLine();
        }

        private static void RunExerciseFour()
        {
            DateTime todayDate = DateTime.Now;
            DateTime date = DateTime.Today;
            

            WriteLine(todayDate.ToString("MM/dd/yyyy"));
            WriteLine(todayDate.ToString("dddd, dd MMMM yyyy"));
            WriteLine(todayDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            WriteLine(todayDate.ToString("MM/dd/yyyy HH:mm"));
            WriteLine(todayDate.ToString("MM/dd/yyyy hh:mm tt"));
            WriteLine(todayDate.ToString("MM/dd/yyyy HH:mm:ss"));
            WriteLine(todayDate.ToString("MMMM dd"));
            WriteLine(todayDate.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            WriteLine(todayDate.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            WriteLine(todayDate.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            WriteLine(todayDate.ToString("yyyy MMMM"));

            DateTime yesterday = todayDate.Subtract(TimeSpan.FromDays(1));
            WriteLine($"Yesterday was: {yesterday.ToShortDateString()}");

            DateTime tomorrow = todayDate.Add(TimeSpan.FromDays(1));
            WriteLine($"Tomorrow will be: {tomorrow.ToShortDateString()}");


            Console.ReadKey();
        }
        private static void RunExerciseFive()
        {
            //PART A
            int var1 = 100;
            int var2 = 200;
            double resultAdd = var1 + var2;

            WriteLine($"The result addition is: {resultAdd}");
            ReadLine();

            //PART B
            double var3 = 1.50;//aqui se escribe con punto, pero en la consola con coma (,)
            double var4 = 9.75;
            //int resultSum = (int)(var3 + var4);
            double resultSum = var3 + var4;

            WriteLine($"The result addition is: {resultSum}");
            ReadLine();

            //PART C
            double var5 = 2;
            double var6 = 3;
            double resultDivision = var6 / var5; //divido Impar entre Par

            WriteLine($"The division result is: {resultDivision}");
            ReadLine();

        }
        private static void RunExerciseSix()
        {
            
            //PART A
            WriteLine("Exercise 6 - Part A");
            string foxLine1 = "The quick fox Jumped Over the DOG";
            WriteLine($"The current sentence is:{foxLine1}");

            foxLine1 = foxLine1.Replace("quick fox Jumped Over the DOG", "brown fox jumped over the lazy dog");
            WriteLine($"The new sentece replaced is: {foxLine1}");

            ReadLine();

            //PART B
            WriteLine("Exercise 6 - Part B");
            WriteLine("Introduce the first word: ");
            string word1 = ReadLine();

            WriteLine("Introduce the second word: ");
            string word2 = ReadLine();

            if( word1 == word2)
            {
                WriteLine("The words are the same");
            }
            else
            {
                WriteLine("The words are different");
            }
            ReadLine();

            //PART C
            WriteLine("Exercise 6 - Part C");
            WriteLine("Please introduce the word: Donkey: ");
            string word3 = ReadLine();

            word3 = word3.Replace("D", "M");
            WriteLine($"The word: Donkey has been replaced for the word: {word3}");

            ReadLine();

            //PART D
            WriteLine("Exercise 6 - Part D");
            string linePartD = "I am going to visit Kålmården zoo tomorrow. I am a big fan of the dolphin show. I may watch all dolphin shows during the day. I would like to take a gondola safari as well. I wish to visit Bamse and his team there.";
            WriteLine($"The current sentence is:{linePartD}\n");

            linePartD = linePartD.Replace("I", "We");
            linePartD = linePartD.Replace("am", "are");

            
            WriteLine($"The new sentence is:{linePartD}");

            ReadLine();

            //PART E
            WriteLine("Exercise 6 - Part E");
            string linePartE = "She is the popular singer";
            WriteLine($"The current sentence is:{linePartE}\n");
            
            linePartE = linePartE.Insert(11,"most ");//contar letra por letra e incluido espacios para llegar al punto donde se va a anadir la nueva palabra
            WriteLine($"The new sentence is:{linePartE}");

            ReadLine();
            
            //PART F
            WriteLine("Exercise 6 - Part F");
            string linePartF = "A friend is the asset of your life.";
            WriteLine($"The current sentence is:{linePartF}\n");
         
            linePartF = linePartF.Insert(2,"true ");
            linePartF = linePartF.Insert(21,"greatest ");
            WriteLine($"The new sentence is:{linePartF}.");

            ReadLine();

            //PART G
            WriteLine("Exercise 6 - Part G");
            string linePartG = "My name is Nalini Phopase.";//I can use REPLACE too
            WriteLine($"The current sentence is:{linePartG}\n");

            linePartG = linePartG.Remove(0,11);//Indica de a donde a donde quita, es decir, de 0(el inicio) hasta 11
            WriteLine($"The new sentence is:{linePartG}");

            ReadLine();

            //PART H
            WriteLine("Exercise 6 - Part H");
            string linePartH = "Arrays are very common in programming, they look something like:[1,2,3,4,5]";
            WriteLine($"The current string is:{linePartH}\n");

            //linePartH = linePartH.Replace("2,3,4,5", "4,5,6,7,8");
            linePartH = linePartH.Replace(linePartH, "[1,4,5,6,7,8]");
            WriteLine($"The expected string is:{linePartH}");

            ReadLine();

        }
        private static void RunExerciseSeven()
        {
            int x = 40;
            int y = 20;
            int z = 25;
            int m = 15;
            int e, f, g;

            e = ((x + y) * z) / m;
            WriteLine($"The result of e:{e}\n");

            f = x +( y * (z / m));
            WriteLine($"The result of f:{f}\n");

            g = x +  y * z / m;
            WriteLine($"The result of g:{g}\n");

            ReadLine();
        }

        
        private static void RunExerciseEight()
        {
            int number = 0;
            WriteLine("Introduce a positive integer number please: ");
            number = int.Parse(ReadLine());//HAY QUE PARSEARLO PORQUE EL wRITElINE RECIBE UN STRING Y QUEREMOS un numero

            if( (number % 2) == 0)
            {
                WriteLine("The number introduced is EVEN");
            }
            else
            {
                WriteLine("The number introduced is ODD");
            }

            ReadLine();
            

        }
        private static void RunExerciseNine()
        {
            Random rnd = new Random();
            List<int> numList = new List<int>();
            for (int i = 0; i <=19; i++)
            {
                numList.Add(rnd.Next(1, 150));
            }

            List<int> evenNumList = new List<int>();
            List<int> oddNumList = new List<int>();

            foreach (var item in numList)
            {
                Write($"{item} |");//porque no me deja colocarlos todos en la misma linea
                if (item % 2 == 0)
                {
                    evenNumList.Add(item);
                }
                else
                {
                    oddNumList.Add(item);
                }
                

            }
            WriteLine();
            foreach (var item in evenNumList)//si quiero este FOREACH dentro del otro FOREACH quito la palabra "var" y asi funcionaria en ese caso
            {
                Write($"{item} |");
            }
            WriteLine();
            foreach (var item in oddNumList)
            {
                Write($"{item} |");
            }



        }
        private static void RunExerciseTen()
        {

            WriteLine("Introduce the radio value: ");
            double radio = double.Parse(ReadLine());
            double area = Math.PI * Math.Pow(2,radio);
            WriteLine($"The radio of your SPHERE is: {Math.Round(area,2)}");

        }
        private static void RunExerciseEleven()
        {
            /*
            WriteLine("Introduce 10 numbers positives and negatives");
            double numbersIntroduced = double.Parse(ReadLine());//aqui se guardan los numeros y se los paso luego al ARRAY
            Array double[] numbersArrays = new Array();
            
            //string[] numbersArraysPositive = new string[0];
            string[] numbersArraysNegative = new string[0];

            for (int i = 0; i <= 9; i++)
            {
                numbersIntroduced.
            }

            if (numbersIntroduced < 0)
            {
                
            }
            */

            double[] allNumbers = new double[10];
           
            WriteLine($"Introduce 5 numbers positives and 5 numbers negatives: ");
            for (int i = 0; i < 10; i++)//<0 Significa que toma los numeros negativos
            {
                allNumbers[i] = double.Parse(ReadLine());//aqui esta GUARDANDO los valores introducidos por el usuario.los 10 numeros
            }
           
             WriteLine("The negatives numbers are: ");//AQUI ESTA MOSTRANNDO EL RESULTADO DE LOS 5 NUMEROS NEGATIVOS
            foreach (var item in allNumbers)
            {
                       
                if (item <0)
                {
                    Write($"{item} |");//aqui esta clasificando los numeros NEGATIVOS.
                }
                
            }
        }
        private static void RunExerciseTwelve()
        {
            WriteLine("Hello introduce your body temperature in degree Celsius: ");
            double degCelsius = double.Parse(ReadLine());

            if (degCelsius > 37)
            {
                WriteLine("Ohhhh sorry>>> You have FEVER :( ");
            }
            else 
            {
                WriteLine("Yujuuuuuu!!!! >>> You have not fever :) ");
            }
        }
        private static void RunExerciseThirteen()
        {
            WriteLine("Hello introduce your name please: ");
            string name = ReadLine();

            WriteLine($"Hello {name} introduce your birth date like the following format: DD/MM/YY: ");
            int age = int.Parse(ReadLine());

            int 


        }
        private static void RunExerciseFourteen()
        {

        }
        private static void RunExerciseFifteen()
        {

        }
        private static void RunExerciseSixteen()
        {

        }
        private static void RunExerciseSeventeen()
        {

        }
        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseFourteen();
                            break;
                        case 15:
                            RunExerciseFifteen();
                            break;
                        case 16:
                            RunExerciseSixteen();
                            break;
                        case 17:
                            RunExerciseSeventeen();
                            break;

                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            }

        }

    }
}
