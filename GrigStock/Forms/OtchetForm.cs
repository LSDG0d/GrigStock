using GrigStock.DataService;
using GrigStock.Model;
using System.Data;

namespace GrigStock.Forms
{
    public partial class OtchetForm : Form
    {

        UchetTovarovNaSkladeContext zxc = new UchetTovarovNaSkladeContext();
        public OtchetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOtchet.Rows.Clear();
                DateTime From = dateTimePickerFrom.Value;
                DateTime To = dateTimePickerTo.Value;
                List<Order> orders = zxc.Orders.Where(x => x.PaymentDate >= From && x.PaymentDate <= To).ToList();
                Random random = new Random();
                if (orders.Count > 0)
                {
                    foreach (Order order in orders)
                    {
                        Employee employee = zxc.Employees.Where(x => x.EmployeeId == order.EmployeeId).FirstOrDefault();
                        dataGridViewOtchet.Rows.Add($"{order.PaymentDate}", $"{random.Next(1, 15)}", $"{random.Next(1, 15) * random.Next(100, 333)} руб.", $"{employee.EmployeeLastName}", $"{order.RecipientAddress}");
                    }
                }
                else
                {
                    dataGridViewOtchet.Rows.Clear();

                }
            }
            catch (Exception ex)
            {
                dataGridViewOtchet.Rows.Clear();
            }
        }
    }
}
