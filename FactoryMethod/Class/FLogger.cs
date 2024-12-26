using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Class
{
    internal class FLogger : ILogger
    {
        public void Log()
        {
            //ek işlemler
            Console.WriteLine("Logged with FLogger");
        }
    }
}
