using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var x = 0;


            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                { x += numbers[i]; }

                if (numbers[i] % 2 != 0)
                { x -= numbers[i]; }
            }
            return x;              
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strings = new List<string>();
            strings.Add(str1);
            strings.Add(str2);
            strings.Add(str3);
            strings.Add(str4);
           return strings.Min(x => x.Length);
        }
    

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3); 
            numbers.Add(number4);
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3)
                return false;

            if (sideLength1 + sideLength3 <= sideLength2)
                return false;

            if (sideLength2 + sideLength3 <= sideLength1)
                return false;

            else return true;
        }

        public bool IsStringANumber(string input)
        {
           
            bool isNumeric = double.TryParse(input, out double n);
            return isNumeric;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {int x = 0;
            for (int i = 0; i < objs.Length; i++)
             if (objs[i] == null)
                    x++;
            if (objs.Length /2  < x)
                return true;
            else
               return false;

        }

        public double AverageEvens(int[] numbers)
        {  
        double sum = 0;
            double count = 0;

            if(numbers == null)
            {
                return 0;
            }

            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            if(count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
            
        }
        public int Factorial(int number)
        {
            int count = 1;
            int fact = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (count = 1; count <= number; count++)
            {
                fact = fact * count;
            }
            return fact;



        }
    }
}
