using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class LoginForm : Form
    {
        //permitted users:
        // Waiter. Username: 1. Password: 1234.
        // Bartender. Username: 2. Password: 2321.
        // Chef. Username: 3. Password: 4342.
        // Manager. Username: 4. Password: 6241. (Note: Our group doesn't have a manager as we have 4 memebers).
        Employee user;
        EmployeeService employeeService;



        public LoginForm()
        {
            InitializeComponent();

            employeeService = new EmployeeService();

            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBoxPass.Text;

            if (password == "")
            {
                MessageBox.Show("Please enter your Password");
            }

            user = employeeService.GetEmployeeByPassword(password);

            if (user != null)
            {
                if (user.Employee_Role == EmployeeRole.Waiter)
                {
                    MessageBox.Show($"Welcome Back, {user.Employee_Name}! Let's go take some orders.");
                    this.Hide();
                    new TableOverView().Show();
                }
                else if (user.Employee_Role == EmployeeRole.Bartender)
                {
                    MessageBox.Show($"Welcome Back, {user.Employee_Name} Let's go make some drinks.");
                    this.Hide();
                    //updated when Matthias' form is added
                    //new BarView().Show();
                }
                else if (user.Employee_Role == EmployeeRole.Chef)
                {
                    MessageBox.Show($"Welcome Back, {user.Employee_Name} Let's go make some meals.");
                    this.Hide();
                    //updated when Matthias' form is added
                    //new KItchenView().Show();
                }
                else if (user.Employee_Role == EmployeeRole.Manager)
                {
                    MessageBox.Show($"Uh oh! Right now, Chapeau doesn't have a manager." +
                    $"Maybe, come back later!");
                    textBoxUser.Clear();
                    textBoxPass.Clear();
                    textBoxUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Incorrect PIN or Password Entered. Try again.");
                textBoxUser.Clear();
                textBoxPass.Clear();
                textBoxUser.Focus();
            }
        }


        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
