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

namespace NewProject
{
    /// <summary>
    /// Interaction logic for MediaInfoPage.xaml
    /// </summary>
    public partial class MediaInfoPage : Page
    {
        object previousContent;

        public MediaInfoPage(object _previousContent, Media data)
        {
            InitializeComponent();
            previousContent = _previousContent;
            Text_MediaTitle.Text = data.Title;
            Text_Borrower.Text = data.Borrower;
            Text_Availiblity.Text = (data.Availability) ? "Available" : "Not Available";
            //if(data.Availability)? Text_Availiblity.Text = "Avalable" : Text_Availiblity.Text = "Not Avalable";

            //mediainfo = data;
        }

        private void Button_Closes(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = previousContent;

        }
    }
}
