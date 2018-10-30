using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem3CryptoBlockchain
{
    class CryptoBlockchain
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string cryptoChain = "";

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();

                cryptoChain += input;
            }

            string pattern = @"{[^\]\[{]+}|\[[^{}\[]+\]";
            MatchCollection matches = Regex.Matches(cryptoChain, pattern);

            List<string> valid = new List<string>();

            foreach (var match in matches)
            {
                valid.Add(match.ToString());
            }
            for (int i = 0; i < valid.Count; i++)
            {
                foreach (var str in valid)
                {
                    string numPattern = @"[0-9]{3}";
                    MatchCollection numMatches = Regex.Matches(str, numPattern);
                    string nums = "";

                    foreach (var num in numMatches)
                    {
                        nums += num.ToString();
                    }
                    if (nums.Length % 3 != 0)
                    {
                        valid.Remove(valid[i]);
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
