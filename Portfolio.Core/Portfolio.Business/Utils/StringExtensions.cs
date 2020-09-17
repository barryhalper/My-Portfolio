using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Portfolio.Business.Utils
{
    public static class StringExtensions
    {
        public static string StripHTML(this string htmlString)
        {

            return Regex.Replace(htmlString, @"<(.|\n)*?>", string.Empty); ;
        }

        //' <summary>
        /// Function to * get number of characters from a string without cutting off in the middle of a word
        public static string WordCut(this string text, int cutOffLength, char[] separators)
        {
            cutOffLength = cutOffLength > text.Length ? text.Length : cutOffLength;
            int separatorIndex = text.Substring(0, cutOffLength).LastIndexOfAny(separators);
            if (separatorIndex > 0)
                return text.Substring(0, separatorIndex);
            return text.Substring(0, cutOffLength);
        }


        //' <summary>
        /// Function to * get number of characters from a string without cutting off in the middle of a word
        public static string WordCut(this string text, int cutOffLength)
        {
            char[] separators = new char[] { ' ', '.', ',', ';' };
            cutOffLength = cutOffLength > text.Length ? text.Length : cutOffLength;
            int separatorIndex = text.Substring(0, cutOffLength).LastIndexOfAny(separators);
            if (separatorIndex > 0) { 
                return $"{text.Substring(0, separatorIndex)}..";
                }
            return text.Substring(0, cutOffLength);
        }

        public static string StripNonNumbersLetters(this string text)
        {
            //Regex r = new Regex(@"([^\d\w])");
            return Regex.Replace(text, @"[^A-Za-z0-9]+", string.Empty);
        }

        public static string UrlFriendly(this string str)
        {
            string s = str.Replace(" & ", "and").Replace(" ", "-");
            return Regex.Replace(s, @"[^\w \.@-]", "").Trim();
        }

        public static string FirstSentence(this string text, int minLength = 10)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            var sentences = Regex.Split(text, @"(.[^\.\!\?]*(?>\.[^\s\.][^\.\!\?]+)*[\.\!\?]*)", RegexOptions.Multiline)
                .Where(s => !string.IsNullOrEmpty(s))
                .Select(s => s.Trim())
                .ToArray();

            var result = string.Empty;

            foreach (var s in sentences)
            {
                result = $"{result} {s}".Trim();

                if (result.Length >= minLength)
                {
                    break;
                }
            }

            return result;
        }

        public static string SentenceCase(this string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                var lowerCase = text.ToLower();
                // matches the first sentence of a string, as well as subsequent sentences
                var regex = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
                // MatchEvaluator delegate defines replacement of setence starts to uppercase
                return regex.Replace(lowerCase, s => s.Value.ToUpper());
            }
            else
                return text;

        }
    }
}
