using System;
using System.IO;

namespace FileRead
{
    public class FileRead
    {
        public static void Main()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("mytest.txt"))
                {
                    // Read and then output the first line from the text file
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
