using System.Drawing;

namespace HotelManagementSystem
{
    partial class system_management
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox Choose_table;
        private System.Windows.Forms.Button Add_button;
       // private System.Windows.Forms.Button Delete_button;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(system_management));
            this.Choose_table = new System.Windows.Forms.ComboBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.Item_Exists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Choose_table
            // 
            this.Choose_table.FormattingEnabled = true;
            this.Choose_table.Items.AddRange(new object[] {
            "Hotel",
            "Room",
            "Staff",
            "Department",
            "Service",
            "Review"});
            this.Choose_table.Location = new System.Drawing.Point(609, 42);
            this.Choose_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Choose_table.Name = "Choose_table";
            this.Choose_table.Size = new System.Drawing.Size(216, 28);
            this.Choose_table.TabIndex = 0;
            this.Choose_table.Text = "Choose Table";
            this.Choose_table.SelectedIndexChanged += new System.EventHandler(this.Choose_table_SelectedIndexChanged);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(930, 610);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(91, 42);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Home_button
            // 
            this.Home_button.BackColor = System.Drawing.Color.Transparent;
            this.Home_button.Image = ((System.Drawing.Image)(resources.GetObject("Home_button.Image")));
            this.Home_button.Location = new System.Drawing.Point(24, 29);
            this.Home_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(120, 86);
            this.Home_button.TabIndex = 2;
            this.Home_button.UseVisualStyleBackColor = false;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Item_Exists
            // 
            this.Item_Exists.BackColor = System.Drawing.Color.Turquoise;
            this.Item_Exists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Exists.Location = new System.Drawing.Point(654, 145);
            this.Item_Exists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Item_Exists.Name = "Item_Exists";
            this.Item_Exists.Size = new System.Drawing.Size(297, 42);
            this.Item_Exists.TabIndex = 3;
            this.Item_Exists.Text = "Item Already Exists ?";
            this.Item_Exists.UseVisualStyleBackColor = false;
            this.Item_Exists.Click += new System.EventHandler(this.View_Details_Click);
            // 
            // system_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 682);
            this.Controls.Add(this.Item_Exists);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Choose_table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "system_management";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Button Item_Exists;
    }
}
