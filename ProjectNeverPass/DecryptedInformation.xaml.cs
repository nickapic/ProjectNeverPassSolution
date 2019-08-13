using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace ProjectNeverPass
{
    
    /// <summary>
    /// Interaction logic for DecryptedInformation.xaml
    /// </summary>
    public partial class DecryptedInformation : Window
    {
        
        string inputpath = "";
        string outputpath = @"C:\Default.txt";
        public DecryptedInformation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Backend.Addlogs("The verify button was clicked");
            if (Passwordtoverify.Password == "123456")
            {
                inputpath = FilePath2.Text;
                outputpath = FilePath3.Text;
                Backend.FileDecrypt(inputpath, outputpath, Passwordtoverify.Password);
                string text = File.ReadAllText(outputpath).ToString();
                Richtextbox.AppendText(text);
                Backend.Addlogs("The verification was done and the file was decrypted");
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void SelectPATH_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> inputFile = openFileDlg.ShowDialog();

            if (inputFile == true)
            {
                // Open document 
                string filename = openFileDlg.FileName;
                FilePath2.Text = filename;
                Backend.Addlogs("The Path of the encrypted file was selected");
            }
           
        }

        private void Selectagain_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> inputFile = openFileDlg.ShowDialog();

            if (inputFile == true)
            {
                // Open document 
                string filename = openFileDlg.FileName;
                FilePath3.Text = filename;
                Backend.Addlogs("The path to store the decrypted the file was select");
            }
            
        }

        private void Close_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

