using System;
using System.Windows.Forms;
using System.IO;
using BankLibrary;

namespace CreateFile
{
    public partial class CreateFileForm : BankUIForm
    {
        private StreamWriter fileWriter; // writes data to text file

        public CreateFileForm()
        {
            InitializeComponent();
        }

        // Event handler for Save Button
        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // let user create file
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // name of file to save data
            }

            // Ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                // Show error if user specified invalid file
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Save file via FileStream if user specified valid file
                    try
                    {
                        // Open file with write access
                        FileStream output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        fileWriter = new StreamWriter(output);

                        // Disable Save button and enable Enter button
                        saveButton.Enabled = false;
                        enterButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        // Notify user if file does not exist
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Handler for Enter Button Click
        private void enterButton_Click(object sender, EventArgs e)
        {
            // Store TextBox values string array
            string[] values = GetTextBoxValues();

            // Record containing TextBox values to output
            Record record = new Record();

            // Determine whether TextBox account field is empty
            if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.ACCOUNT]))
            {
                // Store TextBox values in Record and output it
                try
                {
                    // Get account-number value from TextBox
                    int accountNumber = int.Parse(values[(int)TextBoxIndices.ACCOUNT]);

                    // Determine whether accountNumber is valid
                    if (accountNumber > 0)
                    {
                        // Store TextBox fields in Record
                        record.Account = accountNumber;
                        record.FirstName = values[(int)TextBoxIndices.FIRST];
                        record.LastName = values[(int)TextBoxIndices.LAST];
                        record.Balance = decimal.Parse(values[(int)TextBoxIndices.BALANCE]);

                        // Write Record to file, fields separated by commas
                        fileWriter.WriteLine($"{record.Account},{record.FirstName},{record.LastName},{record.Balance}");
                    }
                    else
                    {
                        // Notify user if invalid account number
                        MessageBox.Show("Invalid Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException)
                {
                    // Notify user if error occurs during the output operation
                    MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    // Notify user if error occurs regarding parameter format
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearTextBoxes(); // Clear TextBox values
        }

        // Handler for Exit Button Click
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Determine whether file exists
            if (fileWriter != null)
            {
                try
                {
                    // Close StreamWriter and underlying file
                    fileWriter.Close();
                }
                catch (IOException)
                {
                    // Notify user of error closing file
                    MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Exit();
        }
    }
}
