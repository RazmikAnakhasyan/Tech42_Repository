using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homweork
{
    class UserData : RegexExpression
    {
        public static void MaskSerialNumber()
        {
            string input = File.ReadAllText("UserData.txt").ToString();
            Regex pattern = new Regex(@"[A-Z]{2}\d{7}");
            MatchCollection matches = pattern.Matches(input);
            foreach (Match match in matches)
            {
               
                Console.WriteLine(Regex.Replace(input, @"\d(?!\d{0,3}$)", "*"));
                break;
            }
            
        }
    }
}
