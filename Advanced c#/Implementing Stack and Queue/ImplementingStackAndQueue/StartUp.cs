using System;
using System.Threading.Channels;

namespace ImplementingStackAndQueue
{
    /// <summary>
    /// Our StartUp class is public.
    /// </summary>
    public class StartUp
    {
        static void Main(string[] args)
        {
            //We are calling our list.
            var list = new MyList();
            //We are calling our stack.
            var stack = new MyStack();
        }
    }
}
