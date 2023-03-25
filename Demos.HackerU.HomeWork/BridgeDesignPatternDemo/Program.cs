using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BridgeDesignPatternDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log log = new ApplicationLog();
            log.LogMessage = "This is log message";
            log.LogID = 111;

            log._registerLog = new MediaPlayerLogger();
            log.LogAppMessgae();

            Log logger = new ApplicationLog();
            logger.LogMessage = "roei atar the king";
            logger.LogID = 1;

            logger._registerLog = new DocumentReaderLoggger();
            logger.LogAppMessgae();


            log._registerLog = new DocumentReaderLoggger();
            log.LogAppMessgae();

            log._registerLog = new BrowserLogger();
            log.LogAppMessgae();

            Console.ReadLine();

        }
    }
}
