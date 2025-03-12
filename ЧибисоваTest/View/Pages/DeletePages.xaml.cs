using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DeletePages.xaml
    /// </summary>
    public partial class DeletePages : Page
    {
        public DeletePages()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
        }
    }
}
