using System.ServiceProcess;

namespace MusteriTakip.WinService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServiceEntry()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
