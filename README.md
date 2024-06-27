# BankLibraryAPP

BankUIForm is a C# Windows Forms application for managing bank account information. This application provides methods to clear text boxes, set text box values from an array, and retrieve text box values as an array.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Methods](#methods)
- [Contributing](#contributing)
- [License](#license)

## Installation

To use BankUIForm in your project, follow these steps:

1. Clone the repository:
git clone https://github.com/IgorSantanaM/BankLibraryAPP.git

2. Add the `BankUIForm.cs` file to your Visual Studio project.

3. Ensure your project targets .NET Framework compatible with Windows Forms.

## Usage

To use BankUIForm in your application:

1. Create an instance of `BankUIForm` in your code.

2. Use the provided methods to interact with text boxes:
- `ClearTextBoxes()`: Clears all text boxes on the form.
- `SetTextBoxValues(string[] values)`: Sets text box values based on a string array.
- `GetTextBoxValues()`: Retrieves text box values as a string array.
  
## Contributing

Contributions are welcome! If you find a bug or want to enhance this application, feel free to open an issue or submit a pull request. Make sure to follow these guidelines:

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -am 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Open a pull request.

Example usage:

```csharp
// Instantiate BankUIForm
BankUIForm bankForm = new BankUIForm();

// Set values
string[] data = { "123456789", "John", "Doe", "1000.00" };
bankForm.SetTextBoxValues(data);

// Retrieve values
string[] retrievedData = bankForm.GetTextBoxValues();
```

Replace `https://github.com/IgorSantanaM/BankLibraryAPP.git` with your actual repository URL where this `BankUIForm.cs` file resides. This Markdown file is structured to display properly on GitHub, with headers, code blocks, and lists formatted accordingly. Adjust the content and details as per your specific project requirements.

