using SampleInterface.Business.Common;
using SampleInterface.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface.Business.Helper
{
    public class LoggerHelper
    {
        private static ILogger logger;
        private static object lockObject = new object();


        public static ILogger GetLogger(Setting setting)
        {
            lock (lockObject)
            {
                if (logger == null)
                {
                    string assemblyName = setting.AssemblyName;
                    string className = setting.ClassName;

                    if (String.IsNullOrEmpty(assemblyName) || String.IsNullOrEmpty(className))
                    {
                        throw new ApplicationException("The assembly was not loaded");
                    }
                        

                    Assembly assembly = Assembly.LoadFrom(assemblyName);
                    logger = assembly.CreateInstance(className) as ILogger;

                    if (logger == null)
                    {
                        throw new ApplicationException(string.Format("Unable to Create class for assembly {0} with class name {1}", assemblyName, className));
                    }

                }
                return logger;
            }
        }
    }
}
