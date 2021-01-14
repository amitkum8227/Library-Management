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
    /// Interaction logic for ModifyMembers.xaml
    /// </summary>
    public partial class ModifyMembers : Page
    {
        object previousContent;
        //public enum setvaibility { Available, Not  };
        LibraryMember libraryMemberObj;
        public ModifyMembers(object _previousContent, LibraryMember data)
        {
            InitializeComponent();
            libraryMemberObj = data;
            previousContent = _previousContent;
            NameBox.Text = libraryMemberObj.Name;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Content = previousContent;

        }

        private void CLick_Update(object sender, RoutedEventArgs e)
        {
            libraryMemberObj.Name = NameBox.Text;



            ((MainWindow)Application.Current.MainWindow).RefreshMemberNameGrid();
            ((MainWindow)Application.Current.MainWindow).Content = previousContent;

        }
    }
}
