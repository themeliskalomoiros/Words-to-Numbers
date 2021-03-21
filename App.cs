using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Program
    {
        const string Hundred = "hundred";
        const string Thousand = "thousand";
        const string And = "and";

        static void Main(string[] args)
        {
            Console.WriteLine(ParseInt("one thousand"));
        }

        public static int ParseInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Invalid string!");
                return -1;
            }

            s = s.ToLower().Trim();

            if (s == "one million")
                return 1000000;

            var sum = 0;
            var multiplier = 1;
            var currentNumber = 0;
            var stack = new Stack<string>(s.Split());

            while (stack.Count > 0)
            {
                var item = stack.Pop();
                
                if (IsOneNumericWord(item))
                {
                    currentNumber = ParseOneNumericWord(item);
                    sum += currentNumber * multiplier;
                }
                else if (IsTwoNumericWords(item))
                {
                    currentNumber = ParseTwoNumericWords(item);
                    sum += currentNumber * multiplier;
                }
                else if (item == And)
                {
                    continue;
                }
                else if (item == Hundred)
                {
                    if (multiplier == 1000)
                    {
                        multiplier = 100000;
                    }
                    else
                    {
                        multiplier = 100;
                    }
                }
                else if (item == Thousand)
                {
                    multiplier = 1000;
                }
                else
                {
                    Console.WriteLine("Invalid string!");
                    return -1;
                }
            }

            return sum;
        }

        static bool IsOneNumericWord(string s)
        {
            return
                s == "zero" || s == "one" || s == "two" || s == "three" ||
                s == "four" || s == "five" || s == "six" || s == "seven" ||
                s == "eight" || s == "nine" || s == "ten" || s == "eleven" ||
                s == "twelve" || s == "thirteen" || s == "fourteen" ||
                s == "fifteen" || s == "sixteen" || s == "seventeen" ||
                s == "eighteen" || s == "nineteen" || s == "twenty" ||
                s == "twenty" || s == "thirty" || s == "forty" ||
                s == "fifty" || s == "sixty" || s == "seventy" ||
                s == "eighty" || s == "ninety";
        }

        static int ParseOneNumericWord(string s)
        {
            switch (s)
            {
                case "zero":
                    return 0;
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                case "ten":
                    return 10;
                case "eleven":
                    return 11;
                case "twelve":
                    return 12;
                case "thirteen":
                    return 13;
                case "fourteen":
                    return 14;
                case "fifteen":
                    return 15;
                case "sixteen":
                    return 16;
                case "seventeen":
                    return 17;
                case "eighteen":
                    return 18;
                case "nineteen":
                    return 19;
                case "twenty":
                    return 20;
                case "thirty":
                    return 30;
                case "forty":
                    return 40;
                case "fifty":
                    return 50;
                case "sixty":
                    return 60;
                case "seventy":
                    return 70;
                case "eighty":
                    return 80;
                case "ninety":
                    return 90;
            }

            throw new ArgumentException();
        }

        static bool IsTwoNumericWords(string s)
        {
            return s.Split('-').Length == 2;
        }

        static int ParseTwoNumericWords(string s)
        {
            var arr = s.Split('-');

            var dozen = ParseOneNumericWord(arr[0]);
            var digit = ParseOneNumericWord(arr[1]);

            return digit + dozen;
        }
    }
}
