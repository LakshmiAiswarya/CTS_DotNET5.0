using System;

public class Analysis
{
    public static void Explain()
    {
        Console.WriteLine("\n----- Big O Analysis -----");

        Console.WriteLine(
        "Big O notation describes the performance of an algorithm "
        + "based on input size."
        );


        Console.WriteLine("\nSearch Operations:");

        Console.WriteLine(
        "Linear Search:");
        Console.WriteLine(
        "Best Case : O(1) - Element found at first position"
        );
        Console.WriteLine(
        "Average Case : O(n)"
        );
        Console.WriteLine(
        "Worst Case : O(n) - Element found at last position or not found"
        );


        Console.WriteLine("\nBinary Search:");

        Console.WriteLine(
        "Best Case : O(1) - Element found at middle"
        );
        Console.WriteLine(
        "Average Case : O(log n)"
        );
        Console.WriteLine(
        "Worst Case : O(log n)"
        );


        Console.WriteLine("\nComparison:");

        Console.WriteLine(
        "Linear Search Time Complexity : O(n)"
        );

        Console.WriteLine(
        "Binary Search Time Complexity : O(log n)"
        );


        Console.WriteLine(
        "\nSuitable Algorithm:"
        );

        Console.WriteLine(
        "Binary Search is more suitable for e-commerce platforms "
        + "because it provides faster searching for large product databases."
        );
    }
}