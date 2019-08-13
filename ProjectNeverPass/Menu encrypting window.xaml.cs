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
    /// Interaction logic for Menu_encrypting_window.xaml
    /// </summary>
    public partial class Menu_encrypting_window : Window
    {
        string pathtostoreinfo="";
        public Menu_encrypting_window()
        {
            InitializeComponent();
        }

        private void Add_Information_Click(object sender, RoutedEventArgs e)
        {
            Backend.Addlogs("Add information button was clicked");
            pathtostoreinfo = FilePath.Text;
            if (pathtostoreinfo == "")
            {
                MessageBox.Show("Please Enter the path");
            }
            else
            {
                pathtostoreinfo = FilePath.Text;
                string fulltext = "Website: " + Website.Text + " Username: " + Username_to_be_stored.Text + " Password: " + Password_Tobestored.Text;
                //string textobestored = CryptoString.Encrypt(fulltext);
                //string pathtostoreinfo = @"C:\ProjectNeverPass\StoredInformation.txt";
                //File.Create(pathtostoreinfo);
                //Encypting the file by firswt reading storing it then adding new information to the file and then encrypting it.
                List<string> lines = File.ReadAllLines(pathtostoreinfo).ToList();
                lines.Add(fulltext);
                File.WriteAllLines(pathtostoreinfo, lines);
                Backend.FileEncrypt(pathtostoreinfo, "123456");
                MessageBox.Show("Your Information has been added succesfully");
                Backend.Addlogs("All the infromation was succesfully added and ecrypted");
            }
        }

        private void Decrypt_button_Click(object sender, RoutedEventArgs e)
        {
            Backend.Addlogs("The Decrypt button was clicked");
            DecryptedInformation decyptedwindow = new DecryptedInformation();
            this.Hide();
            decyptedwindow.Show();
        }

        private void SelectPath_Button_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> inputFile = openFileDlg.ShowDialog();

            if (inputFile == true)
            {
                // Open document 
                string filename = openFileDlg.FileName;
                FilePath.Text = filename;
                Backend.Addlogs("The Path for encryption was selected ");
            }
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            //closes the application
            this.Close();
            
        }
    }
}
