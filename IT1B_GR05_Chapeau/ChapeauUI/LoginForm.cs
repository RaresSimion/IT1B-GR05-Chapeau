using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class LoginForm : Form
    {
        //permitted users:
        // Waiter. Username: 1. Password: 1234.
        // Bartender. Username: 2. Password: 2321.
        // Chef. Username: 3. Password: 4342.
        // Manager. Username: 4. Password: 6241. (Note: Our group doesn't have a manager as we have 4 memebers).

        private TableOverView tableView = new TableOverView();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "test" && textBoxPass.Text == "pass")
            {
                MessageBox.Show($"Welcome Back, Test!");
                this.Hide();
                tableView.Show();
            }

            //waiter, opens table view
            else if (textBoxUser.Text == "1" && textBoxPass.Text == "1234")
            {
                MessageBox.Show($"Welcome Back, Barry! Let's go take some orders.");
                this.Hide();
                tableView.Show();
            }

            //bartender, opens bar view
            else if (textBoxUser.Text == "2" && textBoxPass.Text == "2321")
            {
                MessageBox.Show($"Welcome Back, Alan! Let's go make some drinks.");
                this.Hide();
                tableView.Show();
            }
            //chef, opens kitchen view
            else if (textBoxUser.Text == "3" && textBoxPass.Text == "4342")
            {
                MessageBox.Show($"Welcome Back, Stefan! Let's go make some meals.");
                this.Hide();
                tableView.Show();
            }
            //manager, shows messagebox and clears username and password
            else if (textBoxUser.Text == "4" && textBoxPass.Text == "6241")
            {
                MessageBox.Show($"Uh oh! Right now, Chapeau doesn't have a manager." +
                    $"Maybe, come back later!");
                textBoxUser.Clear();
                textBoxPass.Clear();
                textBoxUser.Focus();
            }
            else
            {
                MessageBox.Show("Incorrect PIN or Password Entered. Try again.");
                textBoxUser.Clear();
                textBoxPass.Clear();
                textBoxUser.Focus();
            }
        }

        private void labelCLear_Click(object sender, EventArgs e)
        {
            textBoxUser.Clear();
            textBoxPass.Clear();
            textBoxUser.Focus();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
