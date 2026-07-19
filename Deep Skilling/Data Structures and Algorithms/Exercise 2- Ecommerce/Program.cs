using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("===== E-Commerce Product Search System =====");


        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(205,"Shoes","Fashion"),
            new Product(309,"Mobile","Electronics"),
            new Product(412,"Watch","Accessories"),
            new Product(520,"Book","Education")
        };


        Console.WriteLine("\nProducts Available:");

        foreach (Product p in products)
        {
            p.Display();
        }


        Console.WriteLine("\nLinear Search Result:");

        Product? linearResult =
            SearchAlgorithms.LinearSearch(products, 309);


        if (linearResult != null)
        {
            linearResult.Display();
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }


        Product[] sortedProducts =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(205,"Shoes","Fashion"),
            new Product(309,"Mobile","Electronics"),
            new Product(412,"Watch","Accessories"),
            new Product(520,"Book","Education")
        };


        Console.WriteLine("\nBinary Search Result:");

        Product? binaryResult =
            SearchAlgorithms.BinarySearch(sortedProducts, 412);


        if (binaryResult != null)
        {
            binaryResult.Display();
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }


        Analysis.Explain();


        Console.WriteLine("\n===== Program Completed =====");

    }
}