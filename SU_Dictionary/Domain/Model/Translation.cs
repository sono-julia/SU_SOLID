using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU_Dictionary.Domain.Model
{
    public class Translation
    {
        private List<string> translations;
        private String word;
        private String language;

        public Translation(List<string> translations, string word, string language)
        {
            this.Translations = translations;
            this.Word = word;
            this.Language = language;
        }

        public List<string> Translations { get => translations; set => translations = value; }
        public string Word { get => word; set => word = value; }
        public string Language { get => language; set => language = value; }
    }
}
