using MusteriTakip.Common.Helpers;
using MusteriTakip.Common.Models.Abstract;
using System.Windows.Forms;

namespace MusteriTakip.FormUI
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            var clientList = await SqlHelper.Instance.GetItems<ClientItem>("select * from Clients");
        }
    }
}
