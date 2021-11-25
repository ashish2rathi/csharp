using System;

namespace PartialMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            var c = new C();
            c.M("Test");
            Console.ReadLine();

            //Example 2
            var d = new D();
            d.Example();
            Console.ReadLine();
        }
    }

    #region Example1

    partial class C
    {
        // The declaration of C.M
        public partial void M(string message);
    }

    partial class C
    {
        // The definition of C.M
        public partial void M(string message) => Console.WriteLine(message);
    }

    #endregion Example1

    #region Example2
    partial class D
    {
        partial void M(string message);

        public void Example()
        {
            M(GetIt()); // Call to M and GetIt erased at compile time
        }

        string GetIt() => "Hello World";
    }
    #endregion Example2

    #region Example2

    partial class E
    {
        // Okay because no definition is required here
        partial void M1();

        // Okay because M2 has a definition
        private partial void M2();

        // Error: partial method M3 must have a definition, becase it's private
        //private partial void M3();
    }

    partial class E
    {
        private partial void M2() { }
    }

    #endregion Example2
}