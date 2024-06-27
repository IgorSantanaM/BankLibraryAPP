namespace BankLibrary
{
    partial class BankUIForm
    {
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;

        private void InitializeComponent()
        {
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // accountTextBox
            this.accountTextBox.Location = new System.Drawing.Point(13, 13);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(100, 20);

            // firstNameTextBox
            this.firstNameTextBox.Location = new System.Drawing.Point(13, 39);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);

            // lastNameTextBox
            this.lastNameTextBox.Location = new System.Drawing.Point(13, 65);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);

            // balanceTextBox
            this.balanceTextBox.Location = new System.Drawing.Point(13, 91);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);

            // BankUIForm
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.balanceTextBox);
            this.Name = "BankUIForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
