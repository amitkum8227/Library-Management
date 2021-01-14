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
    /// Interaction logic for PageMemberInfo.xaml
    /// </summary>
    public partial class PageMemberInfo : Page
    {
        object previousContent;

        public PageMemberInfo(object _previousContent, LibraryMember data)
        {
            InitializeComponent();
            previousContent = _previousContent;
            Text_MemberNaame.Text = data.Name;
             //if(data.Availability)? Text_Availiblity.Text = "Avalable" : Text_Availiblity.Text = "Not Avalable";

            //mediainfo = data;
        }

        private void Text_MemberNaame_IsStylusCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Click_CloseMemberInfo(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = previousContent;

        }
    }
}
