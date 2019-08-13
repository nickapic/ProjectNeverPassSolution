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

namespace ProjectNeverPass
{
    /// <summary>
    /// Interaction logic for Register_Window.xaml
    /// </summary>
    public partial class Register_Window : Window
    {
        public Register_Window()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

            if (Username_reg.Text == "" || Passwordtoregister.Password == "")
            {
                MessageBox.Show("Please fill the two important fields ");
            }
            else
            {
                string salt;
                string hashedpswrd = HashingAlgorihtm.GeneratePasswordHashAndSalt(Passwordtoregister.Password, out salt);

                PersonalInformation Userinfo = new PersonalInformation(Username_reg.Text, hashedpswrd, salt, First_name_reg.Text, Last_name_reg.Text, email_reg.Text);
                
                MainWindow mainmenu = new MainWindow();
                mainmenu.Show();
                this.Close();
                Backend.Addlogs("A user was registered succesfully");
            }

        }
    }
}
