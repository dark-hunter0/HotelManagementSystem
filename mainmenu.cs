using System.Drawing;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
           
            SetupMenu();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Name = "MainMenu";
            this.ResumeLayout(false);

        }

        private void SetupMenu()
        {
            this.Text = "Hotel Management System";
            this.BackColor = Color.PaleTurquoise;
            this.Size = new Size(800, 600);

            var guestBtn = new Button
            {
                Text = "Guest Management",
                Size = new Size(200, 50),
                Location = new Point(300, 100),
                Font = new Font("Segoe UI", 12)
            };
            guestBtn.Click += (s, e) => { new Guest_Select().Show(); this.Hide(); };

            var roomsBtn = new Button
            {
                Text = "Room Booking",
                Size = new Size(200, 50),
                Location = new Point(300, 225),
                Font = new Font("Segoe UI", 12)
            };
            roomsBtn.Click += (s, e) => { new RoomSelectionForm().Show(); this.Hide(); };


            var mngBtn = new Button
            {
                Text = "System Management",
                Size = new Size(200, 50),
                Location = new Point(300, 350),
                Font = new Font("Segoe UI", 12)
            };
            mngBtn.Click += (s, e) => { new Form1().Show(); this.Hide(); };
            this.Controls.Add(guestBtn);
            this.Controls.Add(roomsBtn);
            this.Controls.Add(mngBtn);
        }

   
    }
}