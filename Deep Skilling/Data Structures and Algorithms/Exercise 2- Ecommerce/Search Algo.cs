public class SearchAlgorithms
{

    // Linear Search
    public static Product? LinearSearch(Product[] products, int id)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].ProductId == id)
            {
                return products[i];
            }
        }

        return null;
    }



    // Binary Search
    public static Product? BinarySearch(Product[] products, int id)
    {
        int left = 0;
        int right = products.Length - 1;


        while (left <= right)
        {
            int middle = (left + right) / 2;


            if (products[middle].ProductId == id)
            {
                return products[middle];
            }


            else if (products[middle].ProductId < id)
            {
                left = middle + 1;
            }


            else
            {
                right = middle - 1;
            }
        }


        return null;
    }
}