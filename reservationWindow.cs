using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class reservation_window : Form
    {
        string connStr = @"Database=HotelReservationSystem;Integrated Security=True;";
        int room_id;
        float Price;
        public reservation_window(int Room_id, float price)
        {
            InitializeComponent();
            this.room_id = Room_id;
            this.Price = price;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void branchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            
            if (!check_mandatory_fields())
            {
               
                return; 
            }


            
            string add_reservation = @"
    INSERT INTO Reservation (Guest_National_ID, First_Name, Booking_price, Checkin_date, Checkout_date, Manager_National_ID, Room_ID) /* Removed Reservation_ID */
    VALUES (@GNID, @Gname, @price, @ChinD, @ChoutD, @SNID, @roomID); /* Removed @ID */
    SELECT CAST(SCOPE_IDENTITY() AS INT);"; 

            string addPayment = @"
        INSERT INTO Payment (Ref_no, Payment_Method, Reservation_ID)
        VALUES (@ref, @pay, @reserve);";

            string addSideGuest = @"
        INSERT INTO Side_guest (Guest_National_ID, Side_Guest_Name, Relation)
        VALUES (@GNID, @Sname, @relation);";

            
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    string guestFirstName = null;
                    string queryGuestName = "SELECT First_name FROM Guest WHERE National_id = @GNID";
                    int newReservationId;

                    using (SqlCommand cmdGetGuestName = new SqlCommand(queryGuestName, connection, transaction))
                    {

                        cmdGetGuestName.Parameters.AddWithValue("@GNID", guest_NID.Text);

                        object resultName = cmdGetGuestName.ExecuteScalar();

                        if (resultName != null && resultName != DBNull.Value)
                        {
                            guestFirstName = resultName.ToString();
                        }
                        else
                        {

                            throw new Exception($"Guest with National ID '{guest_NID.Text}' not found in the Guest table. Cannot proceed with reservation.");

                        }
                    }

                    


                  
                    using (SqlCommand cmdReservation = new SqlCommand(add_reservation, connection, transaction))
                    {
                        //cmdReservation.Parameters.AddWithValue("@ID", regesteration_id);
                        cmdReservation.Parameters.AddWithValue("@GNID", guest_NID.Text);
                        cmdReservation.Parameters.AddWithValue("@Gname", guestFirstName);
                        cmdReservation.Parameters.AddWithValue("@price", Price);
                        cmdReservation.Parameters.AddWithValue("@ChinD", Checkin_date.SelectionStart);
                        cmdReservation.Parameters.AddWithValue("@ChoutD", Checkin_date.SelectionEnd);
                        cmdReservation.Parameters.AddWithValue("@SNID", manager_NID.Text);
                        cmdReservation.Parameters.AddWithValue("@roomID", room_id);


                        object result = cmdReservation.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            newReservationId = Convert.ToInt32(result); 
                        }
                        else
                        {
                            
                            throw new Exception("Failed to retrieve Reservation ID after insert (SCOPE_IDENTITY returned null).");
                        }
                        if (newReservationId <= 0) 
                        {
                            throw new Exception("Invalid Reservation ID generated by database.");
                        }

                        using (SqlCommand cmdPayment = new SqlCommand(addPayment, connection, transaction))
                        {

                            cmdPayment.Parameters.AddWithValue("@ref", ref_no.Text);
                            cmdPayment.Parameters.AddWithValue("@pay", payment_type.SelectedItem.ToString());
                            cmdPayment.Parameters.AddWithValue("@reserve", newReservationId);

                            int paymentRowsAffected = cmdPayment.ExecuteNonQuery();
                            if (paymentRowsAffected != 1)
                            {
                                throw new Exception("Failed to insert payment record.");
                            }
                        }


                        string mainGuestNID = guest_NID.Text;


                        if (!string.IsNullOrWhiteSpace(sideGuest1_name.Text) && !string.IsNullOrWhiteSpace(sideGuest1_relation.Text))
                        {
                            using (SqlCommand cmdSideGuest1 = new SqlCommand(addSideGuest, connection, transaction))
                            {
                                cmdSideGuest1.Parameters.AddWithValue("@GNID", mainGuestNID);
                                cmdSideGuest1.Parameters.AddWithValue("@Sname", sideGuest1_name.Text);
                                cmdSideGuest1.Parameters.AddWithValue("@relation", sideGuest1_relation.Text);

                                int sg1RowsAffected = cmdSideGuest1.ExecuteNonQuery();
                                if (sg1RowsAffected != 1)
                                {
                                    throw new Exception("Failed to insert side guest 1 record.");
                                }
                            }
                        }


                        if (!string.IsNullOrWhiteSpace(sideGuest2_name.Text) && !string.IsNullOrWhiteSpace(sideGuest2_relation.Text))
                        {
                            using (SqlCommand cmdSideGuest2 = new SqlCommand(addSideGuest, connection, transaction))
                            {
                                cmdSideGuest2.Parameters.AddWithValue("@GNID", mainGuestNID);
                                cmdSideGuest2.Parameters.AddWithValue("@Sname", sideGuest2_name.Text);
                                cmdSideGuest2.Parameters.AddWithValue("@relation", sideGuest2_relation.Text);

                                int sg1RowsAffected = cmdSideGuest2.ExecuteNonQuery();
                                if (sg1RowsAffected != 1)
                                {
                                    throw new Exception("Failed to insert side guest 1 record.");
                                }
                            }
                        }


                        transaction.Commit();

                        MessageBox.Show("Reservation confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
                catch (SqlException sqlEx)
                {

                    try { transaction?.Rollback(); } catch { }
                    MessageBox.Show($"Database error: {sqlEx.Message}\n\nOperation failed. No changes were saved.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    try { transaction?.Rollback(); } catch { }
                    MessageBox.Show($"An error occurred: {ex.Message}\n\nOperation failed. No changes were saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } 
        }
        private bool check_mandatory_fields()
        {
         
            if (String.IsNullOrWhiteSpace(this.guest_NID.Text) ||
                String.IsNullOrWhiteSpace(this.manager_NID.Text) ||
                this.payment_type.SelectedItem == null || // Checks if an item is selected
                String.IsNullOrWhiteSpace(this.ref_no.Text))
            {
                MessageBox.Show("Please ensure Guest NID, Manager NID, Payment Type, and Ref No are all filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            
            if (Checkin_date.SelectionStart.Date >= Checkin_date.SelectionEnd.Date)
            {
                MessageBox.Show("Check-out date must be after the Check-in date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            
            if (!int.TryParse(this.ref_no.Text, out int _)) 
            {
                MessageBox.Show("Reference number must be a valid whole number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            
            return true;
        }

        private void Checkin_date_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
