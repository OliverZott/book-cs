using System;
using System.Linq;
using System.Reflection;

// #error version

namespace Basics
{
    // Showing all types in various assemblies and all the methods for the types
    class Program
    {
        static void Main(string[] args)
        {

            // Loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies()) 
            {

                //System.Data.DataSet ds;
                //System.Net.Http.HttpClient client;

                var a  = Assembly.Load(new AssemblyName(r.FullName));
                int methodCount = 0;

                // Loop through all types in this assembly
                foreach (var t in a.DefinedTypes) {
                    methodCount += t.GetMethods().Count();
                }

                // Output the count of typs and their methods
                System.Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.", 
                    arg0: a.DefinedTypes.Count(), 
                    arg1: methodCount, 
                    arg2: r.Name
                );

            }
        }
    }
}
