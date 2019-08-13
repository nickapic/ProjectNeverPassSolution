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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectNeverPass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Register_button_Click(object sender, RoutedEventArgs e)
        {
            //create register window and close this one and open it.
            Register_Window regwindow = new Register_Window();
            regwindow.Show();
            this.Hide();
            Backend.Addlogs("The Register button was clicked");
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            Backend.Addlogs("The Login button was clicked");
            if ( HashingAlgorihtm.login(username_textbox.Text, PasswordBox.Password) == true)
            {
                this.Close();
                //Menu_encrypting_window menu = new Menu_encrypting_window();
                //menu.Show();
                Backend.Addlogs("The User was logged in");
            }
            else
            {
                MessageBox.Show("Wrong Details were entered");
                Backend.Addlogs("The User enetered wrong details");
            }
            
        }

        private void Log_Select_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> inputFile = openFileDlg.ShowDialog();

            if (inputFile == true)
            {
                // Open document 
                string filename = openFileDlg.FileName;
                Logfile.Text = filename;
                Backend.SetLogsPath(filename);
            }

        }

        private void Manual_Click(object sender, RoutedEventArgs e)
        {
            string filename = @"C:\ProjectNeverPassSolution\ProjectNeverPass\Resources\User Manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
}
