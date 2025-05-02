using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace HotelManagementSystem
{
    public partial class RoomSelectionForm : Form
    {
        private string connectionString = @"Database=HotelReservationSystem;Integrated Security=True;";

        public RoomSelectionForm()
        {
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

                    // Clear existing data but preserve your designed columns
                    roomDataGridView.DataSource = null;

                    // Get data from database using ACTUAL column names
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
                string roomNumber = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();

                // Confirm with user
                DialogResult result = MessageBox.Show($"Mark room {roomNumber} as occupied?",
                    "Confirm Occupation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateRoomStatus(roomId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing room selection: {ex.Message}");
            }
        }

        private void UpdateRoomStatus(int roomId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Updated query without the last_updated column
                    string updateQuery = @"UPDATE Room 
                                         SET room_status = 'Occupied'
                                         WHERE Room_ID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Room {roomId} marked as occupied");
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
            filtersForm.ShowDialog();

            // Optional: Refresh data after applying filters
            LoadRoomData();
        }
    }
}