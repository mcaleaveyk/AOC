using System.IO;
using System.Linq;

public class Day1Part1 
{
    public long NumberFinder()
    {
        string filePath = "D:\\repos\\AOC\\AOC2023\\inputs\\Day1Input.txt";

        if(File.Exists(filePath))
        {
            StreamReader streamReader = new StreamReader(filePath);
            string content = streamReader.ReadToEnd();

            var newContent = content.Split("\r\n");

            long total = 0;
            foreach(var line in newContent)
            {
                int firstDigit = line.First(line => char.IsDigit(line)) - '0';
                int lastDigit = line.Last(line => char.IsDigit(line)) - '0';

                var fullNumber = firstDigit * 10 + lastDigit;
                total += fullNumber;
            }
            System.Console.WriteLine(total);
            return total;
        }
        return 0;
    }
}