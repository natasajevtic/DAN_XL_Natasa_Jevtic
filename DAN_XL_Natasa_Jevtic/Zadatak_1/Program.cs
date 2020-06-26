using System;
using System.IO;


namespace Zadatak_1
{
    /// <summary>
    /// This program simulates documents printing.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This methos writes available colors of documents to file.
        /// </summary>       
        static void WriteColorsToFile()
        {
            StreamWriter writer = new StreamWriter(@"../../Paleta.txt");
            string[] colors = { "blue", "red", "purple", "yellow", "pink", "green", "orange", "brown" };
            foreach (string color in colors)
            {
                writer.WriteLine(color);
            }
            writer.Close();
        }
        static void Main(string[] args)
        {
            //invoking method for writing colors to file
            WriteColorsToFile();
        }
    }
}
