using System;
using System.Diagnostics;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("This is \"Debug\"");
            Trace.WriteLine("This is \"Trace\"");
        }
    }
}
