using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BridgeDesignPatternDemo
{
    // ConcreteImplementor class
    public class DocumentReaderLoggger : IRegisterLog
    {
        public void LogReport(string LogMessage, int LogID)
        {
            Console.WriteLine("Document Reader Logger: \n Log Message: {0}; LogID: {1}", LogMessage, LogID);
        }
    }
}
