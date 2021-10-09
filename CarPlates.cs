using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homweork
{
    public class CarPlates : RegexExpression
    {
        public static void SearchCarPlates()
        {    
                string pattern = File.ReadAllText("licenseplates.txt").ToString();
                System.Text.RegularExpressions.Regex regex = new Regex(@"\d{2}[A-Z]{2}\d{3}");
                MatchCollection matches = regex.Matches(pattern);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        Console.WriteLine(match.Value);
                }
                else
                {
                    Console.WriteLine("No Matche's");
                }
        }
    }
}

