using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BhagyoLetterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Regex MyRegex = new Regex("[^a-z]", RegexOptions.IgnoreCase);
            string name = "B,ha'@gy$.od?a>y";
            string s = MyRegex.Replace(name, @"");

            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict = p.getcount(s);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key.ToString() + "   " + item.Value.ToString());
            }

            Console.ReadLine();
        }

        public Dictionary<char, int> getcount(string name)
        {
            return name.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
