using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;

namespace Clipboarder.SyntaxHighlighting {
    public class Languages {
        /// <summary>
        /// Returns List of ColoredKeyword after parsing XML 
        /// from the file of which name is supplied
        /// </summary>
        /// <param name="language">Name of language to comile from</param>
        /// <returns>List of Colored keywords from file</returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<ColoredKeyword> CompileFromFile(string language) {
            if (!doesLanguageExists(language))
                throw new ArgumentException("Language file for the specified language does not exist at default path");

            XmlTextReader reader = new XmlTextReader(getLanguagePath(language));

            List<ColoredKeyword> keywords = new List<ColoredKeyword>();

            //Stores color while reading words from XML
            Color currentColor = Color.White;

            //Reads XML file
            while (reader.Read()) {
                switch (reader.NodeType) {
                    case XmlNodeType.Element:
                        if (reader.Name.ToLower() == "words") {
                            reader.MoveToFirstAttribute();
                            currentColor = Color.FromName(reader.Value);
                            break;
                        }
                        break;
                    case XmlNodeType.Text:
                        keywords.Add(new ColoredKeyword(reader.Value, currentColor));
                        break;
                }
            }

            return keywords;
        }
        public static List<string> GetLanguages() {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "SHLs");
            string[] languages = Directory.GetFiles(filePath, "*.xml");

            // Removes path and extension from language files
            for (int i = 0; i < languages.Length; i++) {
                languages[i] = Path.GetFileNameWithoutExtension(languages[i]);
            }

            List<string> languagesToReturn = new List<string>();
            foreach (string language in languages) {
                languagesToReturn.Add(language);
            }

            return languagesToReturn;
        }
        /// <summary>
        /// Checks SHLs directory for specified file
        /// </summary>
        /// <param name="language">Name of language to search file for</param>
        /// <returns></returns>
        public static bool doesLanguageExists(string language) {
            List<string> languages = GetLanguages();

            bool result = false;

            languages.ForEach(l => {
                if (l == language) result = true;
            });

            return result;
        }
        /// <summary>
        /// Returns file path for the language specified
        /// </summary>
        public static string getLanguagePath(String language) {
            return System.IO.Path.Combine(
                Application.StartupPath,
                "SHLs",
                language + ".xml");
        }
    }

}
