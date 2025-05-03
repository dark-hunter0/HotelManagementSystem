using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem
{
    public partial class Guest_Select : Form
    {
        public Guest_Select()
        {
            InitializeComponent();
            Guest_Info_Box.Visible = false;
            this.SuspendLayout();
            
            this.ClientSize = new System.Drawing.Size(1058, 716);
            this.Name = "Guest_Select";
            this.BackColor = Color.PaleTurquoise;
            this.ResumeLayout(false);

        }

        private void Confirm_NID_Click(object sender, EventArgs e)
        {
            List<string> nationalIds = new List<string>();

            using (SqlConnection conn = new SqlConnection(@"Database=HotelReservationSystem;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT National_ID FROM Guest";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nationalIds.Add(reader["National_ID"].ToString());
                    }
                }

                if (!string.IsNullOrWhiteSpace(Input_NID.Text) && nationalIds.Contains(Input_NID.Text))
                {
                    string guestQuery = "SELECT * FROM Guest WHERE National_ID = @nid";
                    using (SqlCommand cmd = new SqlCommand(guestQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nid", Input_NID.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                View_FN.Text = reader["first_Name"].ToString();
                                View_MI.Text = reader["mid_Init"].ToString();
                                View_LN.Text = reader["last_Name"].ToString();
                                View_Add.Text = reader["Guest_address"].ToString();
                                View_Email.Text = reader["Email"].ToString();
                                View_Phone_Num.Text = reader["phone_number"].ToString();
                                View_NID.Text = reader["National_ID"].ToString();
                            }
                        }
                    }

                    // Make controls visible
                    Guest_NID.Visible = true;
                    GuestAddress.Visible = true;
                    GuestEmail.Visible = true;
                    GuestLastName.Visible = true;
                    GuestMiddleinitial.Visible = true;
                    GuestPhoneNumber.Visible = true;
                    Guest_First_Name.Visible = true;
                    View_MI.Visible = true;
                    View_Add.Visible = true;
                    View_Email.Visible = true;
                    View_FN.Visible = true;
                    View_LN.Visible = true;
                    View_NID.Visible = true;
                    View_Phone_Num.Visible = true;
                    Guest_Info_Box.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please, enter a valid Guest's National ID");
                }

                conn.Close();
            }
        }


        private void Guest_Not_Registerd_Click(object sender, EventArgs e)
        {
            Add_Guest form2 = new Add_Guest();
            form2.Show();
            this.Hide();
        }

        //Delete user
        private void button1_Click(object sender, EventArgs e)
        {
          

            using (SqlConnection conn = new SqlConnection(@"Database=HotelReservationSystem;Integrated Security=True;"))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM Guest WHERE National_ID = @nid";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nid", View_NID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Guest deleted successfully.");
                    }
                    //Won't happen
                    else
                    {
                        MessageBox.Show("Guest not found.");
                    }
                }
                conn.Close();
            }
        }

        //update user
        private void Update_Guest_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection conn = new SqlConnection(@"Database=HotelReservationSystem;Integrated Security=True;"))
            {
                conn.Open();
                string updateQuery = @"UPDATE Guest
                               SET last_Name = @ln,
                                   Email = @em,
                                   Guest_address = @ad,
                                   Phone_Number = @ph
                               WHERE National_ID = @nid";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ln", View_LN.Text);
                    cmd.Parameters.AddWithValue("@em", View_Email.Text);
                    cmd.Parameters.AddWithValue("@ad", View_Add.Text);
                    cmd.Parameters.AddWithValue("@ph", View_Phone_Num.Text);
                    cmd.Parameters.AddWithValue("@nid", View_NID.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Guest information updated successfully.");
                    }
                    //Wont happened, handled previously
                    else
                    {
                        MessageBox.Show("Guest not found.");
                    }
                }
                conn.Close();
            }
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (MainMenu mainMenu = new MainMenu())
            {
                mainMenu.ShowDialog();
            }

            this.Close();
        }
    }
}