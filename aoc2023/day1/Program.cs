using System.Text;

class Program
{
    static void Main()
    {
        string filepath = "C:\\Users\\ward\\source\\repos\\aoc2023\\aoc2023\\day1\\input.txt";
        StreamReader streamReader = new StreamReader(filepath);
        string[] numberStrings = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int sum = 0;
        StringBuilder sb = new StringBuilder();
        while (!streamReader.EndOfStream)
        {
            foreach (Char c in streamReader.ReadLine())
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }
            char first = sb.ToString()[0];
            char last = sb.ToString()[sb.ToString().Length - 1];
            sb.Clear();
            sb.Append(first).Append(last);
            sum += Convert.ToInt32(sb.ToString());
            sb.Clear();
        }
        Console.WriteLine(sum);
    }
}