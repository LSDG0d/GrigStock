using GrigStock.Forms;
using GrigStock.Model;
using GrigStock.Sercive;

namespace GrigStock
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != null && textBoxLogin.Text != null)
            {
                User? user = AuthService.Authorize(textBoxLogin.Text, textBoxPassword.Text);
                if (user != null)
                {
                    switch (user.UserRole)
                    {
                        case "Admin":
                            this.Hide();
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            break;
                        case "Visitor":
                            this.Hide();
                            VisitorForm visitorForm = new VisitorForm();
                            visitorForm.Show();
                            break;
                        case "Employee":
                            this.Hide();
                            EmployeeForm empForm = new EmployeeForm();
                            empForm.Show();
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }
    }
}
