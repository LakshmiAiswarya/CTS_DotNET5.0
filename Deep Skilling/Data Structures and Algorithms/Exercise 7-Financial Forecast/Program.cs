using System;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("===== Financial Forecasting Tool =====");


        double currentValue = 10000;

        double growthRate = 0.10;   // 10% growth

        int years = 5;



        Console.WriteLine("\nInitial Investment Value: "
            + currentValue);


        Console.WriteLine("Annual Growth Rate: "
            + (growthRate * 100) + "%");


        Console.WriteLine("Forecast Period: "
            + years + " years");



        double futureValue =
            FinancialForecast.CalculateFutureValue(
                currentValue,
                growthRate,
                years
            );



        Console.WriteLine(
            "\nPredicted Future Value: "
            + futureValue
        );



        Analysis.Explain();



        Console.WriteLine(
        "\n===== Forecast Completed ====="
        );

    }
}