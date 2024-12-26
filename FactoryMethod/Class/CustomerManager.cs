using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Class
{
    internal class CustomerManager
    {
        ILoggerFactory _loggerFactory;
        private LoggerFactory loggerFactory;

        public CustomerManager(LoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public ILogger Save()
        {
            //...
            Console.WriteLine("saved");
            ILogger logger = _loggerFactory.Createlogger();
            logger.Log();
            return logger;  
        }
    }
}
