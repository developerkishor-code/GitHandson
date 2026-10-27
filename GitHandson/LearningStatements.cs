using System;

public static class LearningStatements
{
    public static void Run()
    {
        int age = 18;
        string name = "Alex";

        // Conditional statement
        if (age >= 18)
        {
            Console.WriteLine($"{name} is an adult.");
        }
        else
        {
            Console.WriteLine($"{name} is a minor.");
        }

        // Switch statement
        switch (age)
        {
            case 18:
                Console.WriteLine("Age is exactly 18.");
                break;
            default:
                Console.WriteLine("Age is not 18.");
                break;
        }

        // For loop
        for (int count = 1; count <= 3; count++)
        {
            Console.WriteLine($"Count: {count}");
        }

        // Foreach loop
        string[] friends = { "Alice", "Bob", "Charlie" };
        foreach (string friend in friends)
        {
            Console.WriteLine($"Hello, {friend}!");
        }
    }
}
