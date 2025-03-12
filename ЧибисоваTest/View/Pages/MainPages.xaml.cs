using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPages.xaml
    /// </summary>
    public partial class MainPages : Page
    {
        public MainPages()
        {
            InitializeComponent();
        }

        private void TeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.LoginTeacherPages());
        }

        private void StudentBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
