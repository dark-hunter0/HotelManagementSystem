using System;
using System.Windows.Forms;
using HotelManagementSystem;

namespace HotelManagementSystem
{
    public partial class Add_Guest : Form
    {
        public Add_Guest()
        {
            InitializeComponent();
        }

        private void Return_to_Guest_Selector_Click(object sender, EventArgs e)
        {
            Guest_Select form1 = new Guest_Select();
            form1.Show();
            this.Hide();
        }

        private void Confirm_New_Guest_Data_Click(object sender, EventArgs e)
        {
            if (check_fields()) {
                try
                {
                    int result = DatabaseHelper.AddGuest(
                        View_NID.Text,
                        View_FN.Text,
                        GuestMiddleinitial.Text, // Middle initial added here
                        View_LN.Text,
                        View_Email.Text,
                        View_Add.Text,
                        View_Phone_Num.Text);

                    if (result > 0)
                    {
                        MessageBox.Show("Guest added successfully!", "Success");
                        Guest_Select form1 = new Guest_Select();
                        form1.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Input, National ID already exists");
                } }
            else {
                MessageBox.Show("Please fill all Fields");
            }
        }
        private bool check_fields()
        {
            if(string.IsNullOrWhiteSpace(View_NID.Text) || string.IsNullOrWhiteSpace(View_FN.Text) 
                || string.IsNullOrWhiteSpace(View_LN.Text) || string.IsNullOrWhiteSpace(View_Email.Text)
                && string.IsNullOrWhiteSpace(View_Add.Text) || string.IsNullOrWhiteSpace(View_Phone_Num.Text))
                return false;

            return true;
        }
    }
}