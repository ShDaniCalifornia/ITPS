using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для JournalPages.xaml
    /// </summary>
    public partial class JournalPages : Page
    {
        public JournalPages()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
        }
    }
}
