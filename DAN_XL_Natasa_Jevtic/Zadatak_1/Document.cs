using System;
using System.IO;
using System.Linq;

namespace Zadatak_1
{
    /// <summary>
    /// This class is responsible for creating new documents.
    /// </summary>
    class Document
    {
        public string Color { get; set; }
        public string Format { get; set; }
        public string Orientation { get; set; }
        string[] availableFormat = { "A3", "A4" };
        Random random = new Random();
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        /// <remarks>
        /// Setting properties of object on random values.
        /// </remarks>
        public Document()
        {
            //sets on random color from file
            Color = File.ReadLines(@"../../Paleta.txt").Skip(random.Next(0, 8)).Take(1).First();
            //sets on random element from array of format
            Format = availableFormat[random.Next(0, availableFormat.Length)];
            //based on random number sets the orientation
            int numberForOrientation = random.Next(0, 2);
            if (numberForOrientation == 0)
            {
                Orientation = "portrait";
            }
            else
            {
                Orientation = "landscape";
            }
        }
    }
}
