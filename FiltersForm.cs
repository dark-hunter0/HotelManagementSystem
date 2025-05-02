using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class FiltersForm : Form
    {
        public String room_types;
        public float minValue;
        public float maxValue;
        public String branch;
        public bool status;
        public FiltersForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
{
    // Validate that Min and Max are valid floats
    if (!string.IsNullOrWhiteSpace(minTextBox.Text) && !float.TryParse(minTextBox.Text, out _))
    {
        MessageBox.Show("Please enter a valid number for Minimum Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    if (!string.IsNullOrWhiteSpace(maxTextBox.Text) && !float.TryParse(maxTextBox.Text, out _))
    {
        MessageBox.Show("Please enter a valid number for Maximum Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

            room_types = roomTypeComboBox.Text;
            if (!String.IsNullOrWhiteSpace(minTextBox.Text))
                minValue = float.Parse(minTextBox.Text);
            else
                minValue = 0;
            if (!String.IsNullOrWhiteSpace(maxTextBox.Text))
                maxValue = float.Parse(maxTextBox.Text);
            else
                maxValue = 0;
            
            branch = branchComboBox.Text;
            status = statusCheckBox.Checked;
            // If everything is valid, close the form
            this.DialogResult = DialogResult.OK;
    this.Close();
}
    }
}

