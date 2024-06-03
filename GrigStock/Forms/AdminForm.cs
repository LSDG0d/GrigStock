using GrigStock.DataService;
using GrigStock.Model;
using GrigStock.Sercive;
using Microsoft.EntityFrameworkCore;
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
    public partial class AdminForm : Form
    {
        UchetTovarovNaSkladeContext zxc = new UchetTovarovNaSkladeContext();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = zxc.Users.ToList();
            dataGridViewClients.DataSource = zxc.Clients.ToList();
            dataGridViewEmployees.DataSource = zxc.Employees.ToList();
            dataGridViewOrders.DataSource = zxc.Orders.ToList();
            dataGridViewTovars.DataSource = zxc.Tovars.ToList();
            dataGridViewProviders.DataSource = zxc.Providers.ToList();
            dataGridViewTypes.DataSource = zxc.Types.ToList();
            comboBoxRole.SelectedIndex = 0;
            comboBoxProvider.DataSource = zxc.Providers.ToList();
            comboBoxProvider.DisplayMember = "ProviderName";
            comboBoxType.DataSource = zxc.Types.ToList();
            comboBoxType.DisplayMember = "TypeCategory";
            comboBoxOClients.DataSource = zxc.Clients.ToList();
            comboBoxOEmployees.DataSource = zxc.Employees.ToList();
            comboBoxOClients.DisplayMember = "ClientName";
            comboBoxOEmployees.DisplayMember = "EmployeeFirstName";
            //comboBoxProvider.SelectedIndex = 0;
        }

        private void dataGridViewUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != null && textBoxPassword.Text != null && comboBoxRole.Text != null)
            {
                User user = new User();
                user.UserPassword = textBoxPassword.Text;
                user.UserLogin = textBoxLogin.Text;
                user.UserRole = comboBoxRole.Text;
                if (AuthService.Registration(user)) MessageBox.Show("Успешно.");
                else MessageBox.Show("Ошибка");
                dataGridViewUser.DataSource = zxc.Users.ToList();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUser.SelectedRows.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewUser.SelectedRows)
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                    foreach (int id in ids)
                    {
                        zxc.Users.Where(x => x.UserId == id).ExecuteDelete();
                        zxc.SaveChanges();
                        dataGridViewUser.DataSource = zxc.Users.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Выделите строки");
                }

            }
            catch { }
        }
        #region cellsedit

        private void dataGridViewClients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }

        private void dataGridViewEmployees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }

        private void dataGridViewOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }

        private void dataGridViewTovars_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }

        private void dataGridViewTypes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }

        private void dataGridViewProviders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }

        private void dataGridViewPlaned_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            zxc.SaveChanges();
        }
        #endregion
        #region Deletes
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewClients.SelectedRows.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                    foreach (int id in ids)
                    {
                        zxc.Clients.Where(x => x.ClientId == id).ExecuteDelete();
                        zxc.SaveChanges();
                        dataGridViewClients.DataSource = zxc.Clients.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Выделите строки");
                }

            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEmployees.SelectedRows.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewEmployees.SelectedRows)
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                    foreach (int id in ids)
                    {
                        zxc.Employees.Where(x => x.EmployeeId == id).ExecuteDelete();
                        zxc.SaveChanges();
                        dataGridViewEmployees.DataSource = zxc.Employees.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Выделите строки");
                }

            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrders.SelectedRows.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewOrders.SelectedRows)
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                    foreach (int id in ids)
                    {
                        zxc.Orders.Where(x => x.OrderId == id).ExecuteDelete();
                        zxc.SaveChanges();
                        dataGridViewOrders.DataSource = zxc.Orders.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Выделите строки");
                }

            }
            catch { }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTovars.SelectedRows.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewTovars.SelectedRows)
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                    foreach (int id in ids)
                    {
                        zxc.Tovars.Where(x => x.TovarId == id).ExecuteDelete();
                        zxc.SaveChanges();
                        dataGridViewTovars.DataSource = zxc.Tovars.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Выделите строки");
                }

            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTypes.SelectedRows.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewTypes.SelectedRows)
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                    foreach (int id in ids)
                    {
                        zxc.Types.Where(x => x.TypeId == id).ExecuteDelete();
                        zxc.SaveChanges();
                        dataGridViewTypes.DataSource = zxc.Types.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Выделите строки");
                }
            }
            catch { }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProviders.SelectedRows.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewProviders.SelectedRows)
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                    foreach (int id in ids)
                    {
                        zxc.Providers.Where(x => x.ProviderId == id).ExecuteDelete();
                        zxc.SaveChanges();
                        dataGridViewProviders.DataSource = zxc.Providers.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Выделите строки");
                }
            }
            catch { }
        }
        #endregion

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBoxcategory.Text != null)
            {
                Model.Type type = new Model.Type();
                type.TypeCategory = textBoxcategory.Text;
                zxc.Types.Add(type);
                zxc.SaveChanges();
                dataGridViewTypes.DataSource = zxc.Types.ToList();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBoxprovider.Text != null)
            {
                Provider provider = new Provider();
                provider.ProviderName = textBoxprovider.Text;
                zxc.Providers.Add(provider);
                zxc.SaveChanges();
                dataGridViewProviders.DataContext = zxc.Providers.ToList();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxtovar.Text != null)
            {
                Tovar tovar = new Tovar();
                tovar.TovarCost = numericUpDown2.Value;
                tovar.TovarCount = numericUpDown1.Value.ToString();
                tovar.TovarName = textBoxtovar.Text;
                Provider provider = (Provider)comboBoxProvider.SelectedItem;
                tovar.ProviderId = provider.ProviderId;
                Model.Type type = (Model.Type)comboBoxType.SelectedItem;
                tovar.TypeId = type.TypeId;
                zxc.Tovars.Add(tovar);
                zxc.SaveChanges();
                dataGridViewTovars.DataSource = zxc.Tovars.ToList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxFname.Text != null && textBoxLname.Text != null && textBoxJTitle.Text != null)
            {
                Employee employee = new Employee();
                employee.EmployeeFirstName = textBoxFname.Text;
                employee.EmployeeLastName = textBoxLname.Text;
                employee.EmployeeBirthDay = dateTimePickerBirthday.Value;
                employee.EmployeeJobTitle = textBoxJTitle.Text;
                zxc.Employees.Add(employee);
                zxc.SaveChanges();
                dataGridViewEmployees.DataSource = zxc.Employees.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxCname.Text != null)
            {
                Client client = new Client();
                client.ClientName = textBoxCname.Text;
                zxc.Clients.Add(client);
                zxc.SaveChanges();
                dataGridViewClients.DataSource = zxc.Clients.ToList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxRecipient.Text != null && textBoxAdress.Text != null)
            {
                Order order = new Order();
                order.Recipient = textBoxRecipient.Text;
                order.RecipientAddress = textBoxAdress.Text;
                order.ClientId = ((Client)comboBoxOClients.SelectedItem).ClientId;
                order.EmployeeId = ((Employee)comboBoxOEmployees.SelectedItem).EmployeeId;
                zxc.Orders.Add(order);
                zxc.SaveChanges();
                dataGridViewOrders.DataSource = zxc.Orders.ToList();
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxPOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            AdminForm_Load(sender, EventArgs.Empty);
        }

        private void button20_Click(object sender, EventArgs e)
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

        private void button19_Click(object sender, EventArgs e)
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

        private void button17_Click(object sender, EventArgs e)
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

        private void button16_Click(object sender, EventArgs e)
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

        private void button15_Click(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
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

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsers.Text == string.Empty || textBoxUsers.Text == null)
                {
                    dataGridViewUser.DataSource = zxc.Users.ToList();
                }
                else
                {
                    string searchWord = textBoxUsers.Text;
                    dataGridViewUser.DataSource = zxc.Users.Where(x => x.UserPassword.ToString().Contains(searchWord)
                    || x.UserRole.ToString().Contains(searchWord) || x.UserLogin.ToString().Contains(searchWord)
                    || x.UserId.ToString().Contains(searchWord)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
