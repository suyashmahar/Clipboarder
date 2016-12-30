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
        public static List<ColoredKeyword> CompileFromFile(string language) {
            if (!doesLanguageExists(language))
                throw new ArgumentException("Language file for the specified language does not exist at default path");

            XmlTextReader reader = new XmlTextReader(getLanguagePath(language));

            List<ColoredKeyword> keywords = new List<ColoredKeyword>();
            Color currentColor = Color.White;
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

            // Removes path and leaves names
            for (int i = 0; i < languages.Length; i++) {
                languages[i] = Path.GetFileNameWithoutExtension(languages[i]);
            }

            List<string> languagesToReturn = new List<string>();
            foreach (string language in languages) {
                languagesToReturn.Add(language);
            }

            return languagesToReturn;
        }
        public static bool doesLanguageExists(string language) {
            List<string> languages = GetLanguages();

            bool result = false;

            languages.ForEach(l => {
                if (l == language) result = true;
            });

            return result;
        }
        public static string getLanguagePath(String language) {
            return System.IO.Path.Combine(
                Application.StartupPath,
                "SHLs",
                language + ".xml");
        }
    }
    public class ColoredKeyword {
        public string keyword;
        public Color color;

        public ColoredKeyword(string keyword, Color color) {
            this.keyword = keyword;
            this.color = color;
        }
    }
}
