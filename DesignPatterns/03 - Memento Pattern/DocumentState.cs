using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03___Memento_Pattern
{
    public class DocumentState
    {
        private string content;
        private string fontName;
        private int fontSize;
        public DocumentState(string content, string fontName, int fontSize)
        {
            this.content = content;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }        
        public string getContent()
        {
            return content;
        }
        public int getFontSize()
        {
            return fontSize;
        }
        public string getFontName()
        {
            return fontName;
        }
    }
}
