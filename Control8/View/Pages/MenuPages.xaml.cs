using Control8.Class;
using System.Windows;
using System.Windows.Controls;

namespace Control8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPages.xaml
    /// </summary>
    public partial class MenuPages : Page
    {
        public MenuPages()
        {
            InitializeComponent();
        }

        private void HL1_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddGroupPages());
        }

        private void Hl2_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddDirectionPages());
        }

        private void HL3_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AccountingPages());
        }

        private void HL4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HL5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
