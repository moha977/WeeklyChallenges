using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           if (vals == null || vals.Length == 0)
                return false;
            var b = vals[0];
           if ( b = vals.Contains(false))
                return true;
           else 
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false ;
            var b = 0;
           foreach (var n in numbers)
                if(n % 2 != 0)
                    b++;
           if (b % 2 != 0)
                return true;
           else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {    
            if (password.Length >= 0 && password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit))
                return true;
            else 
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
           // val.ToArray();
           // return val[val.Length - 1];
            char x = val[val.Length -1];  return x;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            var x = dividend / divisor; return x;
            
        }

        public int LastMinusFirst(int[] nums)
        {
            
            var x = nums [nums.Length -1];
            var y = nums[0];
            return x - y;

        }

        public int[] GetOddsBelow100()
        {  
            var odd = Enumerable.Range(1, 100).Where(i => i % 2 != 0);
            return odd.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
          

        }
    }
}
