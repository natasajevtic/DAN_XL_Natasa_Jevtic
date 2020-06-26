using System;
using System.Threading;

namespace Zadatak_1
{
    /// <summary>
    /// This class simulates sending request to printer and document printing.
    /// </summary>
    class Printer
    {
        public static EventWaitHandle canPrintA3 = new AutoResetEvent(true);
        public static EventWaitHandle canPrintA4 = new AutoResetEvent(true);

        /// <summary>
        /// This method waits for a signal that the printer is done with printing one document and then sends a request for printing another document.
        /// </summary>
        /// <param name="document">Object of class Document.</param>
        /// <param name="computerName">Name of thread.</param>
        /// <remarks>
        /// The first request does not wait for a signal from printer, because AutoResetEvent is set to true.
        /// </remarks>
        public void SendingRequest(Document document, string computerName)
        {
            Thread.Sleep(200);
            if (document.Format == "A3")
            {
                Console.WriteLine("{0} sent request for printing document of {1} format. Color: {2}. Orientation: {3}.", computerName, document.Format, document.Color, document.Orientation);
                //waiting for signal that document can be printed
                canPrintA3.WaitOne();
                //creating and invoking thread for printing document
                Thread A3 = new Thread(() => PrintingDocument(document, computerName));
                A3.Start();
            }
            else if (document.Format == "A4")
            {
                Console.WriteLine("{0} sent request for printing document of {1} format. Color: {2}. Orientation: {3}.", computerName, document.Format, document.Color, document.Orientation);
                //waiting for signal that document can be printed
                canPrintA4.WaitOne();
                //creating and invoking thread for printing document
                Thread A4 = new Thread(() => PrintingDocument(document, computerName));
                A4.Start();
            }
        }
        public void PrintingDocument(Document document, string computerName) { }
    }
}
