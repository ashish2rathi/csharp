using System;
using System.Runtime.CompilerServices;

namespace ModuleInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Initialize Module
    namespace System.Runtime.CompilerServices
    {
        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
        public sealed class ModuleInitializerAttribute : Attribute { }
    }

    //Usage Example
    class C
    {
        /// <summary>
        /// Some requirements are imposed on the method targeted with this attribute:
        ///1. The method must be static.
        ///2. The method must be parameterless.
        ///3. The method must return void.
        ///3. The method must not be generic or be contained in a generic type.
        ///4. The method must be accessible from the containing module
        /// </summary>
        [ModuleInitializer]
        internal static void M1()
        {
            // ...
        }
    }

    //Benifits
    //1. Enable libraries to do eager, one-time initialization when loaded,
    //with minimal overhead and without the user needing to explicitly call anything
    //2. One particular pain point of current static constructor approaches is that
    //the runtime must do additional checks on usage of a type with a static constructor,
    //in order to decide whether the static constructor needs to be run or not.This adds measurable overhead.
    //3. Enable source generators to run some global initialization logic without the user needing to explicitly call anything.
}
