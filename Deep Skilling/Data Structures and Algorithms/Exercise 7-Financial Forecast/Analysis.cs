using System;

public class Analysis
{
    public static void Explain()
    {

        Console.WriteLine("\n===== Recursion Explanation =====");


        Console.WriteLine(
        "Recursion is a technique where a method calls itself "
        + "to solve a smaller part of the same problem."
        );


        Console.WriteLine(
        "It simplifies problems that can be divided into repeated steps."
        );


        Console.WriteLine("\n===== Time Complexity Analysis =====");


        Console.WriteLine(
        "For every year, the recursive function calls itself once."
        );


        Console.WriteLine(
        "Time Complexity: O(n)"
        );


        Console.WriteLine(
        "Space Complexity: O(n) because recursive calls are stored in memory."
        );


        Console.WriteLine("\n===== Optimization =====");


        Console.WriteLine(
        "Recursive solutions can be optimized using iteration "
        + "or memoization to avoid repeated calculations."
        );


        Console.WriteLine(
        "Memoization stores previous results and improves performance."
        );

    }
}