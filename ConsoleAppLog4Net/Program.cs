﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLog4Net
{
  class Program
  {
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    private static void Main(string[] args)
    {
      log.Info("This is my first logger example");
      Console.WriteLine("log");
      Console.ReadKey();
    }
  }
}
