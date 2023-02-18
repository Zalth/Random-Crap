using Calculator;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace calculator
{
    static class Collect
    {
        public static void Main(string[] args)
        {
            bool Continue = true;
            do
            {
                
                Console.WriteLine("Enter your first value.");
                var inputOne = Console.ReadLine();
                var numberOne = int.Parse(inputOne);
                Console.WriteLine("Enter your function (ie. Add, Subtract, Divide, Multiply)");
                string mathReturn = Console.ReadLine();

                Operator operate = new Operator();
                string Operation = Operator.Operate(mathReturn);

                Console.WriteLine("Enter your second value.");
                var inputTwo = Console.ReadLine();
                var numberTwo = int.Parse(inputTwo);

                Calc Calc = new Calc();

                if (Operation == "ADD" || Operation == "+")
                {
                    Console.WriteLine("The answer is: " + Calc.Add(numberOne, numberTwo));
                }
                else if (Operation == "SUBTRACT" || Operation == "-")
                {
                    Console.WriteLine("The answer is: " + Calc.Subtract(numberOne, numberTwo));
                }
                else if (Operation == "DIVIDE" || Operation == "÷" || Operation == "/")
                {
                    Console.WriteLine("The answer is: " + Calc.Divide(numberOne, numberTwo));
                }
                else if (Operation == "MULTIPLY" || Operation == "x")
                {
                    Console.WriteLine("The answer is: " + Calc.Multiply(numberOne, numberTwo));
                }  
                else if (Operation == " ")
                {
                    Console.WriteLine("You have entered an invalid operator");
                }
                else
                {
                    Console.WriteLine("Please try again.");
                }


                Console.WriteLine("Do you want to go again?");
                string Answer = Console.ReadLine();
                String Answer2 = Answer.ToUpper();
                if (Answer2 == "YES")
                {
                    Continue = true;
                }
                else if (Answer2 == "NO")
                {
                    Continue = false;
                }
            } while (Continue == true);
            
        }
    }    
}