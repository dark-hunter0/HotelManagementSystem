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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExists));
            this.Choose_table = new System.Windows.Forms.ComboBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.View_Details = new System.Windows.Forms.Button();
            this.Please_input_primary_key_data = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(930, 610);
            this.Update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(91, 42);
            this.Update_button.TabIndex = 1;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // View_Details
            // 
            this.View_Details.BackColor = System.Drawing.Color.Turquoise;
            this.View_Details.Location = new System.Drawing.Point(829, 136);
            this.View_Details.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.View_Details.Name = "View_Details";
            this.View_Details.Size = new System.Drawing.Size(133, 42);
            this.View_Details.TabIndex = 3;
            this.View_Details.Text = "View Details";
            this.View_Details.UseVisualStyleBackColor = false;
            this.View_Details.Click += new System.EventHandler(this.View_Details_Click);
            // 
            // Please_input_primary_key_data
            // 
            this.Please_input_primary_key_data.AutoSize = true;
            this.Please_input_primary_key_data.Location = new System.Drawing.Point(220, 95);
            this.Please_input_primary_key_data.Name = "Please_input_primary_key_data";
            this.Please_input_primary_key_data.Size = new System.Drawing.Size(231, 20);
            this.Please_input_primary_key_data.TabIndex = 4;
            this.Please_input_primary_key_data.Text = "Please input primary key data🔑";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(24, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 86);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 682);
            this.Controls.Add(this.Please_input_primary_key_data);
            this.Controls.Add(this.View_Details);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Choose_table);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemExists";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button View_Details;
        private System.Windows.Forms.Label Please_input_primary_key_data;
        private System.Windows.Forms.Button button1;
    }
}