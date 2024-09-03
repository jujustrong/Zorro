namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        
    }

    public static int PositiveSum(int[] arr)
    {
        var counter = 0;
        foreach (var num in arr)
        {
            if (num > 0)
            {
                counter += num;
            }
        }

        return counter;

    }
}