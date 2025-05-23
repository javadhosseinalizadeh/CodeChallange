﻿using CodeChallange.Challenges;
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
    Console.WriteLine("8. Bank Account Demo");
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

        case "4":
            FizzBuzzHelper.RunFizzBuzz();
            break;

        case "5":
            Console.Write("Enter comma-separated words: ");
            var wordsLine = Console.ReadLine()!;
            var words = wordsLine.Split(',').Select(w => w.Trim()).ToList();
            WordGrouper.GroupByFirstLetter(words);
            break;

        case "6":
            Console.Write("Enter password: ");
            var password = Console.ReadLine();
            Console.WriteLine(PasswordValidator.IsStrongPassword(password!) ? "Strong password" : "Weak password");
            break;

        case "7":
            LruCacheDemo.Run();
            break;

        case "8":
            BankAccountDemo.Run();
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
