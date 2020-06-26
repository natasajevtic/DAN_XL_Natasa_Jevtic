using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadatak_1
{
    /// <summary>
    /// This class is responsible for creating thread for every computer.
    /// </summary>
    class Computer
    {
        public Document document { get; set; }

        public void Create()
        {
            Printer printer = new Printer();
            Thread[] threadsForComputers = new Thread[10];
            for (int i = 0; i < threadsForComputers.Length; i++)
            {
                threadsForComputers[i] = new Thread(() => printer.SendingRequest(document = new Document(), Thread.CurrentThread.Name))
                {
                    Name = string.Format("Computer_{0}", i + 1)
                };
                threadsForComputers[i].Start();
            }
        }
    }
}
