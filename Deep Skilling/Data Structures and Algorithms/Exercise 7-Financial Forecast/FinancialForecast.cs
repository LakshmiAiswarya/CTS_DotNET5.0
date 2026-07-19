public class FinancialForecast
{
    public static double CalculateFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {

        if (years == 0)
        {
            return currentValue;
        }


        return CalculateFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1
        );
    }
}