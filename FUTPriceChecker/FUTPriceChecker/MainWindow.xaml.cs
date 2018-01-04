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
using System.Net;
using Supremes;

namespace FUTPriceChecker
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

        private void BTN_CheckPrices_Click(object sender, RoutedEventArgs e)
        {
            //WebClient wc = new WebClient();
            //string webData = wc.DownloadString("https://www.futbin.com/18/player/307/Roberto%20Firmino/");
            
            var doc = Dcsoup.Parse(new Uri("https://www.futbin.com/18/player/307/Roberto%20Firmino/"), 5000);
            var lowPS4 = doc.Select("span#ps-lowest-1");
            string webData = lowPS4.Text;
            TBK_Results.Text = webData;
        }
    }
}
