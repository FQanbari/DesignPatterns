using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03___Memento_Pattern
{
    public class EditorState
    {
        private string content;

        public EditorState(string content)
        {
            this.content = content;
        }
        public string getContent()
        {
            return content;
        }
    }
}
