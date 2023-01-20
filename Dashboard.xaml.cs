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
using FileConcept.diarypages;
namespace FileConcept
{


    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        diarypage diarypage;
        MainWindow regpage;
        public Dashboard()
        {
            InitializeComponent();
            diarypage = new diarypage();
            regpage = new MainWindow();
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

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {


            WindowState = WindowState.Minimized;

        }



        private void btn_maximize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_backward_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
            else
            {
                MessageBox.Show("No Back Page");
            }
        }

        private void btn_forward_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoForward)
            {
                Frame.GoForward();
            }
            else
            {
                MessageBox.Show("No Next Page");
            }
        }

        private void btn_registration_Click(object sender, RoutedEventArgs e)
        {

            regpage.Show();
        }

        private void btn_diary_Click(object sender, RoutedEventArgs e)
        {
            
            Frame.Content = diarypage;
        }
    }
}
