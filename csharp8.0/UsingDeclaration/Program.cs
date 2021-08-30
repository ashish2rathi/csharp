using System.IO;

namespace UsingDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTextFileClassicApproach();
            CreateTextFileModernApproach();
            MultipleFileStreamModernApproach();
        }

        static void CreateTextFileClassicApproach()
        {
            using (var file = new StreamWriter("Sample.txt"))
            {
                file.WriteLine("Hello world");
            }// file object is disposed of here
        }

        static void CreateTextFileModernApproach()
        {
            var fileName = "Sample.txt";
            if (fileName != null)
            {
                using var file2 = new StreamWriter("Sample.txt");
                file2.WriteLine("Hello world");
            }// file2 object is disposed of here
        }

        static void MultipleFileStreamModernApproach()
        {
            var fileName = "Sample.txt";
            if (fileName != null)
            {
                using var fileStream1 = new FileStream(fileName, FileMode.Open);
                using var fileStream2 = new FileStream(fileName, FileMode.Open);
                using var fileStream3 = new FileStream(fileName, FileMode.Open);

                //do something here

                //at the end it disposes the 'using' local variables in reverse order of its declaration.
                //dispose fileStream3
                //dispose fileStream2
                //dispose fileStream1
            }
        }
    }
}
