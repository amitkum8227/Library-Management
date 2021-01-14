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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setItemSources();
        }

        public void setItemSources()
        {

            GridBook.ItemsSource = Library.ListLibrary;
            PeopleName.ItemsSource = MemberManager.ListMembers;
        }

        private void Click_MediaInfo(object sender, RoutedEventArgs e)
        {
            if (GridBook.SelectedItem != null)
            {
                


                //MediaInfo mediainfo = (MediaInfo)peopleGrid.SelectedItems[0];
                object currentContent = this.Content;
                Media data = (Media)GridBook.SelectedItems[0];
                //DetailMediaInfo detailsinfo = new DetailMediaInfo(currentContent);
                MediaInfoPage pg = new MediaInfoPage(currentContent, data);
                this.Content = pg;
            }
        }

        private void Click_MemberInfo(object sender, RoutedEventArgs e)
        {
            if (PeopleName.SelectedItem != null)
            {



                //MediaInfo mediainfo = (MediaInfo)peopleGrid.SelectedItems[0];
                object currentContent = this.Content;
                LibraryMember data = (LibraryMember)PeopleName.SelectedItems[0];
                //DetailMediaInfo detailsinfo = new DetailMediaInfo(currentContent);
                PageMemberInfo pg = new PageMemberInfo(currentContent, data);
                this.Content = pg;
            }
        }

        private void Click_LendMedia(object sender, RoutedEventArgs e)
        {
            if ((Media)GridBook.SelectedItem != null && (LibraryMember)PeopleName.SelectedItem != null)
            {



                Media mediaList = (Media)GridBook.SelectedItem;
                LibraryMember memberList = (LibraryMember)PeopleName.SelectedItem;

                if (mediaList.Availability)
                {
                    showErrorDialoge("Sorry Media is not available.");
                }
                else {

                    mediaList.Availability = !(mediaList.Availability);
                    mediaList.Borrower = memberList.Name;
                    //LibraryManager.ListLibrary.;
                    RefreshDataGrid();
                }
                

            }
            else {

                showErrorDialoge("Please select member and media both");
            }
        }

        private void Click_ReturnMedia(object sender, RoutedEventArgs e)
        {
            if ((Media)GridBook.SelectedItem != null)
            {
                Media mediaList = (Media)GridBook.SelectedItem;
                if (mediaList.Availability)
                {
                    mediaList.Availability = !(mediaList.Availability);
                    mediaList.Borrower = "";
                    RefreshDataGrid();

                }
                else {
                    showErrorDialoge("Media is not Lended");
                }
            }
            else {
                showErrorDialoge("Please select media");
            }
        }

        public void RefreshDataGrid()
        {
            GridBook.ItemsSource = null;
            GridBook.ItemsSource = Library.ListLibrary.ToList();
        }
        
        public void RefreshMemberNameGrid()
        {
            PeopleName.ItemsSource = null;
           
            PeopleName.ItemsSource = MemberManager.ListMembers;

        }

        private void showErrorDialoge(string error)
        {

            MessageBox.Show(error, "ERROR", MessageBoxButton.OK);

        }

        private void Click_ModifyMedia(object sender, RoutedEventArgs e)
        {
            if ((Media)GridBook.SelectedItem != null)
            {
                object currentContent = this.Content;
                Media librarydata = (Media)GridBook.SelectedItem;
                ModifyMedia newPage = new ModifyMedia(currentContent, librarydata);
                this.Content = newPage;
            }
            else {
                showErrorDialoge("Please select media");
            }
        }

        private void Click_ModifyMember(object sender, RoutedEventArgs e)
        {
            if ((LibraryMember)PeopleName.SelectedItem != null)
            {
                object currentContent = this.Content;
                LibraryMember librarydata = (LibraryMember)PeopleName.SelectedItem;
                ModifyMembers newPage = new ModifyMembers(currentContent, librarydata);
                this.Content = newPage;
            }
            else
            {
                showErrorDialoge("Please select member");
            }
        }
    }

    
}
