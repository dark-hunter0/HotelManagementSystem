using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class system_management : Form
    {
        public system_management()
        {
            InitializeComponent();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1147, 667);
            this.Name = "Form1";
            this.BackColor = Color.PaleTurquoise;
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Choose_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear old dynamic fields
            var oldFields = this.Controls
                .OfType<Control>()
                .Where(c => c.Tag != null && c.Tag.ToString() == "Dynamic")
                .ToList();

            foreach (var control in oldFields)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }

            // Define fields based on selected table
            List<string> fields = new List<string>();
            switch (Choose_table.SelectedItem.ToString())
            {
                case "Hotel":
                    Label zip_code = new Label
                    {
                        Text = "Zip code",
                        Location = new Point(50, 100),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox zip_code_box = new TextBox
                    {
                        Name = "txtZip_code",
                        Location = new Point(200, 100),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(zip_code);
                    this.Controls.Add(zip_code_box);

                    Label city = new Label
                    {
                        Text = "City",
                        Location = new Point(50, 130),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox city_box = new TextBox
                    {
                        Name = "txtCity",
                        Location = new Point(200, 130),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(city);
                    this.Controls.Add(city_box);

                    Label country = new Label
                    {
                        Text = "Country",
                        Location = new Point(50, 160),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox country_box = new TextBox
                    {
                        Name = "txtCountry",
                        Location = new Point(200, 160),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(country);
                    this.Controls.Add(country_box);

                    Label state = new Label
                    {
                        Text = "State",
                        Location = new Point(50, 190),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox state_box = new TextBox
                    {
                        Name = "txtState",
                        Location = new Point(200, 190),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(state);
                    this.Controls.Add(state_box);

                    Label street_name = new Label
                    {
                        Text = "Street Name",
                        Location = new Point(50, 220),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox street_name_box = new TextBox
                    {
                        Name = "txtStreet_Name",
                        Location = new Point(200, 220),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(street_name);
                    this.Controls.Add(street_name_box);

                    Label room_count = new Label
                    {
                        Text = "Room Count",
                        Location = new Point(50, 250),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox room_count_box = new TextBox
                    {
                        Name = "txtRoom_Count",
                        Location = new Point(200, 250),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(room_count);
                    this.Controls.Add(room_count_box);

                    Label email = new Label
                    {
                        Text = "Email",
                        Location = new Point(50, 280),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox email_box = new TextBox
                    {
                        Name = "txtEmail",
                        Location = new Point(200, 280),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(email);
                    this.Controls.Add(email_box);
                    break;

                case "Room":
                    Label room_id = new Label
                    {
                        Text = "Room ID",
                        Location = new Point(50, 100),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox room_id_box = new TextBox
                    {
                        Name = "txtRoom_ID",
                        Location = new Point(200, 100),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(room_id);
                    this.Controls.Add(room_id_box);

                    Label room_number = new Label
                    {
                        Text = "Room Number",
                        Location = new Point(50, 130),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox room_number_box = new TextBox
                    {
                        Name = "txtRoom_Number",
                        Location = new Point(200, 130),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(room_number);
                    this.Controls.Add(room_number_box);

                    Label room_type = new Label
                    {
                        Text = "Room Type",
                        Location = new Point(50, 160),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    ComboBox room_type_box = new ComboBox
                    {
                        Name = "txtRoom_Type",
                        Location = new Point(200, 160),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    room_type_box.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite"});
                    room_type_box.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.Controls.Add(room_type);
                    this.Controls.Add(room_type_box);

                    Label floor = new Label
                    {
                        Text = "Floor",
                        Location = new Point(50, 190),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox floor_box = new TextBox
                    {
                        Name = "txtFloor",
                        Location = new Point(200, 190),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };

                    this.Controls.Add(floor);
                    this.Controls.Add(floor_box);

                    Label status = new Label
                    {
                        Text = "Status",
                        Location = new Point(50, 220),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    
                    ComboBox status_box = new ComboBox
                    {
                        Name = "txtstatus_box",
                        Location = new Point(200, 220),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    status_box.Items.AddRange(new object[] { "Available", "Occupied", "Maintenance" });
                    status_box.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.Controls.Add(status);
                    this.Controls.Add(status_box);

                    Label std_price = new Label
                    {
                        Text = "STD Night Price",
                        Location = new Point(50, 250),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox std_price_box = new TextBox
                    {
                        Name = "txtSTD_Night_Price",
                        Location = new Point(200, 250),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(std_price);
                    this.Controls.Add(std_price_box);

                    Label hotel_zip = new Label
                    {
                        Text = "Hotel ZIP Code",
                        Location = new Point(50, 280),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox hotel_zip_box = new TextBox
                    {
                        Name = "txtHotel_ZIP_Code",
                        Location = new Point(200, 280),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(hotel_zip);
                    this.Controls.Add(hotel_zip_box);
                    break;

                case "Staff":
                    Label national_id = new Label
                    {
                        Text = "National ID",
                        Location = new Point(50, 100),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox national_id_box = new TextBox
                    {
                        Name = "txtNational_ID",
                        Location = new Point(200, 100),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(national_id);
                    this.Controls.Add(national_id_box);

                    Label role = new Label
                    {
                        Text = "Role",
                        Location = new Point(50, 130),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    ComboBox role_box = new ComboBox
                    {
                        Name = "txtrole_box",
                        Location = new Point(200, 130),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    role_box.Items.AddRange(new object[] { "Manager", "Cleaner", "Technician" , "Chef" , "Supervisor", "Server"});
                    role_box.DropDownStyle = ComboBoxStyle.DropDownList;


                    this.Controls.Add(role);
                    this.Controls.Add(role_box);

                    Label first_name = new Label
                    {
                        Text = "First Name",
                        Location = new Point(50, 160),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox first_name_box = new TextBox
                    {
                        Name = "txtFirst_Name",
                        Location = new Point(200, 160),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(first_name);
                    this.Controls.Add(first_name_box);

                    Label status_staff = new Label
                    {
                        Text = "Status",
                        Location = new Point(50, 190),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    ComboBox status_staff_box = new ComboBox
                    {
                        Name = "txtstatus_box",
                        Location = new Point(200, 190),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    status_staff_box.Items.AddRange(new object[] { "Active", "Inactive", "On Leave" });
                    status_staff_box.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.Controls.Add(status_staff);
                    this.Controls.Add(status_staff_box);

                    Label mid_init = new Label
                    {
                        Text = "Mid Init",
                        Location = new Point(50, 220),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox mid_init_box = new TextBox
                    {
                        Name = "txtMid_Init",
                        Location = new Point(200, 220),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(mid_init);
                    this.Controls.Add(mid_init_box);

                    Label last_name = new Label
                    {
                        Text = "Last Name",
                        Location = new Point(50, 250),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox last_name_box = new TextBox
                    {
                        Name = "txtLast_Name",
                        Location = new Point(200, 250),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(last_name);
                    this.Controls.Add(last_name_box);

                    Label salary = new Label
                    {
                        Text = "Salary",
                        Location = new Point(50, 280),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox salary_box = new TextBox
                    {
                        Name = "txtSalary",
                        Location = new Point(200, 280),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(salary);
                    this.Controls.Add(salary_box);

                    Label supervisor_id = new Label
                    {
                        Text = "Supervisor ID",
                        Location = new Point(50, 310),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox supervisor_id_box = new TextBox
                    {
                        Name = "txtSupervisor_national_id",
                        Location = new Point(200, 310),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(supervisor_id);
                    this.Controls.Add(supervisor_id_box);

                    Label department_id = new Label
                    {
                        Text = "Department ID",
                        Location = new Point(50, 340),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox department_id_box = new TextBox
                    {
                        Name = "txtDepartment_ID",
                        Location = new Point(200, 340),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(department_id);
                    this.Controls.Add(department_id_box);
                    break;

                case "Department":
                    Label dept_id = new Label
                    {
                        Text = "Department ID",
                        Location = new Point(50, 100),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox dept_id_box = new TextBox
                    {
                        Name = "txtDepartment_ID",
                        Location = new Point(200, 100),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(dept_id);
                    this.Controls.Add(dept_id_box);

                    Label dept_name = new Label
                    {
                        Text = "Department Name",
                        Location = new Point(50, 130),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox dept_name_box = new TextBox
                    {
                        Name = "txtDepartment_Name",
                        Location = new Point(200, 130),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(dept_name);
                    this.Controls.Add(dept_name_box);

                    Label hotel_zip_dep = new Label
                    {
                        Text = "Hotel ZIP Code",
                        Location = new Point(50, 160),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox hotel_zip_dep_box = new TextBox
                    {
                        Name = "txtHotel_ZIP_Code",
                        Location = new Point(200, 160),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(hotel_zip_dep);
                    this.Controls.Add(hotel_zip_dep_box);
                    break;

                case "Service":
                    Label service_id = new Label
                    {
                        Text = "Service ID",
                        Location = new Point(50, 100),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox service_id_box = new TextBox
                    {
                        Name = "txtService_ID",
                        Location = new Point(200, 100),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(service_id);
                    this.Controls.Add(service_id_box);

                    Label service_name = new Label
                    {
                        Text = "Service Name",
                        Location = new Point(50, 130),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox service_name_box = new TextBox
                    {
                        Name = "txtService_Name",
                        Location = new Point(200, 130),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(service_name);
                    this.Controls.Add(service_name_box);

                    Label price = new Label
                    {
                        Text = "Price",
                        Location = new Point(50, 160),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox price_box = new TextBox
                    {
                        Name = "txtPrice",
                        Location = new Point(200, 160),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(price);
                    this.Controls.Add(price_box);

                    Label guest_id = new Label
                    {
                        Text = "Guest National ID",
                        Location = new Point(50, 190),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox guest_id_box = new TextBox
                    {
                        Name = "txtGuest_National_ID",
                        Location = new Point(200, 190),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(guest_id);
                    this.Controls.Add(guest_id_box);
                    break;

                case ("Review"):

                    Label Guest_National_ID = new Label
                    {
                        Text = "Guest's National ID",
                        Location = new Point(50, 100),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox Guest_National_ID_box = new TextBox
                    {
                        Name = "txtGuest_National_ID",
                        Location = new Point(200, 100),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(Guest_National_ID);
                    this.Controls.Add(Guest_National_ID_box);

                    Label Hotel_ZIP_Code = new Label
                    {
                        Text = "Hotel ZIP Code",
                        Location = new Point(50, 130),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox Hotel_ZIP_Code_box = new TextBox
                    {
                        Name = "txtHotel_ZIP_Code",
                        Location = new Point(200, 130),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(Hotel_ZIP_Code);
                    this.Controls.Add(Hotel_ZIP_Code_box);

                    Label Rating = new Label
                    {
                        Text = "Rating",
                        Location = new Point(50, 160),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TrackBar Rating_slider = new TrackBar
                    {
                        Name = "sliderRating",
                        Location = new Point(200, 160),
                        Size = new Size(200, 45),
                        Minimum = 1,
                        Maximum = 5,
                        TickFrequency = 1,
                        SmallChange = 1,
                        LargeChange = 1,
                        Value = 3, 
                        Tag = "Dynamic"
                    };

                    this.Controls.Add(Rating);
                    this.Controls.Add(Rating_slider);
                    Label Comment = new Label
                    {
                        Text = "Comment",
                        Location = new Point(50, 250),
                        Size = new Size(120, 20),
                        Tag = "Dynamic"
                    };
                    TextBox Comment_box = new TextBox
                    {
                        Name = "txtComment_box",
                        Location = new Point(200, 250),
                        Size = new Size(200, 200),
                        Tag = "Dynamic"
                    };
                    this.Controls.Add(Comment);
                    this.Controls.Add(Comment_box);

                    break;
                    
            }
        }





        private void Add_button_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    MessageBox.Show("Missing data");
                    return;
                }
            }

            string connStr = @"Database=HotelReservationSystem;Integrated Security=True;"; 

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                switch (Choose_table.SelectedItem.ToString())
                {
                    case "Hotel":
                        cmd.CommandText = @"INSERT INTO Hotel (Zip_code, City, Country, Hotel_state, Street_Name, Room_Count, Email)
                                    VALUES (@Zip, @City, @Country, @State, @Street, @Rooms, @Email)";
                        cmd.Parameters.AddWithValue("@Zip", Controls["txtZip_code"].Text);
                        cmd.Parameters.AddWithValue("@City", Controls["txtCity"].Text);
                        cmd.Parameters.AddWithValue("@Country", Controls["txtCountry"].Text);
                        cmd.Parameters.AddWithValue("@State", Controls["txtState"].Text);
                        cmd.Parameters.AddWithValue("@Street", Controls["txtStreet_Name"].Text);
                        cmd.Parameters.AddWithValue("@Rooms", Controls["txtRoom_Count"].Text);
                        cmd.Parameters.AddWithValue("@Email", Controls["txtEmail"].Text);
                        break;

                    case "Room":
                        cmd.CommandText = @"INSERT INTO Room (Room_ID, Room_Number, Room_Type, room_Floor, room_Status, STD_Night_Price, Hotel_ZIP_Code)
                                    VALUES (@ID, @Number, @Type, @Floor, @Status, @Price, @HotelZip)";
                        cmd.Parameters.AddWithValue("@ID", Controls["txtRoom_ID"].Text);
                        cmd.Parameters.AddWithValue("@Number", Controls["txtRoom_Number"].Text);
                        cmd.Parameters.AddWithValue("@Type", Controls["txtRoom_Type"].Text);
                        cmd.Parameters.AddWithValue("@Floor", Controls["txtFloor"].Text);
                        cmd.Parameters.AddWithValue("@Status", Controls["txtStatus"].Text);
                        cmd.Parameters.AddWithValue("@Price", Controls["txtSTD_Night_Price"].Text);
                        cmd.Parameters.AddWithValue("@HotelZip", Controls["txtHotel_ZIP_Code"].Text);
                        break;

                    case "Staff":
                        cmd.CommandText = @"INSERT INTO Staff (National_ID, Staff_Role, First_Name, staff_Status, Mid_Init, Last_Name, Salary, Supervisor_national_id, Department_ID)
                                    VALUES (@NID, @Role, @FName, @Status, @Mid, @LName, @Salary, @SupervisorID, @DeptID)";
                        cmd.Parameters.AddWithValue("@NID", Controls["txtNational_ID"].Text);
                        cmd.Parameters.AddWithValue("@Role", Controls["txtRole"].Text);
                        cmd.Parameters.AddWithValue("@FName", Controls["txtFirst_Name"].Text);
                        cmd.Parameters.AddWithValue("@Status", Controls["txtStatus"].Text);
                        cmd.Parameters.AddWithValue("@Mid", Controls["txtMid_Init"].Text);
                        cmd.Parameters.AddWithValue("@LName", Controls["txtLast_Name"].Text);
                        cmd.Parameters.AddWithValue("@Salary", Controls["txtSalary"].Text);
                        cmd.Parameters.AddWithValue("@SupervisorID", Controls["txtSupervisor_national_id"].Text);
                        cmd.Parameters.AddWithValue("@DeptID", Controls["txtDepartment_ID"].Text);
                        break;

                    case "Department":
                        cmd.CommandText = @"INSERT INTO Department (Department_ID, Department_Name, Hotel_ZIP_Code)
                                    VALUES (@DeptID, @DeptName, @HotelZip)";
                        cmd.Parameters.AddWithValue("@DeptID", Controls["txtDepartment_ID"].Text);
                        cmd.Parameters.AddWithValue("@DeptName", Controls["txtDepartment_Name"].Text);
                        cmd.Parameters.AddWithValue("@HotelZip", Controls["txtHotel_ZIP_Code"].Text);
                        break;

                    case "Service":
                        cmd.CommandText = @"INSERT INTO Service (Service_ID, ServiceName, Price, Guest_National_ID)
                                    VALUES (@SID, @SName, @Price, @GuestID)";
                        cmd.Parameters.AddWithValue("@SID", Controls["txtService_ID"].Text);
                        cmd.Parameters.AddWithValue("@SName", Controls["txtService_Name"].Text);
                        cmd.Parameters.AddWithValue("@Price", Controls["txtPrice"].Text);
                        cmd.Parameters.AddWithValue("@GuestID", Controls["txtGuest_National_ID"].Text);
                        break;

                    case "Review":
                        cmd.CommandText = @"INSERT INTO Review (Guest_National_ID, Hotel_ZIP_Code, Rating, Comment)
                                    VALUES (@SID, @SName, @Price, @GuestID)";
                        cmd.Parameters.AddWithValue("@SID", Controls["txtGuest_National_ID"].Text);
                        cmd.Parameters.AddWithValue("@SName", Controls["txtHotel_ZIP_Code"].Text);
                        cmd.Parameters.AddWithValue("@Price",  ((TrackBar)Controls["sliderRating"]).Value);
                        cmd.Parameters.AddWithValue("@GuestID", Controls["txtComment_box"].Text);
                        break;
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




    }
}
