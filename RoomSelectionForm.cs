using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace HotelManagementSystem
{
    public partial class RoomSelectionForm : Form
    {
        private string connectionString = @"Database=HotelReservationSystem;Integrated Security=True;";

        public RoomSelectionForm()
        {
            this.BackColor = Color.PaleTurquoise;
            InitializeComponent();
        }

        private void RoomSelectionForm_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Clear existing data but preserve columns
                    roomDataGridView.DataSource = null;

                    // Get data from database s
                    string query = @"SELECT 
                                  Room_number AS [Room Number],
                                  Room_type AS [Room Type],
                                  room_floor AS Floor,
                                  room_status AS Status,
                                  STD_night_price AS [Night Price],
                                  Hotel_zip_code AS Hotel,
                                  Room_ID AS [Room ID]
                                  FROM Room";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Configure DataGridView
                    roomDataGridView.AutoGenerateColumns = false; // Prevent auto-generation

                    // Explicit column mapping - match DataPropertyName to database column aliases
                    roomDataGridView.Columns["dataGridViewTextBoxColumn1"].DataPropertyName = "Room Number";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn2"].DataPropertyName = "Room Type";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn3"].DataPropertyName = "Floor";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn4"].DataPropertyName = "Status";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn5"].DataPropertyName = "Night Price";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn6"].DataPropertyName = "Hotel";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn7"].DataPropertyName = "Room ID";

                    // Bind the data
                    roomDataGridView.DataSource = dt;
                    roomDataGridView.Refresh();
                    roomDataGridView.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roomDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            DataGridViewRow selectedRow = roomDataGridView.SelectedRows[0];

            // Safely get Room ID and Room Number with null checks
            if (selectedRow.Cells["dataGridViewTextBoxColumn7"]?.Value == null ||
                selectedRow.Cells["dataGridViewTextBoxColumn1"]?.Value == null)
            {
                MessageBox.Show("Selected room data is incomplete. Please select a different room.");
                return;
            }

            try
            {
                int roomId = Convert.ToInt32(selectedRow.Cells["dataGridViewTextBoxColumn7"].Value);

                string Status =Convert.ToString( selectedRow.Cells["dataGridViewTextBoxColumn4"].Value);
              
                string roomNumber = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();

                // Confirm with user
                string invStatus;
                if (Status == "Available")
                {
                    reservation_window reservation_Window = new reservation_window();
                    reservation_Window.Show();
                }
                else;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing room selection: {ex.Message}");
            }
        }

        private void UpdateRoomStatus(int roomId , string status, string invStatus)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    

                    // Updated query without the last_updated column
                    string updateQuery = @"UPDATE Room 
                                         SET room_status = @stat
                                         WHERE Room_ID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomId);

                        if (status == "Available")
                            { cmd.Parameters.AddWithValue("@stat", "Occupied"); }
                        else
                            cmd.Parameters.AddWithValue("@stat", "Available");
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Room {roomId} marked as {invStatus}");
                            LoadRoomData(); // Refresh the grid
                        }
                        else
                        {
                            MessageBox.Show("No room was updated. Please verify the room exists.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room status:\n{ex.Message}");
            }
        }

        private void filtersButton_Click(object sender, EventArgs e)
        {
            FiltersForm filtersForm = new FiltersForm();
            
            if (filtersForm.ShowDialog() == DialogResult.OK)
            {
                String room_types = filtersForm.room_types;
                float minValue = filtersForm.minValue;
                float maxValue = filtersForm.maxValue;
                String branch = filtersForm.branch;
                bool status = filtersForm.status;
                // Only run this after OK is pressed
                LoadFilteredData( room_types, minValue, maxValue, branch, status);
            }
        }
        private void LoadFilteredData(string room_types, float minValue, float maxValue, string branch, bool status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    roomDataGridView.DataSource = null;

                    // Base query
                    string query = @"SELECT 
                                Room_number AS [Room Number],
                                Room_type AS [Room Type],
                                room_floor AS Floor,
                                room_status AS Status,
                                STD_night_price AS [Night Price],
                                Hotel_zip_code AS Hotel,
                                Room_ID AS [Room ID]
                             FROM Room";

                    // Dynamic WHERE clause
                    List<string> conditions = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (!string.IsNullOrWhiteSpace(room_types))
                    {
                        conditions.Add("Room_type = @RT");
                        cmd.Parameters.AddWithValue("@RT", room_types);
                    }

                    if (minValue > 0)
                    {
                        conditions.Add("STD_night_price >= @Min");
                        cmd.Parameters.AddWithValue("@Min", minValue);
                    }

                    if (maxValue > 0 && maxValue >= minValue)
                    {
                        conditions.Add("STD_night_price <= @Max");
                        cmd.Parameters.AddWithValue("@Max", maxValue);
                    }

                    if (!string.IsNullOrWhiteSpace(branch))
                    {
                        conditions.Add("Hotel_zip_code = (select Zip_code \n from Hotel \n where City = @Branch)");
                        cmd.Parameters.AddWithValue("@Branch", branch);
                    }

                    // true = only show available rooms
                    if (status)
                    {
                        conditions.Add("room_status = 'Available'");
                    }

                    if (conditions.Count > 0)
                    {
                        query += " WHERE " + string.Join(" AND ", conditions);
                    }

                    cmd.CommandText = query;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    roomDataGridView.AutoGenerateColumns = false;
                    roomDataGridView.Columns["dataGridViewTextBoxColumn1"].DataPropertyName = "Room Number";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn2"].DataPropertyName = "Room Type";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn3"].DataPropertyName = "Floor";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn4"].DataPropertyName = "Status";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn5"].DataPropertyName = "Night Price";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn6"].DataPropertyName = "Hotel";
                    roomDataGridView.Columns["dataGridViewTextBoxColumn7"].DataPropertyName = "Room ID";

                    roomDataGridView.DataSource = dt;
                    roomDataGridView.Refresh();
                    roomDataGridView.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}