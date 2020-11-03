using System;
using System.Linq;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongCommonPrefix(new string[] { "flower", "flow", "flight" }));
        }


        static string LongCommonPrefix(string[] strs)
        {
            if (strs == null)
            {
                return "";
            }
            
            if (strs.Length == 1)
            {
                return strs[0];
            }

            string prefix = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[0][i] != strs[j][i])
                    {
                        return prefix;
                    }
                }

                prefix += strs[0][i];
            }
            return prefix;
        }
    }
}
