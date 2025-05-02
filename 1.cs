using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1147, 667);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: add any startup logic here
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
                    TextBox room_type_box = new TextBox
                    {
                        Name = "txtRoom_Type",
                        Location = new Point(200, 160),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
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
                    TextBox status_box = new TextBox
                    {
                        Name = "txtStatus",
                        Location = new Point(200, 220),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
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
                    TextBox role_box = new TextBox
                    {
                        Name = "txtRole",
                        Location = new Point(200, 130),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
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
                    TextBox status_staff_box = new TextBox
                    {
                        Name = "txtStatus",
                        Location = new Point(200, 190),
                        Size = new Size(200, 20),
                        Tag = "Dynamic"
                    };
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
            }
        }


           
        

        private void Add_button_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                
                
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    MessageBox.Show("Missing data 3eb kda");
                    return;
                }
                
                switch (Choose_table.SelectedItem.ToString())
                {
                    case "Hotel":

                        break;
                    case "Room":

                        break;
                    case "Staff":

                        break;

                    case "Department":

                        break;
                    case "Service":

                        break;
                }
            }



            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
