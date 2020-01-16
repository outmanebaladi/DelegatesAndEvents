using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class ProcessData
    {
        public void Process(int x, int y, Func<int, int, int> del)
        {
            int result = del(x, y);
            Console.WriteLine(result);
        }

        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action has been performed");
        }
    }
}
