using System;
using System.Windows.Forms;
using BankLibrary;

namespace BankApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankUIForm bankForm = new BankUIForm();
            bankForm.MdiParent = this;
            bankForm.Show();
        }
    }
}
