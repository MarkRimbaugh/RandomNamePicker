public class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string>(){"Alex", "Brian", "David", "Donovan", "Drew", "Erik", "Greg",
        "Jackson", "Joshua", "Mark", "Mursal", "Patrick", "Rico", "Rohin"};

        int initialNameListCount = names.Count;

        Console.WriteLine($"There are {names.Count} people on the list. ");
        Random rnd = new Random();

        Stack<string> nameList = new Stack<string>();

        for (int i = 0; i < initialNameListCount; i++)
        {
            int a = rnd.Next(0, names.Count);
            nameList.Push(names[a]);
            names.RemoveAt(a);
        }
        
        bool keepGoing = true;
        while (nameList.Count > 0 && keepGoing)
        {
            Console.WriteLine($"Enter 'next' for a new name, or 'quit' to quit.");
            string input = Console.ReadLine();
            if(input == "next")
            {
                Console.WriteLine(new string('*', 50));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Up Next --> {nameList.Peek()} || {nameList.Count -1} names remain.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(new string('*', 50));
                nameList.Pop();
            }

            else if(input == "quit") 
            {
                keepGoing = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid entry, please try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        Console.WriteLine("Goodbye!");
    }
}