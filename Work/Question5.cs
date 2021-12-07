using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
  public class Question5
    {
        public string ReverseSentence(string sentence)
        {
            string result = "";
            for (int i = sentence.Length-1; i >= 0; i--)
            {
                result += sentence[i];
            }
            return result;
        }
    }
}
