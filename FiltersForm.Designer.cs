using System.Windows.Forms;

namespace HotelManagementSystem
{
    partial class FiltersForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label roomTypeLabel;
        private ComboBox roomTypeComboBox;
        private Label priceLabel;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private Label branchLabel;
        private ComboBox branchComboBox;
        private Label statusLabel;
        private CheckBox statusCheckBox;
        private Button okButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Filters";
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.BackColor = System.Drawing.Color.MediumAquamarine;

            // Room Type Label
            roomTypeLabel = new Label();
            roomTypeLabel.Text = "Room type:";
            roomTypeLabel.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(roomTypeLabel);

            // Room Type ComboBox
            roomTypeComboBox = new ComboBox();
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            roomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomTypeComboBox.Location = new System.Drawing.Point(120, 18);
            this.Controls.Add(roomTypeComboBox);

            // Price Range Label
            priceLabel = new Label();
            priceLabel.Text = "Price range:";
            priceLabel.Location = new System.Drawing.Point(20, 60);
            this.Controls.Add(priceLabel);

            // Min Price TextBox
            minTextBox = new TextBox();
            minTextBox.Location = new System.Drawing.Point(120, 58);
            minTextBox.Width = 60;
            this.Controls.Add(minTextBox);

            // Max Price TextBox
            maxTextBox = new TextBox();
            maxTextBox.Location = new System.Drawing.Point(190, 58);
            maxTextBox.Width = 60;
            this.Controls.Add(maxTextBox);

            // Branch Label
            branchLabel = new Label();
            branchLabel.Text = "Branch:";
            branchLabel.Location = new System.Drawing.Point(20, 100);
            this.Controls.Add(branchLabel);

            // Branch ComboBox
            branchComboBox = new ComboBox();
            branchComboBox.Items.AddRange(new object[] { "Downtown", "Airport", "Seaside" });
            branchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            branchComboBox.Location = new System.Drawing.Point(120, 98);
            this.Controls.Add(branchComboBox);

            // Status Available Label
            statusLabel = new Label();
            statusLabel.Text = "Status Available?";
            statusLabel.Location = new System.Drawing.Point(20, 140);
            this.Controls.Add(statusLabel);

            // Status Checkbox
            statusCheckBox = new CheckBox();
            statusCheckBox.Location = new System.Drawing.Point(160, 138);
            this.Controls.Add(statusCheckBox);

            // OK Button
            okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new System.Drawing.Point(280, 230);
            okButton.Click += new System.EventHandler(this.okButton_Click);
            this.Controls.Add(okButton);
        }
    }
}