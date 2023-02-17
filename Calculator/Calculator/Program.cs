using System.IO.Pipes;

namespace calculator
{
    static class Collect
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first value.");
            var inputOne = Console.ReadLine();
            var numberOne = int.Parse(inputOne);
            Console.WriteLine("Enter your function (ie. Add, Subtract, Divide, Multiply)");
            string mathReturn = Console.ReadLine();
            Console.WriteLine("Enter your second value.");
            var inputTwo = Console.ReadLine();
            var numberTwo = int.Parse(inputTwo);
            int answer = 0;
                
            if (mathReturn == "Add")
            {
                answer = Collect.Add(numberOne, numberTwo);
                Console.WriteLine("The answer is: ", answer);
            }
            if (mathReturn == "Subtract")
            {
                answer = Collect.Subtract(numberOne, numberTwo);
                Console.WriteLine("The answer is: ", answer);
            }
            if (mathReturn == "Divide")
            {
                answer = Collect.Divide(numberOne, numberTwo);
                Console.WriteLine("The answer is: ", answer);
            }
            if (mathReturn == "Multiply")
            {
                answer = Collect.Multiply(numberOne, numberTwo);
                Console.WriteLine("The answer is: ", answer);
            }
            
            
        }

        public static int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
        public static int Divide(int numberOne, int numberTwo) 
        {
            return numberOne / numberTwo;
        }
        public static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        public static int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
    }    
}