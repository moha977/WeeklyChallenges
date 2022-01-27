using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           var letter = (Char.IsLetter(c));
            return letter;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {

            if (vals.Length % 2 == 0)
                return true;
            else 
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            
                return true;
                else
                 return false;
            
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 <  0 )
                return true;
            if (num % 2 > 0)
                return true;
            else 
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            if (numbers.Count() == 0)
                return 0;
            var number = numbers.Min ();
            var num = numbers.Max ();
            var minMax = number + num;
           return minMax;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var longString = str1.Length < str2.Length ? str1.Length : str2.Length;
            return longString;
           

        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
               sum += numbers[i]; 
            }
           return sum;
            
          
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sumEvens = 0;
           for (int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                sumEvens += numbers[i];
            }
            return sumEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
           if (numbers == null)
                return false;
            int sumOdds = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sumOdds += numbers[i];
            }
            if (sumOdds % 2 != 0)
                return true;
            else
                return false;   
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
         if (number < 0)
                return 0;
            return number / 2;
        }
    }
}
