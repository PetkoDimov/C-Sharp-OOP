using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        private Stack<string> stack;
        public StackOfStrings()
        {
            stack = new Stack<string>();
        }

        public bool IsEmpty()
        {

            return this.Count == 0;
        
        }

        public Stack<string> AddRange(IEnumerable<string> range)
        {

            foreach (var item in range)
            {
                this.Push(item);
            }

            return this;
        
        }

        public int Capacity { get; set; }

    }
}
