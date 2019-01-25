using System;

public class Test
{
    public static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            string line = Console.ReadLine();
            string[] space = line.Split(',');
            int num = int.Parse(space[0]);
            int baseNum = int.Parse(space[1]);
            string res = ConvertNumber(num, baseNum);
            Console.WriteLine($"{res}");
        }
    }
    static string Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

    public static string ConvertNumber(int num, int baseNum)
    {

        var result = "";
        do
        {
            var partResult = (int)(num % baseNum);
            result = result.Insert(0, charReplace(partResult));
            num /= baseNum;
        } while (num != 0);

        return result;
    }

    private static string charReplace(int number)
    {
        if (number < 10)
        {
            return number.ToString();
        }

        return Symbols[number - 10].ToString();
    }
}