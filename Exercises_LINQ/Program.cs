using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_LINQ
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return getCanonicalString(x) == getCanonicalString(y);
        }

        public int GetHashCode(string obj)
        {
            return getCanonicalString(obj).GetHashCode();
        }

        private string getCanonicalString(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort<char>(wordChars);
            return new string(wordChars);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Find all elements of numbers with a value less than 5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Where(n => n < 5);


            //Find digits whose name is shorter than their value
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var output = digits.Where((d, i) => d.Length < i).Select(d => $"The word {d} is shorter than its value");


            //Produce a sequence of ints one higher than those in numbers.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Select(d => d + 1);


            //Produce a sequence of the uppercase and lowercase versions of each word in the words.
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var output = words.Select(w => $"Uppercase: {w.ToUpper()}, Lowercase: {w.ToLower()}");


            //Produce a sequence of strings representing the text version of a sequence of ints.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var output = numbers.Select(n => $"{strings[n]}");


            //Produce a sequence containing text representations of digits and a Boolean that specifies whether the text length is even or odd.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var output = numbers.Select(n => new {digitName = strings[n], IsEven = n % 2 == 0});


            //Determine if the value of ints in an array match their position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Select((n, i) => new { Number = n, InCorrectPlace = (n == i) });


            //Make a simple query that returns the text form of each digit less than 5.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var output = numbers.Where(n => n < 5).Select(n => $"{digits[n]}");


            //Make a query that returns all pairs of numbers from both arrays in which the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var output = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select $"{a} is less than {b}";


            //Produce a sequence containing only the first 3 elements of the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Where((n, i) => i < 3);


            //Produce a sequence containing all but the first four elements of the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Where((num, index) => index > 3);


            //Produce a sequence containing starting from the beginning of the array until a number is read whose value is not less than 6.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.TakeWhile(n => n < 6);


            //Produce a sequence containing starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.TakeWhile((n, i) => n > i);


            //Produce a sequence of elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.SkipWhile(n => n % 3 != 0);


            //Produce a sequence containing elements of the array starting from the first element less than its position
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.SkipWhile((n, i) => n > i);


            //Sort a list of words alphabetically.
            //string[] words = { "cherry", "apple", "blueberry" };
            //var output = words.OrderBy(w => w);


            //Sort a list of words by length.
            //string[] words = { "cherry", "apple", "blueberry" };
            //var output = words.OrderBy(w => w.Length);


            //Do a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var output = words.OrderBy(w => w, StringComparer.CurrentCultureIgnoreCase);


            //Sort a list of doubles from highest to lowest.
            //double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            //var output = doubles.OrderByDescending(d => d);


            //Do a case-insensitive sort of the words in an array. Use a custom comparer
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var output = words.OrderByDescending(w => w, new CaseInsensitiveComparer());


            //Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var output = digits.OrderBy(d => d.Length).ThenBy(d => d);


            //Sort first by word length and then by a case-insensitive sort of the words in an array. Use a custom compare
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var output = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.CurrentCultureIgnoreCase);


            //Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var output = digits.Where(w => w[1]  == 'i').Reverse();


            //Use group by to partition a list of numbers by their remainder when divided by 5.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }
            //var output = numbers.GroupBy(n => n % 5).Select(n => new { Remainder = n.Key, Numbers = n });


            //Use group by to partition a list of words by their first letter.
            //string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            //var output = words.GroupBy(w => w[0]).Select(w => new { FirstLetter = w.Key, Word = w });


            //Use GroupBy with method syntax to partition trimmed elements of an array using a custom comparer that matches words that are anagrams of each other.
            //string[] anagrams = { "from ", " salt", " earn ", " last ", " near ", " form " };
            //var output = anagrams.GroupBy(w => w.Trim(),a => a.ToUpper(), new AnagramEqualityComparer());


            //Remove duplicate elements in a sequence of factors of 300.
            //int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            //var output = factorsOf300.Distinct();


            //Use Union to create one sequence that contains the unique values from both arrays.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }; 
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var output = numbersA.Union(numbersB);


            //Use Intersect to create one sequence that contains the common values shared by both arrays.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }; 
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var output = numbersA.Intersect(numbersB);


            //Uses Except to create a sequence that contains the values from numbersAthat are not also in numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var output = numbersA.Except(numbersB);


            //Find the first element in the array that starts with 'o'
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var output = strings.Where(s => s[0] == 'o').OfType<string>().First();


            //Determine if any of the words in the array contain the substring 'ei'.
            //string[] words = { "believe", "relief", "receipt", "field" };
            //var output = words.Where(s => s.Contains("ei"));


            //Determine whether an array contains only odd numbers
            //int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
            //var output = numbers.All(n => n % 2 == 1);


            //Get the number of unique prime factors of 300.
            //int[] primeFactorsOf300 = { 2, 2, 3, 5, 5 };
            //var output = primeFactorsOf300.Distinct().Count();


            //Get the number of odd ints in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Where(n => n % 2 == 1).Count();


            //Add all the numbers in an array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Sum();


            //Get the total number of characters of all words in the array.
            //string[] words = { "cherry", "apple", "blueberry" };
            //var output = words.Select(w => w.Length).Sum();


            //Get the lowest number in an array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Min();


            //Get the length of the shortest word in an array.
            //string[] words = { "cherry", "apple", "blueberry" };
            //var output = words.Select(w => w.Length).Min();


            //Get the highest number in an array
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Max();


            //Get the length of the longest word in an array.
            //string[] words = { "cherry", "apple", "blueberry" };
            //var output = words.Select(w => w.Length).Max();


            //Get the average of all numbers in an array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var output = numbers.Average();


            //Get the average length of the words in the array.
            //string[] words = { "cherry", "apple", "blueberry" };
            //var output = words.Select(w => w.Length).Average();


            //Uses Aggregate to create a running account balance that subtracts each withdrawal from the initial balance of 100, as long as the balance never drops below 0.
            //double startBalance = 100.0;
            //int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };
            //var output = attemptedWithdrawals.Aggregate(startBalance, (balance, nextWithdrawal) => nextWithdrawal <= balance ? balance - nextWithdrawal : balance);


            //Use Concat to create one sequence that contains each array's values, one after the other.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var output = numbersA.Concat(numbersB);


            //Use SequenceEquals to see if two sequences match on all elements in the same order
            //var wordsA = new string[] { "cherry", "apple", "blueberry" };
            //var wordsB = new string[] { "cherry", "apple", "blueberry" };
            //var output = wordsA.SequenceEqual(wordsB);


            //Use SequenceEqual to see if two sequences match on all elements in the same order.
            //var wordsA = new string[] { "cherry", "apple", "blueberry" };
            //var wordsB = new string[] { "apple", "blueberry", "cherry" };
            //var output = wordsA.SequenceEqual(wordsB);
        }
    }
}
