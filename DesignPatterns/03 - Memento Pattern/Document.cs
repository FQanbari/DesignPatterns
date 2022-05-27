using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03___Memento_Pattern
{
    public class Document
    {
        private string content;
        private string fontName;
        private int fontSize;

        public DocumentState createState()
        {
            return new DocumentState(content,fontName,fontSize);
        }
        public void restore(DocumentState state)
        {
            content = state.getContent();
            fontName = state.getFontName();
            fontSize = state.getFontSize();
        }
        public string getContent()
        {
            return content;
        }
        public void setContent(string content)
        {
            this.content = content;
        }
        public string getFontName()
        {
            return fontName;
        }        
        public void setFontName(string fontName)
        {
            this.fontName = fontName;
        }
        public int getFontSize()
        {
            return fontSize;
        }
        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }
        public string toString()
        {
            return "Document{" +
                    "content='" + content + '\'' +
                    ", fontName='" + fontName + '\'' +
                    ", fontSize=" + fontSize +
                    '}';
        }
    }
}
