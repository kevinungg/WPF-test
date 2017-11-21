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

namespace WPF_test
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

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            lbl2.Content = "Doge was de titel van het staatshoofd van een aantal Italiaanse republieken.\r\n" +
                "Het woord is verwant aan het Latijnse dux, dat in andere contexten als hertog wordt vertaald.\r\n " +
                "Het Italiaanse meervoud is dogi, het Nederlandse ook wel dogen of doges.\r\n " +
                "De echtgenote van de doge (er waren geen vrouwelijke dogen) werd wel dogana genoemd.";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=JZtnoxSYYfo");
        }
    }
}
