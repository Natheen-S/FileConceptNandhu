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
using System.IO;
namespace FileConcept.diarypages
{
    /// <summary>
    /// Interaction logic for diarypage.xaml
    /// </summary>
    public partial class diarypage : Page
    {
        public diarypage() 
        {

            InitializeComponent();
        }
        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        

        private void btn_click(object sender, RoutedEventArgs e)
        {
            string date = "jan1";
            string content = "hello";

            File.WriteAllText(@"C:\Users\nathe\source\repos\FileConcept"+ date +".txt",content);
        
        }
    }
}
