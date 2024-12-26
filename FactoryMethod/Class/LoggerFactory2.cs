using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Class
{
    internal class LoggerFactory2 : ILoggerFactory
    {
        public ILogger Createlogger()
        {
            //burda ek işlemler yapılabilir
            return new SnLogger();
        }
    }
}
