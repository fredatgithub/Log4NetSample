using System;

namespace ConsoleAppLog4Net
{
  class Program
  {
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    private static void Main(string[] args)
    {
      log.Info("This is my first logger example");
      log.Info("log info");
      log.Fatal("log fatal");
      Console.WriteLine("log");
      //Console.ReadKey();
    }
  }
}
