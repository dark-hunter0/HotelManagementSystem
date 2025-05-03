using System.Drawing;

namespace HotelManagementSystem
{
    partial class ItemExists
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox Choose_table;
        private System.Windows.Forms.Button Update_button;
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
            this.Choose_table = new System.Windows.Forms.ComboBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.View_Details = new System.Windows.Forms.Button();
            this.Please_input_primary_key_data = new System.Windows.Forms.Label();
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
            this.Choose_table.Location = new System.Drawing.Point(541, 34);
            this.Choose_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Choose_table.Name = "Choose_table";
            this.Choose_table.Size = new System.Drawing.Size(192, 24);
            this.Choose_table.TabIndex = 0;
            this.Choose_table.Text = "Choose Table";
            this.Choose_table.SelectedIndexChanged += new System.EventHandler(this.Choose_table_SelectedIndexChanged);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(827, 488);
            this.Update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(81, 34);
            this.Update_button.TabIndex = 1;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Home_button
            // 
            this.Home_button.BackColor = System.Drawing.Color.Transparent;
            this.Home_button.Location = new System.Drawing.Point(21, 23);
            this.Home_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(107, 69);
            this.Home_button.TabIndex = 2;
            this.Home_button.UseVisualStyleBackColor = false;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // View_Details
            // 
            this.View_Details.BackColor = System.Drawing.Color.Turquoise;
            this.View_Details.Location = new System.Drawing.Point(737, 109);
            this.View_Details.Name = "View_Details";
            this.View_Details.Size = new System.Drawing.Size(118, 34);
            this.View_Details.TabIndex = 3;
            this.View_Details.Text = "View Details";
            this.View_Details.UseVisualStyleBackColor = false;
            this.View_Details.Click += new System.EventHandler(this.View_Details_Click);
            // 
            // Please_input_primary_key_data
            // 
            this.Please_input_primary_key_data.AutoSize = true;
            this.Please_input_primary_key_data.Location = new System.Drawing.Point(196, 76);
            this.Please_input_primary_key_data.Name = "Please_input_primary_key_data";
            this.Please_input_primary_key_data.Size = new System.Drawing.Size(196, 16);
            this.Please_input_primary_key_data.TabIndex = 4;
            this.Please_input_primary_key_data.Text = "Please input primary key data🔑";
            // 
            // ItemExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 546);
            this.Controls.Add(this.Please_input_primary_key_data);
            this.Controls.Add(this.View_Details);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Choose_table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemExists";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Button View_Details;
        private System.Windows.Forms.Label Please_input_primary_key_data;
    }
}