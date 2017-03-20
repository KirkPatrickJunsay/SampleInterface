using SampleInterface.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLogLogger
{
    public class MSLog : ILogger
    {
        public void WriteLogs(string param)
        {
            Console.WriteLine(string.Format("Displayed the message {0} - using MSLog",param));
        }
    }
}
