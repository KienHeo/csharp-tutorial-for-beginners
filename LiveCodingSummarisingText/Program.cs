using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSummarisingText
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentence = "This is going to be a really really really really really really long text.";
            var summary = StringUltility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}