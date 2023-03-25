using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BridgeDesignPatternDemo
{
    // 'RefinedAbstraction' class
    public class ApplicationLog : Log
    {
        public override void LogAppMessgae()
        {
            _registerLog.LogReport(LogMessage, LogID);
        }
    }
}
