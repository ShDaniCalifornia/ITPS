using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStudentPages.xaml
    /// </summary>
    public partial class AddStudentPages : Page
    {
        public AddStudentPages()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
        }
    }
}
