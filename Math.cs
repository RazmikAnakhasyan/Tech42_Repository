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
            
                Regex pattern = new Regex(@"\d[]");
          
            
            
            MatchCollection matches = pattern.Matches(input);
            foreach (Match match in matches)
            {

                Console.WriteLine(match.Value);
                
            }
        }
    }
}
