using Control7.AppData;
using System.Windows.Controls;

namespace Control7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PanelPages.xaml
    /// </summary>
    public partial class PanelPages : Page
    {
        public PanelPages()
        {
            InitializeComponent();

        }

        private void AddManufacturerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddManufacturerPages());
        }

        private void AddProductBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddProductPages());
        }

        private void AddEmployeeBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddEmployeePages());
        }

        private void RecordsBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.RecordsPages());
        }

        private void ReportBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.ReportPages());
        }
    }
}
