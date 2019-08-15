using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var testArr = new int[] { 1, 2, 3, 4, 4, 5 }; // should be 4
            var testArr2 = new int[] { 1, 2, 2, 4, 5, 6 }; //should be true

            Console.WriteLine(FirstNonRepeatingNumber(testArr));
            Console.WriteLine(CheckForDuplicates(testArr2));
            Console.ReadLine();
        }

        static public int FirstNonRepeatingNumber(Array InputArray)
        {
            var myDictionary = new Dictionary<int, int>();
            int answer = 0;
            foreach(int numb in InputArray)
            {
                if (myDictionary.ContainsKey(numb))
                {
                    myDictionary[numb]++;
                }
                else
                {
                    myDictionary.Add(numb, 1);
                }
            }
            answer = myDictionary.Aggregate((x, y) => x.Value > y.Value ?  x :  y).Key;

            return answer;
        }

        static public bool CheckForDuplicates(int[] inputArray)
        {

            bool answer = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray[i]; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        answer = true;
                        break;
                    }
                }
            }
            return answer;
        }

    }
}
