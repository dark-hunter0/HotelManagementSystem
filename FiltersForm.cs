using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class FiltersForm : Form
    {
        public FiltersForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // You can retrieve and use the values here if needed.
            this.Close();
        }
    }
}

