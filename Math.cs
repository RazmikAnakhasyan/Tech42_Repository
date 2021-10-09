using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homweork
{
    class Math : RankException
    {
        public static void SolveTusk() 
        {
            string input = File.ReadAllText("Math.txt").ToString();
            
                Regex pattern = new Regex(@"(\d{1,})(\+|\-|\/|\*)(\d{1,})");
          
            
            
            MatchCollection matches = pattern.Matches(input);
            foreach (Match match in matches)
            {
            
                switch (match.Groups[2].Value.ToString())
                {
                    case "+":
                        Console.WriteLine($"{ match.Groups[0].Value} = {int.Parse(match.Groups[1].Value) + int.Parse(match.Groups[3].Value)}\n");
                        break;
                    case "-":
                        Console.WriteLine($"{ match.Groups[0].Value} = {int.Parse(match.Groups[1].Value) - int.Parse(match.Groups[3].Value)}\n");
                        break;
                    case "*":
                        Console.WriteLine($"{ match.Groups[0].Value} = {int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[3].Value)}\n");
                        break;
                    case "/":
                        Console.WriteLine($"{ match.Groups[0].Value} = {int.Parse(match.Groups[1].Value) / int.Parse(match.Groups[3].Value)}\n");
                        break;

                }
                
                

            }
        }
    }
}
