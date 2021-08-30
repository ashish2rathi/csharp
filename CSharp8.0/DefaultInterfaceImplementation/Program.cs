using System;

namespace DefaultInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1
            //var logger = new CustomLogger();
            //Logger logger = new CustomLogger();
            //logger.Log("Not found");
            //logger.Log(new Exception("Not found"));
            //Console.Read();
            #endregion

            #region Example2
            //var logger = new Logger();
            //Logger2 logger2 = new CustomLogger2();
            //logger2.Log("Not found");
            //logger2.Log(new Exception("Not found"));
            //Console.Read();
            #endregion
        }


        #region UsingStatement
        static void CreateTextFileClassicApproach()
        {
            using (var file = new System.IO.StreamWriter("Sample.txt"))
            {
                file.WriteLine("Hello world");
            }// file object is disposed of here
        }

        static void CreateTextFileModernApproach()
        {
            using var file2 = new System.IO.StreamWriter("Sample.txt");
            file2.WriteLine("Hello world");
            // file2 object is disposed of here
        }
        #endregion UsingStatement

    }
}
