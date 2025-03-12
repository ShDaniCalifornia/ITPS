using System.Windows;

namespace Control11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BodyFrame.Navigate(new View.Pages.StartPage());
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFrame.Navigate(new View.Pages.StartPage());
        }

        private void CollectionEntry_Click(object sender, RoutedEventArgs e)
        {
            BodyFrame.Navigate(new View.Pages.CollectionEntryPages());
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            BodyFrame.Navigate(new View.Pages.ReportPages());
        }
    }
}
