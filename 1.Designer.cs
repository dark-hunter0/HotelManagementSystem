using System.Drawing;
using System.Windows.Forms;

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
            this.Choose_table = new System.Windows.Forms.ComboBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
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
            this.Choose_table.Location = new System.Drawing.Point(609, 43);
            this.Choose_table.Name = "Choose_table";
            this.Choose_table.Size = new System.Drawing.Size(216, 28);
            this.Choose_table.TabIndex = 0;
            this.Choose_table.Text = "Choose Table";
            this.Choose_table.SelectedIndexChanged += new System.EventHandler(this.Choose_table_SelectedIndexChanged);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(1317, 618);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(91, 42);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1205, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_button_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = global::HotelManagementSystem.Properties.Resources.home;
            this.homeButton.Location = new System.Drawing.Point(10, 10);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(93, 70);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.UseWaitCursor = true;
            // 
            // system_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Choose_table);
            this.Name = "system_management";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button homeButton;
        private Button button1;
    }

}
