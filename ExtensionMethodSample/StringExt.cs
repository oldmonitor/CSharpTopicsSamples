using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTopicsSamples.ExtensionMethodSample
{
    public static class StringExt
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if(numberOfWords <= 0)
            {
                return "";
            }

            var words = str.Split(' ');
            if(words.Length <= numberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
