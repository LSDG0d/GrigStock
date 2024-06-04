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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearchProviders.Text == string.Empty || textBoxSearchProviders.Text == null)
                {
                    dataGridViewProviders.DataSource = zxc.Providers.ToList();
                }
                else
                {
                    string searchWord = textBoxSearchProviders.Text;
                    dataGridViewProviders.DataSource = zxc.Providers.Where(x => x.ProviderContact.Contains(searchWord)
                    || x.ProviderMail.Contains(searchWord) || x.ProviderPhone.Contains(searchWord) || x.ProviderName.Contains(searchWord)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTypes.Text == string.Empty || textBoxTypes.Text == null)
                {
                    dataGridViewTypes.DataSource = zxc.Types.ToList();
                }
                else
                {
                    string searchWord = textBoxTypes.Text;
                    dataGridViewTypes.DataSource = zxc.Types.Where(x => x.TypeCategory.Contains(searchWord)
                    || x.TypeDescription.Contains(searchWord) || x.TypeCategory.Contains(searchWord) || x.TypeId.ToString().Contains(searchWord)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTovars.Text == string.Empty || textBoxTovars.Text == null)
                {
                    dataGridViewTovars.DataSource = zxc.Tovars.ToList();
                }
                else
                {
                    string searchWord = textBoxTovars.Text;
                    dataGridViewTovars.DataSource = zxc.Tovars.Where(x => x.TovarName.Contains(searchWord)
                    || x.TovarDescription.Contains(searchWord) || x.TovarCount.ToString().Contains(searchWord) || x.TovarCost.ToString().Contains(searchWord)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearchOrders_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxOrders.Text == string.Empty || textBoxOrders.Text == null)
                {
                    dataGridViewOrders.DataSource = zxc.Orders.ToList();
                }
                else
                {
                    string searchWord = textBoxOrders.Text;
                    dataGridViewOrders.DataSource = zxc.Orders.Where(x => x.ShippingDate.ToString().Contains(searchWord)
                    || x.RecipientAddress.ToString().Contains(searchWord) || x.Recipient.ToString().Contains(searchWord)
                    || x.PaymentDate.ToString().Contains(searchWord) || x.ClientId.ToString().Contains(searchWord)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmployee.Text == string.Empty || textBoxEmployee.Text == null)
                {
                    dataGridViewEmployees.DataSource = zxc.Employees.ToList();
                }
                else
                {
                    string searchWord = textBoxEmployee.Text;
                    dataGridViewEmployees.DataSource = zxc.Employees.Where(x => x.EmployeeAddress.ToString().Contains(searchWord)
                    || x.EmployeeBirthDay.ToString().Contains(searchWord) || x.EmployeeFirstName.ToString().Contains(searchWord)
                    || x.EmployeeId.ToString().Contains(searchWord) || x.EmployeeJobTitle.ToString().Contains(searchWord)
                    || x.EmployeeLastName.ToString().Contains(searchWord) || x.EmployeeMail.ToString().Contains(searchWord)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxClients.Text == string.Empty || textBoxClients.Text == null)
                {
                    dataGridViewClients.DataSource = zxc.Clients.ToList();
                }
                else
                {
                    string searchWord = textBoxClients.Text;
                    dataGridViewClients.DataSource = zxc.Clients.Where(x => x.ClientAddress.ToString().Contains(searchWord)
                    || x.ClientContact.ToString().Contains(searchWord) || x.ClientDescription.ToString().Contains(searchWord)
                    || x.ClientId.ToString().Contains(searchWord) || x.ClientMail.ToString().Contains(searchWord)
                    || x.ClientName.ToString().Contains(searchWord) || x.ClientPhone.ToString().Contains(searchWord)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OtchetForm otchetForm = new OtchetForm();
            otchetForm.Show();
        }
    }
}
