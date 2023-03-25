using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.BridgeDesignPatternDemo
{
    // 'Implementor' interface
    public interface IRegisterLog
    {
        void LogReport(string LogMessage, int LogID);
    }
}
