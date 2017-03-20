using SampleInterface.Business.Common;
using SampleInterface.Business.Helper;
using SampleInterface.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface.Business.Service
{
    public class LoggerService
    {
        ILogger logger;

        public LoggerService(Setting settings)
        {
            logger = LoggerHelper.GetLogger(settings);
        }

        public void WriteMessage(string param)
        {
            logger.WriteLogs(param);
        }
    }
}
