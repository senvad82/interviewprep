using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class BreakPalindrome
    {


        
            public static string GetBreakPalindrome(string palindrome)
            {
                StringBuilder sb = new StringBuilder();
                if (palindrome.Length == 1) return " ";
                var mid = palindrome.Length / 2;
                var found = false;
                for (int i = 0; i < palindrome.Length; i++)
                {
                    if (palindrome.Length % 2 == 1 && i == mid - 1) continue;
                    if (palindrome[i] != 'a')
                    {
                        sb.Append('a');
                        found = true;
                        sb.Append(palindrome.Substring(i + 1, palindrome.Length - 1 - i));
                        break;
                    }
                    else
                    {
                        sb.Append(palindrome[i]);
                    }


                }
                if (!found)
                {
                    sb.Remove(palindrome.Length - 1, 1);
                    sb.Append('b');
                }
                return sb.ToString();

            }
        



    }
}
