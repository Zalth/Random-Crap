namespace fakebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var likes = new List<string>();
            Console.WriteLine("Would you like to add a like?");
            var response = Console.ReadLine();
            while (response != "No")
            {
                Console.WriteLine("What is their name?");
                var name = Console.ReadLine();
                likes.Add(name);
                Console.WriteLine("Would you like to add a like?");
                response = Console.ReadLine();
            }
            Console.WriteLine("There are: " + likes.Count, " likes!");
            Console.WriteLine("The people who liked the post are: ");
            foreach (var n in likes)
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}