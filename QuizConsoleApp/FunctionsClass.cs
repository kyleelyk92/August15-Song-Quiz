using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsoleApp
{
    class FunctionsClass
    {
        static public int FirstNonRepeatingNumber(Array InputArray)
        {
            var myDictionary = new Dictionary<int, int>();
            int answer = 0;
            foreach (int numb in InputArray)
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
            answer = myDictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

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
