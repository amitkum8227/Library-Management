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
    /// Interaction logic for ModifyMedia.xaml
    /// </summary>
    public partial class ModifyMedia : Page
    {

        object previousContent;
        //public enum setvaibility { Available, Not  };
        Media libraryobj;

        public ModifyMedia(object _previousContent, Media data)
        {
            InitializeComponent();

            libraryobj = data;
            previousContent = _previousContent;
            mediatype.ItemsSource = typeof(BookType).GetEnumValues();
            //availablity.ItemsSource = typeof(setvaibility).GetEnumValues();
            titleBox.Text = libraryobj.Title;
            mediatype.Text = libraryobj.Type.ToString();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

            libraryobj.Title = titleBox.Text;

            if (mediatype.Text == "Book")
            {
                libraryobj.Type = BookType.Book;
            }
            else if (mediatype.Text == "Magzine")
            {
                libraryobj.Type = BookType.Magzine;

            }
            else if (mediatype.Text == "Movie")
            {
                libraryobj.Type = BookType.Movie;

            }

            ((MainWindow)Application.Current.MainWindow).RefreshDataGrid();
            ((MainWindow)Application.Current.MainWindow).Content = previousContent;

            

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Content = previousContent;

        }
    }
}
