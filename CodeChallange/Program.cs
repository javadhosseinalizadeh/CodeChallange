using CodeChallange.Challenges;
using System.Collections.Generic;

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

        case "2":
            Console.Write("Enter string: ");
            var pal = Console.ReadLine();
            Console.WriteLine(StringHelper.IsPalindrome(pal!) ? "Palindrome" : "Not a palindrome");
            break;

        case "3":
            var list = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var names = new List<string> { "Ali", "Javad", "Ali", "Nima" };

            var result = ListHelper.RemoveDuplicatesLinq(list);
            var uniqueManual = ListHelper.RemoveDuplicatesManual(names);

            Console.WriteLine("Result: " + string.Join(", ", uniqueManual));
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
