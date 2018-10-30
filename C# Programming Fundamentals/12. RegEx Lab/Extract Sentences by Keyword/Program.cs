using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string regex = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

        string emails = Console.ReadLine();

        MatchCollection mails = Regex.Matches(emails, regex);

        string[] validEmails = mails
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        foreach (var mail in validEmails)
        {
            Console.WriteLine(mail);
        }
    }
}