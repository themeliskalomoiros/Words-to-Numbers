using System;
using Xunit;
using static App.Program;

namespace App.Test
{
    public class AppShould
    {
        [Theory]
        [InlineData("zero", 0)]
        [InlineData("one", 1)]
        [InlineData("two", 2)]
        [InlineData("three", 3)]
        [InlineData("four", 4)]
        [InlineData("five", 5)]
        [InlineData("six", 6)]
        [InlineData("seven", 7)]
        [InlineData("eight", 8)]
        [InlineData("nine", 9)]
        void ParseDigit(string s, int expected)
        {
            var actual = ParseInt(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("ten", 10)]
        [InlineData("eleven", 11)]
        [InlineData("twelve", 12)]
        [InlineData("thirteen", 13)]
        [InlineData("fourteen", 14)]
        [InlineData("fifteen", 15)]
        [InlineData("sixteen", 16)]
        [InlineData("seventeen", 17)]
        [InlineData("eighteen", 18)]
        [InlineData("nineteen", 19)]
        [InlineData("twenty", 20)]
        [InlineData("thirty", 30)]
        [InlineData("forty", 40)]
        [InlineData("fifty", 50)]
        [InlineData("sixty", 60)]
        [InlineData("seventy", 70)]
        [InlineData("eighty", 80)]
        [InlineData("ninety", 90)]
        [InlineData("twenty-one", 21)]
        [InlineData("thirty-two", 32)]
        [InlineData("forty-three", 43)]
        [InlineData("fifty-four", 54)]
        [InlineData("sixty-five", 65)]
        [InlineData("seventy-six", 76)]
        [InlineData("eighty-seven", 87)]
        [InlineData("ninety-eight", 98)]
        void ParseDozen(string s, int expected)
        {
            var actual = ParseInt(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("one hundred", 100)]
        [InlineData("one hundred twenty-six", 126)]
        [InlineData("two hundred", 200)]
        [InlineData("two hundred and thirty-five", 235)]
        [InlineData("three hundred", 300)]
        [InlineData("three hundred thirty-three", 333)]
        [InlineData("four hundred", 400)]
        [InlineData("four hundred and ninety-eight", 498)]
        [InlineData("five hundred", 500)]
        [InlineData("six hundred", 600)]
        [InlineData("seven hundred", 700)]
        [InlineData("seven hundred and fifty-two", 752)]
        [InlineData("eight hundred", 800)]
        [InlineData("nine hundred", 900)]
        void ParseHundred(string s, int expected)
        {
            var actual = ParseInt(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("one thousand", 1000)]
        [InlineData("one thousand six", 1006)]
        [InlineData("one thousand thirteen", 1013)]
        [InlineData("one thousand fifty-seven", 1057)]
        [InlineData("one thousand two hundred thirty-two", 1232)]
        [InlineData("eleven thousand four", 11004)]
        [InlineData("eleven thousand forty", 11040)]
        [InlineData("eleven thousand four hundred", 11400)]
        [InlineData("eleven thousand four hundred three", 11403)]
        [InlineData("eleven thousand four hundred thirty-three", 11433)]
        [InlineData("two hundred thousand", 200000)]
        [InlineData("two hundred thousand one", 200001)]
        [InlineData("two hundred thousand ten", 200010)]
        [InlineData("two hundred thousand thirty-four", 200034)]
        [InlineData("two hundred thousand two hundred", 200200)]
        [InlineData("two hundred thousand two hundred four", 200204)]
        [InlineData("two hundred thousand two hundred seventy-four", 200274)]
        [InlineData("two hundred one thousand two hundred seventy-four", 201274)]
        [InlineData("two hundred seventy-one thousand two hundred seventy-four", 271274)]
        void ParseThousand(string s, int expected)
        {
            var actual = ParseInt(s);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void ParseMillion()
        {
            var expected = 1000000;
            var actual = ParseInt("one million");
            Assert.Equal(expected, actual);
        }

    }
}
