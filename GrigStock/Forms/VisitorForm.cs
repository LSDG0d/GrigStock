using GrigStock.DataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrigStock.Forms
{
    public partial class VisitorForm : Form
    {
        public VisitorForm()
        {
            InitializeComponent();
        }

        UchetTovarovNaSkladeContext zxc = new UchetTovarovNaSkladeContext();
        private void VisitorForm_Load(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = zxc.Clients.ToList();
            dataGridViewEmployees.DataSource = zxc.Employees.ToList();
            dataGridViewOrders.DataSource = zxc.Orders.ToList();
            dataGridViewTovars.DataSource = zxc.Tovars.ToList();
            dataGridViewProviders.DataSource = zxc.Providers.ToList();
            dataGridViewTypes.DataSource = zxc.Types.ToList();
        }
    }
}
