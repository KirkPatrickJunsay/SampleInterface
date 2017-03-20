using SampleInterface.Business.Common;
using SampleInterface.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling of the LoggerService and Passing the Setting
            LoggerService log = new LoggerService(new Setting() { AssemblyName = "MSLogLogger.dll", ClassName = "MSLogLogger.MSLog" });

            //Mocking WriteMessage instead of writing actual
            //logs will just display in the screen.
            log.WriteMessage("Hello World");

            Console.Read();
        }
    }
}
