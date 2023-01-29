using MusteriTakip.Service.Interfaces.Abstract;
using MusteriTakip.Service.Services.Abstract;
using System.Windows.Forms;

namespace MusteriTakip.FormUI
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IClientService clientService;

        public MainForm()
        {
            InitializeComponent();

            clientService = new ClientService();
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            var clientList = await clientService.GetAll();
        }
    }
}
