using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.P155
{
    public class MinStack
    {
        private Stack<int> _stack;
        private int _minElement;

        public MinStack()
        {
            _stack = new Stack<int>();
            _minElement = int.MaxValue;
        }

        public void Push(int x)
        {
            _stack.Push(x);
            if (x < _minElement)
            {
                _minElement = x;
            }
        }

        public void Pop()
        {
            _stack.Pop();
            if (_stack.Count > 0)
            {
                _minElement = _stack.Min();
            }
            else
            {
                _minElement = int.MaxValue;
            }
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _minElement;
        }
    }
}
