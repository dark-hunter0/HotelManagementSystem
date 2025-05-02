using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    partial class RoomSelectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filtersButton = new System.Windows.Forms.Button();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(1317, 618);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(91, 42);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(637, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose room:";
            // 
            // filtersButton
            // 
            this.filtersButton.Location = new System.Drawing.Point(1282, 40);
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.Size = new System.Drawing.Size(100, 30);
            this.filtersButton.TabIndex = 3;
            this.filtersButton.Text = "Filters";
            this.filtersButton.UseVisualStyleBackColor = true;
            this.filtersButton.Click += new System.EventHandler(this.filtersButton_Click);
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            this.roomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.roomDataGridView.Location = new System.Drawing.Point(30, 90);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            this.roomDataGridView.RowHeadersWidth = 62;
            this.roomDataGridView.Size = new System.Drawing.Size(1378, 500);
            this.roomDataGridView.TabIndex = 4;
            // 
            // Columns
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Room Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;

            this.dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;

            this.dataGridViewTextBoxColumn3.HeaderText = "Floor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;

            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;

            this.dataGridViewTextBoxColumn5.HeaderText = "Night Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;

            this.dataGridViewTextBoxColumn6.HeaderText = "Hotel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;

            this.dataGridViewTextBoxColumn7.HeaderText = "Room ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;

            // 
            // RoomSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 683);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtersButton);
            this.Controls.Add(this.roomDataGridView);
            this.Name = "RoomSelectionForm";
            this.Text = "Room Selection";
            this.Load += new System.EventHandler(this.RoomSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtersButton;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
