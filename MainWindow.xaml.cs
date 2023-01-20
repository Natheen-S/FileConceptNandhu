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

namespace FileConcept
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Close();
            }
        }

        private void chkbox_pass_Checked(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = passwordBox.Password;
            passwordBox.Visibility = Visibility.Hidden;
            passwordTxtBox.Visibility = Visibility.Visible;
        }

        private void chkbox_pass_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = passwordTxtBox.Text;
            passwordTxtBox.Visibility = Visibility.Hidden;
            passwordBox.Visibility = Visibility.Visible;
        }

        private void btnlogin_submit_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_username.Text == passwordBox.Password)
            {
                Dashboard odashboard = new Dashboard();
                odashboard.Show();
            }
            else
            {
                MessageBox.Show("Enter all the details", "Error", MessageBoxButton.OKCancel);
            }
        }
    }
}







