using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Clipboarder {
    class ContentIdentifier {
        public const string DefaultURLregex = @"((([A - Za - z]{ 3, 9 }:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)";


        public static bool containsURL(string inputString, string URLregex = DefaultURLregex) {
            Regex regex = new Regex(URLregex);
            MatchCollection match = regex.Matches(inputString);
            if (match.Count > 0) return true;
            return false;
        }

        public static List<string> GetURLs(string inputString, string URLregex = DefaultURLregex) {
            Regex regex = new Regex(URLregex);
            MatchCollection match = regex.Matches(inputString);

            List<string> listToReturn = new List<string>();

            if (match.Count > 0) {
                for (int i = 0; i < match.Count; i++) {
                    listToReturn.Add(match[i].ToString());
                }
            } else {
                listToReturn = null;
            }
            return listToReturn;
        }

        public static string CheckAndAppendHTTP(string inputString) {
            if (!inputString.Contains("https://") && !inputString.Contains("http://")) {
                inputString = "http://" + inputString;
            }
            return inputString;
        }
    }
}
