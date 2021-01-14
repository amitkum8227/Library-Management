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

namespace NewProject
{
    /// <summary>
    /// Interaction logic for PageMediaInfo.xaml
    /// </summary>
    public partial class PageMediaInfo : Window
    {
        object previousContent;

        public PageMediaInfo(object _previousContent, Media data)
        {
            InitializeComponent();
            previousContent = _previousContent;
            Text_MediaTitle.Text = data.Title;
            Text_Borrower.Text = data.Borrower;
            Text_Availiblity.Text = (data.Availability) ? "Avalable" : "Not available";
             //if(data.Availability)? Text_Availiblity.Text = "Avalable" : Text_Availiblity.Text = "Not Avalable";
             
            //mediainfo = data;
        }
    }
}
