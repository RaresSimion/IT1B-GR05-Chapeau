using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableOverView2
{
    public partial class TableOverView : Form
    {
        string messageOccupied = "This table is occupied. Would you like to view the order on this table?";
        string titleOccupied = "Occupied Table";
        string messageAvailable = "This table is available. Would you like to add an order to this table?";
        string titleAvailable = "Available Table";
        string messageReserved = "This table is reserved. Have the guests that reserved it arrived?";
        string titleReserved = "Reserved Table";

        MessageBoxButtons buttons = MessageBoxButtons.YesNo; 

        public TableOverView()
        {
            InitializeComponent();
        }

        private void TableOverView_Load(object sender, EventArgs e)
        {

        }

        private void labelTable1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageOccupied, titleOccupied, buttons);
            if (result == DialogResult.Yes)
            {
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageOccupied, titleOccupied, buttons);
            if (result == DialogResult.Yes)
            {
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageOccupied, titleOccupied, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageOccupied, titleOccupied, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageAvailable, titleAvailable, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageReserved, titleReserved, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void labelTable10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageReserved, titleReserved, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBoxTable10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(messageReserved, titleReserved, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                // new order open
            }
            else
            {
                this.Close();
            }
        }
    }
}
