using System.ServiceProcess;

namespace MusteriTakip.WinService
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public partial class ServiceEntry : ServiceBase
    {
        public ServiceEntry()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
