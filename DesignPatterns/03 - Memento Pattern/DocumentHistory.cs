using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03___Memento_Pattern
{
    class DocumentHistory
    {
        private Stack<DocumentState> states = new Stack<DocumentState>();
        public void push(DocumentState state)
        {
            states.Push(state);
        }
        public DocumentState pop()
        {
            return states.Pop();
        }
    }
}
