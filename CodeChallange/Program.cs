using CodeChallange.Challenges;

Console.Title = "Code Challenge App (.NET 8)";
while (true)
{
    Console.Clear();
    Console.WriteLine("==== Code Challenge Menu ====");
    Console.WriteLine("1. Reverse a String");
    Console.WriteLine("2. Palindrome Checker");
    Console.WriteLine("3. Remove Duplicates");
    Console.WriteLine("4. FizzBuzz");
    Console.WriteLine("5. Group Words by First Letter");
    Console.WriteLine("6. Password Strength Validator");
    Console.WriteLine("7. LRU Cache Demo");
    Console.WriteLine("0. Exit");
    Console.Write("\nEnter your choice: ");

    var input = Console.ReadLine();

    Console.Clear();
    switch (input)
    {
        case "1":
            Console.Write("Enter string: ");
            var str = Console.ReadLine();
            Console.WriteLine("Reversed: " + StringHelper.ReverseString(str!));
            break;

        

        case "0":
            return;

        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }

    Console.WriteLine("\nPress any key to return to menu...");
    Console.ReadKey();
}
