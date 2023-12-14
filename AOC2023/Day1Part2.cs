using System.Collections.Generic;
using System.IO;

public class Day1Part2
{
    string filePath = "D:\\repos\\AOC\\AOC2023\\inputs\\Day1Input.txt";

    public long NumberFinderPart2()
    {
        var digits = new Dictionary<string, int>()
        {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        for(int i = 1; i < 10; i++)
        {
            digits.Add(i.ToString(), i);
        }

        if(File.Exists(filePath))
        {
            StreamReader streamReader = new StreamReader(filePath);
            string content = streamReader.ReadToEnd();

            var newContent = content.Split("\r\n");
            var total = 0;
            
            foreach(var line in newContent)
            {
                var firstIndex = line.Length;
                var lastIndex = -1;
                var firstValue = 0;
                var lastValue = 0;


                foreach(var digit in digits)
                {
                    var index = line.IndexOf(digit.Key);
                    if(index == -1) continue;
                    if(index < firstIndex)
                    {
                        firstIndex = index;
                        firstValue = digit.Value;
                    }

                    index = line.LastIndexOf(digit.Key);

                    if(index > lastIndex)
                    {
                        lastIndex = index;
                        lastValue = digit.Value;
                    }
                }

                var fullNumber = firstValue * 10 + lastValue;
                total += fullNumber;
            }
            System.Console.WriteLine(total);
            return total;
        }
        return -1;
    }
}