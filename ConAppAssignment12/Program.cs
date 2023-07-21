using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConAppAssignment12
{
    public class TextProcessor
    {
        public static int CountWords(string text)
        {
            return Regex.Matches(text, @"\b\w+\b").Count;
        }
        public static List<string> ValidateEmail(string text)
        {
            List<string> emailAddress = new List<string>();
            var matches = Regex.Matches(text, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");
            foreach (Match match in matches)
            {
                emailAddress.Add(match.Value);
            }
            return emailAddress;
        }
        public static List<string> ExtractMobNo(string text)
        {
            List<string> mobNos = new List<string>();
            var matches = Regex.Matches(text, @"\b\d{10}\b");
            foreach(Match match in matches)
            {
                mobNos.Add(match.Value);
            }
            return mobNos;
        }
        public static List<string> CustomRegexSearch(string text, string pattern)
        {
            List<string> customMatches = new List<string>();
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                customMatches.Add(match.Value);
            }
            return customMatches;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to be matched");
            string inputText = Console.ReadLine();
            int wordCount = TextProcessor.CountWords(inputText);
            List<string> emailAddresses = TextProcessor.ValidateEmail(inputText);
            List<string> mobileNumbers = TextProcessor.ExtractMobNo(inputText);
            Console.WriteLine("Input: \t" + inputText);
            Console.WriteLine("Word Count: " + wordCount);
            if (emailAddresses.Count > 0)
            {
                Console.WriteLine("Email Addresses found:");
                foreach (var email in emailAddresses)
                {
                    Console.WriteLine(email);
                }
            }
            else
            {
                Console.WriteLine("No email addresses present");
            }

            if (mobileNumbers.Count > 0)
            {
                Console.WriteLine("Mobile Numbers found:");
                foreach (var number in mobileNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("No mobile numbers present");
            }

            Console.WriteLine("Enter a custom regular expression:");
            string customRegex = Console.ReadLine();
            List<string> customMatches = TextProcessor.CustomRegexSearch(inputText, customRegex);

            if (customMatches.Count > 0)
            {
                Console.WriteLine("Custom Regex matches:");
                foreach (var match in customMatches)
                {
                    Console.WriteLine(match);
                }
            }
            else
            {
                Console.WriteLine("No matches found for the custom regex");
            }


            Console.ReadKey();
        }
    }
}
