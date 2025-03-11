
// The problem:
// You are given a record of the historical prices of an investment asset from the last N days.
// Analyze the record in order to calculate what could have been your maximum income.
// Assume you started with one asset of this type and could hold at most one at a time.
// You could choose to sell the asset whenever you held one.
// If you did not hold an asset at some moment, you could always afford to buy an asset (assume you had infinite money available).

//What is the maximum income you could make?

//Since that result may be very large, return its last nine digits without leading zeros (return the result modulo 1,000,000,000).

//Ex1:
//Input = [4,1,2,3]
//Output = 6
//Explanation: Sell @ 4, Buy @ 1, Sell @ 3

//Ex2:
//Input = [1, 2, 3, 3, 2, 1, 5]
//Output = 7
//Explanation: Sell @ 3, Buy @ 1, Sell @ 5

//Ex3:
//Input = [1000000000, 1, 2, 2, 1000000000, 1, 1000000000]
//Output = 999999998
//Explanation: Sell @ 1000000000, Buy @ 1, Sell @ 1000000000, Buy @ 1, Sell @ 1000000000
//The maximum possible income is 2999999998, whose last 9 digits are 999999998


//Constraints
//1 <= n <= 200000
//0 <= arr[i] <= 1000000000



class MaximumProfitOfStocksCalculator
{
    private const int MOD = 1_000_000_000;
    public static int calculateMaximumProfit(int[] prices)
    {
        long result = 0;
        // Create a new array with 0 at the beginning
        int[] newPrices = new int[prices.Length + 1];
        newPrices[0] = 0;
        Array.Copy(prices, 0, newPrices, 1, prices.Length);

        for (int i = 1; i < newPrices.Length; i++)
        {
            result += Math.Max(newPrices[i] - newPrices[i - 1], 0);
        }

        return (int)(result % MOD); // Ensure last 9 digits
    }
}

class Program
{
    static void Main()
    {
        // Example 1
        int[] A1 = { 4, 1, 2, 3 };
        Console.WriteLine("Example 1: " + MaximumProfitOfStocksCalculator.calculateMaximumProfit(A1)); // Expected: 6

        // Example 2
        int[] A2 = { 1000000000, 1, 2, 2, 1000000000, 1, 1000000000 };
        Console.WriteLine("Example 2: " + MaximumProfitOfStocksCalculator.calculateMaximumProfit(A2)); // Expected: 999999998

        // Example 3
        int[] A3 = { 1, 2, 3, 3, 2, 1, 5 };
        Console.WriteLine("Example 3: " + MaximumProfitOfStocksCalculator.calculateMaximumProfit(A3)); // Expected: 7
    }
}
