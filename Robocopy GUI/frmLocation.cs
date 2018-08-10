using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robocopy_GUI
{
    public partial class frmLocation : Form
    {
        //Declare delagete callback function, the owner of communication
        public delegate void AddItemDelegate(string item);
        //Declare delagete callback function, the owner of communication
        public AddItemDelegate AddItemCallback;
        public frmLocation()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(txtlink.Text))
            {
                //Notification subscribers
                AddItemCallback(txtlink.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Location, please try again");
            }
            
        }
       
    }
}
