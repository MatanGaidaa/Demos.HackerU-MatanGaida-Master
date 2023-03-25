using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BridgeDesignPatternDemo
{

    // 'Abstraction' abstract class
    public abstract class Log
    {
        public IRegisterLog _registerLog;
        public string LogMessage;
        public int LogID;
        public abstract void LogAppMessgae();
    }
}
