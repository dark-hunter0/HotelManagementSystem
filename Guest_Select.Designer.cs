using System.Drawing;

namespace HotelManagementSystem
{
    partial class Guest_Select
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_Select));
            this.Guest_NID_Text = new System.Windows.Forms.TextBox();
            this.Input_NID = new System.Windows.Forms.TextBox();
            this.Confirm_NID = new System.Windows.Forms.Button();
            this.Guest_Not_Registerd = new System.Windows.Forms.Label();
            this.View_NID = new System.Windows.Forms.TextBox();
            this.Guest_NID = new System.Windows.Forms.TextBox();
            this.View_FN = new System.Windows.Forms.TextBox();
            this.Guest_First_Name = new System.Windows.Forms.TextBox();
            this.View_MI = new System.Windows.Forms.TextBox();
            this.GuestMiddleinitial = new System.Windows.Forms.TextBox();
            this.View_LN = new System.Windows.Forms.TextBox();
            this.View_Email = new System.Windows.Forms.TextBox();
            this.View_Add = new System.Windows.Forms.TextBox();
            this.View_Phone_Num = new System.Windows.Forms.TextBox();
            this.GuestLastName = new System.Windows.Forms.TextBox();
            this.GuestEmail = new System.Windows.Forms.TextBox();
            this.GuestAddress = new System.Windows.Forms.TextBox();
            this.GuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.Guest_Info_Box = new System.Windows.Forms.GroupBox();
            this.Delete_Guest = new System.Windows.Forms.Button();
            this.Update_Guest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guest_NID_Text
            // 
            this.Guest_NID_Text.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Guest_NID_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest_NID_Text.Location = new System.Drawing.Point(33, 25);
            this.Guest_NID_Text.Multiline = true;
            this.Guest_NID_Text.Name = "Guest_NID_Text";
            this.Guest_NID_Text.Size = new System.Drawing.Size(249, 33);
            this.Guest_NID_Text.TabIndex = 0;
            this.Guest_NID_Text.Text = "Enter Guest\'s National ID ";
            // 
            // Input_NID
            // 
            this.Input_NID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_NID.Location = new System.Drawing.Point(303, 29);
            this.Input_NID.Name = "Input_NID";
            this.Input_NID.Size = new System.Drawing.Size(194, 27);
            this.Input_NID.TabIndex = 1;
            // 
            // Confirm_NID
            // 
            this.Confirm_NID.Location = new System.Drawing.Point(555, 29);
            this.Confirm_NID.Name = "Confirm_NID";
            this.Confirm_NID.Size = new System.Drawing.Size(90, 30);
            this.Confirm_NID.TabIndex = 2;
            this.Confirm_NID.Text = "Confirm";
            this.Confirm_NID.UseVisualStyleBackColor = true;
            this.Confirm_NID.Click += new System.EventHandler(this.Confirm_NID_Click);
            // 
            // Guest_Not_Registerd
            // 
            this.Guest_Not_Registerd.AutoSize = true;
            this.Guest_Not_Registerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest_Not_Registerd.Location = new System.Drawing.Point(453, 80);
            this.Guest_Not_Registerd.Name = "Guest_Not_Registerd";
            this.Guest_Not_Registerd.Size = new System.Drawing.Size(251, 20);
            this.Guest_Not_Registerd.TabIndex = 3;
            this.Guest_Not_Registerd.Text = "Guest not registerd ? Add Guest";
            this.Guest_Not_Registerd.Click += new System.EventHandler(this.Guest_Not_Registerd_Click);
            // 
            // View_NID
            // 
            this.View_NID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_NID.Location = new System.Drawing.Point(379, 133);
            this.View_NID.Name = "View_NID";
            this.View_NID.ReadOnly = true;
            this.View_NID.Size = new System.Drawing.Size(194, 27);
            this.View_NID.TabIndex = 5;
            this.View_NID.Visible = false;
            // 
            // Guest_NID
            // 
            this.Guest_NID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Guest_NID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest_NID.Location = new System.Drawing.Point(112, 129);
            this.Guest_NID.Multiline = true;
            this.Guest_NID.Name = "Guest_NID";
            this.Guest_NID.ReadOnly = true;
            this.Guest_NID.Size = new System.Drawing.Size(235, 33);
            this.Guest_NID.TabIndex = 4;
            this.Guest_NID.Text = "Guest\'s National ID ";
            this.Guest_NID.Visible = false;
            // 
            // View_FN
            // 
            this.View_FN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_FN.Location = new System.Drawing.Point(379, 191);
            this.View_FN.Name = "View_FN";
            this.View_FN.ReadOnly = true;
            this.View_FN.Size = new System.Drawing.Size(194, 27);
            this.View_FN.TabIndex = 8;
            this.View_FN.Visible = false;
            // 
            // Guest_First_Name
            // 
            this.Guest_First_Name.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Guest_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest_First_Name.Location = new System.Drawing.Point(112, 187);
            this.Guest_First_Name.Multiline = true;
            this.Guest_First_Name.Name = "Guest_First_Name";
            this.Guest_First_Name.ReadOnly = true;
            this.Guest_First_Name.Size = new System.Drawing.Size(235, 33);
            this.Guest_First_Name.TabIndex = 7;
            this.Guest_First_Name.Text = "Guest\'s First Name ";
            this.Guest_First_Name.Visible = false;
            // 
            // View_MI
            // 
            this.View_MI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_MI.Location = new System.Drawing.Point(379, 242);
            this.View_MI.Name = "View_MI";
            this.View_MI.ReadOnly = true;
            this.View_MI.Size = new System.Drawing.Size(194, 27);
            this.View_MI.TabIndex = 11;
            this.View_MI.Visible = false;
            // 
            // GuestMiddleinitial
            // 
            this.GuestMiddleinitial.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GuestMiddleinitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestMiddleinitial.Location = new System.Drawing.Point(112, 238);
            this.GuestMiddleinitial.Multiline = true;
            this.GuestMiddleinitial.Name = "GuestMiddleinitial";
            this.GuestMiddleinitial.ReadOnly = true;
            this.GuestMiddleinitial.Size = new System.Drawing.Size(235, 33);
            this.GuestMiddleinitial.TabIndex = 10;
            this.GuestMiddleinitial.Text = "Guest\'s Middle initial";
            this.GuestMiddleinitial.Visible = false;
            // 
            // View_LN
            // 
            this.View_LN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_LN.Location = new System.Drawing.Point(379, 299);
            this.View_LN.Name = "View_LN";
            this.View_LN.ReadOnly = false;
            this.View_LN.Size = new System.Drawing.Size(194, 27);
            this.View_LN.TabIndex = 14;
            this.View_LN.Visible = false;
            // 
            // View_Email
            // 
            this.View_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Email.Location = new System.Drawing.Point(379, 349);
            this.View_Email.Name = "View_Email";
            this.View_Email.ReadOnly = false;
            this.View_Email.Size = new System.Drawing.Size(194, 27);
            this.View_Email.TabIndex = 17;
            this.View_Email.Visible = false;
            // 
            // View_Add
            // 
            this.View_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Add.Location = new System.Drawing.Point(379, 402);
            this.View_Add.Name = "View_Add";
            this.View_Add.ReadOnly = false;
            this.View_Add.Size = new System.Drawing.Size(194, 27);
            this.View_Add.TabIndex = 20;
            this.View_Add.Visible = false;
            // 
            // View_Phone_Num
            // 
            this.View_Phone_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Phone_Num.Location = new System.Drawing.Point(379, 454);
            this.View_Phone_Num.Name = "View_Phone_Num";
            this.View_Phone_Num.ReadOnly = false;
            this.View_Phone_Num.Size = new System.Drawing.Size(194, 27);
            this.View_Phone_Num.TabIndex = 22;
            this.View_Phone_Num.Visible = false;
            // 
            // GuestLastName
            // 
            this.GuestLastName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GuestLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestLastName.Location = new System.Drawing.Point(112, 295);
            this.GuestLastName.Multiline = true;
            this.GuestLastName.Name = "GuestLastName";
            this.GuestLastName.ReadOnly = true;
            this.GuestLastName.Size = new System.Drawing.Size(235, 33);
            this.GuestLastName.TabIndex = 23;
            this.GuestLastName.Text = "Guest\'s Last Name";
            this.GuestLastName.Visible = false;
            // 
            // GuestEmail
            // 
            this.GuestEmail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GuestEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestEmail.Location = new System.Drawing.Point(112, 343);
            this.GuestEmail.Multiline = true;
            this.GuestEmail.Name = "GuestEmail";
            this.GuestEmail.ReadOnly = true;
            this.GuestEmail.Size = new System.Drawing.Size(235, 33);
            this.GuestEmail.TabIndex = 24;
            this.GuestEmail.Text = "Guest\'s Email";
            this.GuestEmail.Visible = false;
            // 
            // GuestAddress
            // 
            this.GuestAddress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GuestAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestAddress.Location = new System.Drawing.Point(112, 396);
            this.GuestAddress.Multiline = true;
            this.GuestAddress.Name = "GuestAddress";
            this.GuestAddress.ReadOnly = true;
            this.GuestAddress.Size = new System.Drawing.Size(235, 33);
            this.GuestAddress.TabIndex = 25;
            this.GuestAddress.Text = "Guest\'s Address";
            this.GuestAddress.Visible = false;
            // 
            // GuestPhoneNumber
            // 
            this.GuestPhoneNumber.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GuestPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestPhoneNumber.Location = new System.Drawing.Point(112, 448);
            this.GuestPhoneNumber.Multiline = true;
            this.GuestPhoneNumber.Name = "GuestPhoneNumber";
            this.GuestPhoneNumber.ReadOnly = true;
            this.GuestPhoneNumber.Size = new System.Drawing.Size(235, 33);
            this.GuestPhoneNumber.TabIndex = 26;
            this.GuestPhoneNumber.Text = "Guest\'s Phone Number";
            this.GuestPhoneNumber.Visible = false;
            // 
            // Guest_Info_Box
            // 
            this.Guest_Info_Box.Controls.Add(this.Delete_Guest);
            this.Guest_Info_Box.Controls.Add(this.Update_Guest);
            this.Guest_Info_Box.Location = new System.Drawing.Point(86, 103);
            this.Guest_Info_Box.Name = "Guest_Info_Box";
            this.Guest_Info_Box.Size = new System.Drawing.Size(559, 459);
            this.Guest_Info_Box.TabIndex = 27;
            this.Guest_Info_Box.TabStop = true;
            this.Guest_Info_Box.Text = "Guest Information";
            this.Guest_Info_Box.Visible = false;
            this.Guest_Info_Box.BackColor = Color.LightGray;
            // 
            // Delete_Guest
            // 
            this.Delete_Guest.BackColor = System.Drawing.Color.Tomato;
            this.Delete_Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Guest.Location = new System.Drawing.Point(293, 422);
            this.Delete_Guest.Name = "Delete_Guest";
            this.Delete_Guest.Size = new System.Drawing.Size(118, 31);
            this.Delete_Guest.TabIndex = 2;
            this.Delete_Guest.Text = "Delete Guest";
            this.Delete_Guest.UseVisualStyleBackColor = false;
            this.Delete_Guest.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Guest
            // 
            this.Update_Guest.BackColor = System.Drawing.Color.PaleGreen;
            this.Update_Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Guest.Location = new System.Drawing.Point(141, 422);
            this.Update_Guest.Name = "Update_Guest";
            this.Update_Guest.Size = new System.Drawing.Size(112, 31);
            this.Update_Guest.TabIndex = 1;
            this.Update_Guest.Text = "Update Guest";
            this.Update_Guest.UseVisualStyleBackColor = false;
            this.Update_Guest.Click += new System.EventHandler(this.Update_Guest_Click);
            // 
            // Guest_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(808, 495);
            this.Controls.Add(this.GuestPhoneNumber);
            this.Controls.Add(this.GuestAddress);
            this.Controls.Add(this.GuestEmail);
            this.Controls.Add(this.GuestLastName);
            this.Controls.Add(this.View_Phone_Num);
            this.Controls.Add(this.View_Add);
            this.Controls.Add(this.View_Email);
            this.Controls.Add(this.View_LN);
            this.Controls.Add(this.View_MI);
            this.Controls.Add(this.GuestMiddleinitial);
            this.Controls.Add(this.View_FN);
            this.Controls.Add(this.Guest_First_Name);
            this.Controls.Add(this.View_NID);
            this.Controls.Add(this.Guest_NID);
            this.Controls.Add(this.Guest_Not_Registerd);
            this.Controls.Add(this.Confirm_NID);
            this.Controls.Add(this.Input_NID);
            this.Controls.Add(this.Guest_NID_Text);
            this.Controls.Add(this.Guest_Info_Box);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Guest_Select";
            this.Text = "Guest_Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Guest_NID_Text;
        private System.Windows.Forms.TextBox Input_NID;
        private System.Windows.Forms.Button Confirm_NID;
        private System.Windows.Forms.Label Guest_Not_Registerd;
        private System.Windows.Forms.TextBox View_NID;
        private System.Windows.Forms.TextBox Guest_NID;
        private System.Windows.Forms.TextBox View_FN;
        private System.Windows.Forms.TextBox Guest_First_Name;
        private System.Windows.Forms.TextBox View_MI;
        private System.Windows.Forms.TextBox GuestMiddleinitial;
        private System.Windows.Forms.TextBox View_LN;
        private System.Windows.Forms.TextBox View_Email;
        private System.Windows.Forms.TextBox View_Add;
        private System.Windows.Forms.TextBox View_Phone_Num;
        private System.Windows.Forms.TextBox GuestLastName;
        private System.Windows.Forms.TextBox GuestEmail;
        private System.Windows.Forms.TextBox GuestAddress;
        private System.Windows.Forms.TextBox GuestPhoneNumber;
        private System.Windows.Forms.GroupBox Guest_Info_Box;
        private System.Windows.Forms.Button Delete_Guest;
        private System.Windows.Forms.Button Update_Guest;
    }
}

